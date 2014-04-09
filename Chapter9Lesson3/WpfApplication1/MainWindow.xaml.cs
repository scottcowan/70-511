using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
        List<string> PhoneNumbers = new List<string>();
        System.Windows.Forms.SaveFileDialog aDialog;
 
        public MainWindow()
        {
            InitializeComponent();
       }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MaskedTextBox aBox;
            aBox = (System.Windows.Forms.MaskedTextBox) windowsFormsHost1.Child;
            PhoneNumbers.Add(aBox.Text);
            aBox.Clear();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            aDialog = new SaveFileDialog();
            aDialog.Filter = "Text Files | *.txt";
            aDialog.ShowDialog();
            System.IO.StreamWriter myWriter = new StreamWriter(aDialog.FileName, true);
            foreach (var s in PhoneNumbers)
            {
                myWriter.WriteLine(s);
            }
            myWriter.Close();
        }
    }
}
