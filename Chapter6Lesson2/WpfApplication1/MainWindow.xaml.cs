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
            foreach (var money in makeMoney())
            {
                listBox2.Items.Add(money);
            }
        }

        private IEnumerable<Money> makeMoney()
        {
            yield return new Money { OrderDate = new DateTime(1994, 1, 1), ExtendedPrice = 12m };
            yield return new Money { OrderDate = new DateTime(1995, 1, 1), ExtendedPrice = 10m };
            yield return new Money { OrderDate = new DateTime(1996, 1, 1), ExtendedPrice = 11m };
            yield return new Money { OrderDate = new DateTime(2000, 1, 1), ExtendedPrice = 1m };
        }
    }
}
