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

namespace Chapter2Lesson2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var abinding = new CommandBinding();
            abinding.Command = CustomCommands.Launch;
            abinding.Executed += Launch_Handler;
            abinding.CanExecute += LaunchEnabled_Handler;
            this.CommandBindings.Add(abinding);
        }

        private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Launch invoked");
        }

        private void LaunchEnabled_Handler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (bool) checkBox1.IsChecked;
        }
    }
}
