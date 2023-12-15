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

namespace TMS_Front_nd
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void BackupButton_Click(object sender, RoutedEventArgs e)
        {
            TMS_DB_Connect TMS_DB_Connect = new TMS_DB_Connect();

            bool backUpStatus = TMS_DB_Connect.Backup(BackupDirectoryTextBox.Text);

            if (backUpStatus)
            {
                MessageBox.Show("Back Up Successful");
            }
            else
            {
                MessageBox.Show("BackUp Failed");
            }

        }
    }
}
