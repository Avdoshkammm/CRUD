using CRUD.Models;
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

namespace CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CrudtestContext db = new CrudtestContext();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addwin = new AddProductWindow();
            addwin.ShowDialog();
        }

        private void DeleteOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (CrudtestContext db = new CrudtestContext())
            {
                ShowGrid.ItemsSource = db.Products.ToList();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
