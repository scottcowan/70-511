﻿using System;
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
            this.Title = Properties.Settings.Default.ApplicationName;
            this.Background = new SolidColorBrush(Properties.Settings.Default.BackgroundColor);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!(listBox1.SelectedItem == null))
            {
                var astring = ((ListBoxItem) listBox1.SelectedItem).Content.ToString();
                switch (astring)
                {
                    case "Red":
                        Properties.Settings.Default.BackgroundColor = Colors.Red;
                        break;
                    case "Blue":
                        Properties.Settings.Default.BackgroundColor = Colors.Blue;
                        break;
                    case "Green":
                        Properties.Settings.Default.BackgroundColor = Colors.Green;
                        break;
                    case "Tomato":
                        Properties.Settings.Default.BackgroundColor = Colors.Tomato;
                        break;
                }
                this.Background = new SolidColorBrush(Properties.Settings.Default.BackgroundColor);
                Properties.Settings.Default.Save();
            }
        }
    }
}
