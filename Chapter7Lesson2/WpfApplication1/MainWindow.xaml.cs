using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApplication1.NorthwindDataSet northwindDataSet = ((WpfApplication1.NorthwindDataSet)(this.FindResource("northwindDataSet")));
            // Load data into the table Customers. You can modify this code as needed.
            WpfApplication1.NorthwindDataSetTableAdapters.CustomersTableAdapter northwindDataSetCustomersTableAdapter = new WpfApplication1.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            northwindDataSetCustomersTableAdapter.Fill(northwindDataSet.Customers);
            System.Windows.Data.CollectionViewSource customersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customersViewSource")));
            customersViewSource.View.MoveCurrentToFirst();
            // Load data into the table Orders. You can modify this code as needed.
            WpfApplication1.NorthwindDataSetTableAdapters.OrdersTableAdapter northwindDataSetOrdersTableAdapter = new WpfApplication1.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            northwindDataSetOrdersTableAdapter.Fill(northwindDataSet.Orders);
            System.Windows.Data.CollectionViewSource ordersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ordersViewSource")));
            ordersViewSource.View.MoveCurrentToFirst();
        }
    }
}
