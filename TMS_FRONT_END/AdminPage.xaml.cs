using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TMS_DB.Context;
using TMS_DB.Model;
using TMS_FRONT_END;

namespace TMS_Front_nd
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class AdminPage : Page
    {

        public TMS_DB_Connect tMS_DB_Connect = new TMS_DB_Connect();
        public AdminPage()
        {
            InitializeComponent();

            

            try
            {
                List<Carrier> carriers = tMS_DB_Connect.Carriers.ToList();


                // Now you have a list of Carrier objects, you can use it to bind to the DataGrid
                if (carrierDataGrid != null)
                {
                    carrierDataGrid.ItemsSource = carriers;
                }
                else
                {
                    MessageBox.Show("carrierDataGrid is not initialized.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BackupButton_Click(object sender, RoutedEventArgs e)
        {

            bool backUpStatus = tMS_DB_Connect.Backup(BackupDirectoryTextBox.Text);

            if (backUpStatus)
            {
                MessageBox.Show("Back Up Successful");
            }
            else
            {
                MessageBox.Show("BackUp Failed");
            }

        }

        private void SaveCarrierDataButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReviewLogFilesButton_Click(object sender, RoutedEventArgs e)
        {

            TMS_DB_Connect tmsDbContext = new TMS_DB_Connect();

            try
            {
                List<LogEntry> Logs = tmsDbContext.LogEntries.ToList();


                // Now you have a list of Carrier objects, you can use it to bind to the DataGrid
                if (carrierDataGrid != null)
                {
                    LogFileGrid.ItemsSource = Logs;
                }
                else
                {
                    MessageBox.Show("Log is not initialized.");
                }

                tMS_DB_Connect.Log("INFO", "Log Info Accessed.");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }


        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (TMS_DB_Connect tmsDbContext = new TMS_DB_Connect())
                {
                    // Retrieve the modified Carrier objects from the DataGrid
                    List<Carrier> modifiedCarriers = carrierDataGrid.ItemsSource.Cast<Carrier>().ToList();

                    foreach (var modifiedCarrier in modifiedCarriers)
                    {
                        var existingCarrier = tmsDbContext.Carriers.FirstOrDefault(c => c.CarrierID == modifiedCarrier.CarrierID);
                        if (existingCarrier != null)
                        {
                            // Update the properties of the existing Carrier object with modified values
                            existingCarrier.CarrierName = modifiedCarrier.CarrierName;
                            existingCarrier.DepotCity = modifiedCarrier.DepotCity;
                            existingCarrier.FTLAvailability = modifiedCarrier.FTLAvailability;
                            existingCarrier.LTLAvailability = modifiedCarrier.LTLAvailability;
                            existingCarrier.FTLRate = modifiedCarrier.FTLRate;
                            existingCarrier.LTLRate = modifiedCarrier.LTLRate;
                            existingCarrier.ReefCharge = modifiedCarrier.ReefCharge;
                            // Update other properties as needed
                        }
                    }

                    // Save changes back to the database
                    tmsDbContext.SaveChanges();
                    MessageBox.Show("Changes saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PrintLogFilesButton_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                        List<LogEntry> logs = tMS_DB_Connect.LogEntries.ToList();

                        // Specify the directory path where you want to save the log file
                        string exportPath = LogFileDirectoryTextBox.Text;

                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(exportPath))
                        {
                            // Writing log entries
                            foreach (var log in logs)
                            {
                                file.WriteLine($"Log ID: {log.LogId}, Date: {log.Timestamp}, Message: {log.Description}");
                            }
                        }

                        MessageBox.Show("Logs exported to file successfully.");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        
    }
}
