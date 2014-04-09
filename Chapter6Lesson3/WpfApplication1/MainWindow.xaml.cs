using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Names myNames;
        private ICollectionView aView;

        public MainWindow()
        {
            InitializeComponent();
            myNames = (Names) (this.Resources["myNames"]);
            aView = CollectionViewSource.GetDefaultView(myNames);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!(aView.CurrentPosition == 0))
                aView.MoveCurrentToPrevious();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (!(aView.CurrentPosition == myNames.Count - 1))
                aView.MoveCurrentToNext();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Name aName = new Name("", "");
            myNames.Add(aName);
            aView.MoveCurrentToNext();
        }

        private void Validation_OnError(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                MessageBox.Show(e.Error.ErrorContent.ToString());
        }
    }
}
