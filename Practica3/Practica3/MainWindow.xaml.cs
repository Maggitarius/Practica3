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
using Practica3.DataSetATableAdapters;

namespace Practica3
{
    public partial class MainWindow : Window
    {
        BooksTableAdapter books = new BooksTableAdapter();
        AuthorsTableAdapter authors = new AuthorsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Table.ItemsSource = authors.GetDataBy();
        }

        private void Ivent(object sender, EventArgs e)
        {
            Table.Columns[0].Visibility = Visibility.Collapsed;
            Table.Columns[6].Visibility = Visibility.Collapsed;
            Table.Columns[11].Visibility = Visibility.Collapsed;
        }
    }
}
