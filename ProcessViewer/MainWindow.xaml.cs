using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProcessViewer
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
        private void getProcess()
        {
            Process[] p = Process.GetProcesses();
            List<string> list = new List<string>();
            processView.ItemsSource = list;
            foreach (var item in p)
            {
                Console.WriteLine(item.ProcessName);
                list.Add(item.ProcessName);
            }
        }
        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            getProcess();
        }
    }
}
