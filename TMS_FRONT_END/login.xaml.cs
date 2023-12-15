using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using TMS_Front_nd;

namespace TMS_FRONT_END
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }


        // Assuming the "Login" button click event handler
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordBox.Password;

            // Check credentials against the database
            bool isValidUser = CheckCredentials(enteredUsername, enteredPassword);

            if (isValidUser)
            {
                // Authentication successful, proceed to the main application or dashboard
                loginStatus.Text = "Login successful!";
                // Navigate to the main application window or perform necessary actions

                if (roleComboBox.Text == "Admin")
                {
                    AdminPage adminPage = new AdminPage();
                    NavigationService.Navigate(adminPage);
                }
                else if (roleComboBox.Text == "Buyer")
                {
                    BuyerPage buyerPage = new BuyerPage();
                    NavigationService.Navigate(buyerPage);
                }
                else if (roleComboBox.Text == "Planner")
                {
                    PlannerPage plannerPage = new PlannerPage();
                    NavigationService.Navigate(plannerPage);
                }


            }
            else
            {
                // Display an error message for invalid credentials
                loginStatus.Text = "Invalid username or password!";
            }
        }

        // Function to check user credentials in the database
        private bool CheckCredentials(string username, string password)
        {
            if (roleComboBox.Text == "Admin")
            {
                using var context = new TMS_DB_Connect();

                if (username != null && password != null)
                {
                    var login = context.Admins.FirstOrDefault(l => l.AdminName == username);
                    if (login != null)
                    {
                        if (login.AdminPassword == password)
                        {
                            return true;

                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else
                {
                    return false;
                }
            }
            else if(roleComboBox.Text == "Buyer")
            {
                using var context = new TMS_DB_Connect();

                if (username != null && password != null)
                {
                    var login = context.Buyers.FirstOrDefault(l => l.BuyerName == username);
                    if (login != null)
                    {
                        if (login.BuyerPassword == password)
                        {
                            return true;

                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else
                {
                    return false;
                }
            }
            else if (roleComboBox.Text == "Planner")
            {
                using var context = new TMS_DB_Connect();

                if (username != null && password != null)
                {
                    var login = context.Planners.FirstOrDefault(l => l.PlannerName == username);
                    if (login != null)
                    {
                        if (login.PlannerPassword == password)
                        {
                            return true;

                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
    }
}
