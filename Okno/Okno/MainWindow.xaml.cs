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

namespace Okno
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // public string c = string.Empty
        List<string> lista = new List<string>();

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno = new Window1();
            bool? ret = okno.ShowDialog();
            if (ret.HasValue && ret.Value)
            {
                lista.Add(okno.Imie);
                lista.Add(okno.Nazwisko);
                // string c = okno.Imie + " " + okno.Nazwisko;
            }          
    }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            Window2 okno2 = new Window2();
            bool? ret = okno2.ShowDialog();
            if (ret.HasValue && ret.Value)
            {
                // string d = okno2.Miasto +" "+ okno2.Ulica;
                Tb1.Text = lista[0] +" "+ lista[1] +" "+ okno2.Miasto+" "+ okno2.Ulica ;
            }
        }
    }
}