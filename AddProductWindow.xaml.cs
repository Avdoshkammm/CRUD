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
using System.Windows.Shapes;

namespace CRUD
{
    /// <summary>
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if(string.IsNullOrWhiteSpace(Name.Text))
                errors.AppendLine("Укажите название");
            if (string.IsNullOrWhiteSpace(Cost.Text))
                errors.AppendLine("Укажите цену");
            if (string.IsNullOrWhiteSpace(Items.Text))
                errors.AppendLine("Укажите количество");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            using (CrudtestContext db = new CrudtestContext())
            {
                try
                {
                    Product pr = new Product()
                    {
                        Product1 = Name.Text,
                        Cost = Cost.Text,
                        Items = Items.Text,
                    };
                    db.Products.Add(pr);
                    db.SaveChanges();
                    MessageBox.Show("Продукт добавлен!");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }
            }
            this.Close();
        }
    }
}