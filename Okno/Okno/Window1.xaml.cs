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

namespace Okno
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void BtOK_Click(object sender, RoutedEventArgs e)
        {
            Imie = tbImie.Text;
            Nazwisko = tbNazwisko.Text;
            DialogResult = true;
            this.Close();
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
        public string Imie = string.Empty;
        public string Nazwisko = string.Empty;

    }
}
