using System;
using System.Collections.Generic;
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
//--<using>--
using Microsoft.Win32;

namespace ClassWOrk3
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

        private void open_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Log files|*.log|Text files|*.txt|All files|*.*";
            fileDialog.DefaultExt = ".txt";
            Nullable<bool> dialogOK = fileDialog.ShowDialog();
            if (dialogOK == true)
            {
                string sfilenames = "";
                foreach(string sfilename in fileDialog.FileNames)
                {
                    sfilenames += ";" + sfilename;
                }
                sfilenames = sfilenames.Substring(1);
                WrapPanelTextBox.Text = sfilenames;
            }
            
        }
        //public int Count { get; set; } = 0;
        //private void repeat_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    ++Count;
        //    repeat_btn.Content = Count.ToString();
        //}

        //private void button_1_Click(object sender, RoutedEventArgs e)
        //{
        //    ++Count;
        //    button_1.Content = Count.ToString();
        //}
    }
}
