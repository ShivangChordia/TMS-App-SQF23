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

namespace TMS_FRONT_END
{
    public partial class BuyerPage : Page
    {
        // Connection string details
        private string connectionString = "Server=159.89.117.198;Database=cmp;User=DevOSHT;Password=Snodgr4ss!;";

        public BuyerPage()
        {
            InitializeComponent();


        }

        private void Contract_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MarketPlace())
            {
                // Fetch all contracts from the database
                var contracts = context.contracts.ToList();

                // Bind the contracts to the grid
                contractDataGrid.ItemsSource = contracts;
            }

           

        }
    }
}
