using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
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
    public partial class AutomationWindow : Window
    {
        private MainWindow aWindow;

        public AutomationWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            aWindow = mainWindow;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RadioButtonAutomationPeer RBAutomationPeer = new RadioButtonAutomationPeer(aWindow.radioButton2);
            ISelectionItemProvider SelectProvider;
            SelectProvider = (ISelectionItemProvider)RBAutomationPeer.GetPattern(PatternInterface.SelectionItem);
            SelectProvider.Select();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxAutomationPeer CBAutomationPeer1 = new CheckBoxAutomationPeer(aWindow.checkBox1);
            CheckBoxAutomationPeer CBAutomationPeer2 = new CheckBoxAutomationPeer(aWindow.checkBox2);
            IToggleProvider ToggProvider1;
            IToggleProvider ToggProvider2;
            ToggProvider1 = (IToggleProvider)CBAutomationPeer1.GetPattern(PatternInterface.Toggle);
            ToggProvider2 = (IToggleProvider)CBAutomationPeer2.GetPattern(PatternInterface.Toggle);

            ToggProvider1.Toggle();
            ToggProvider2.Toggle();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ListBoxAutomationPeer LBAutomationPeer = new ListBoxAutomationPeer(aWindow.listBox1);
            IScrollProvider ScrProvider;
            ScrProvider = (IScrollProvider)LBAutomationPeer.GetPattern(PatternInterface.Scroll);
            ScrProvider.Scroll(ScrollAmount.NoAmount, ScrollAmount.LargeIncrement);
            ScrProvider.Scroll(ScrollAmount.NoAmount, ScrollAmount.LargeIncrement);
            ListBoxItemAutomationPeer LBIAutomationPeer = new ListBoxItemAutomationPeer(aWindow.listBox1.Items[3], LBAutomationPeer);
            ISelectionItemProvider SelItemProvider;
            SelItemProvider = (ISelectionItemProvider)LBIAutomationPeer.GetPattern(PatternInterface.SelectionItem);
            SelItemProvider.Select();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ButtonAutomationPeer BAutomationPeer = new ButtonAutomationPeer(aWindow.button1);
            IInvokeProvider InvProvider;
            InvProvider = (IInvokeProvider) BAutomationPeer.GetPattern(PatternInterface.Invoke);
            InvProvider.Invoke();
        }
    }
}
