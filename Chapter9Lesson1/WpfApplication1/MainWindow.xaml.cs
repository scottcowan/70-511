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
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BackgroundWorker worker = new BackgroundWorker();

        public MainWindow()
        {
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            InitializeComponent();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
            {
                label2.Content = "Run Completed";
            }
            else
            {
                label2.Content = "Run Cancelled";
            }
        }

        private delegate void UpdateDelegate(int i);
        private void UpdateLabel(int i)
        {
            label1.Content = "Cycles: " + i.ToString();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 500; i++)
            {
                for (int j = 0; j <= 10000000; j++)
                {

                }
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                UpdateDelegate update = new UpdateDelegate(UpdateLabel);
                label1.Dispatcher.BeginInvoke(
                    DispatcherPriority.Normal, update, i);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label2.Content = "";
            worker.RunWorkerAsync();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }
    }
}
