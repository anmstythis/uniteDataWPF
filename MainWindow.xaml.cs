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
using lab3_dataset.neoCorpDataSetTableAdapters;

namespace lab3_dataset
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        staffTableAdapter staff = new staffTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            neoDgr.ItemsSource = staff.GetFullData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            neoDgr.Columns[5].Visibility = Visibility.Collapsed;
            neoDgr.Columns[7].Visibility = Visibility.Collapsed;
        }
    }
}
