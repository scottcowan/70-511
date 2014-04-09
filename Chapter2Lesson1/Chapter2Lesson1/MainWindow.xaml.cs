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

namespace Chapter2Lesson1
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

        private void TextBox1_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Textbox");
            e.Handled = (bool) radioButton1.IsChecked;
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by StackPanel");
            e.Handled = (bool)radioButton2.IsChecked;
        }

        private void MainWindow_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Window");
            e.Handled = (bool)radioButton3.IsChecked;            
        }
    }
}
