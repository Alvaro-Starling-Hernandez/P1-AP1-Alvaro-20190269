using P1_AP1_Alvaro_20190269.UI.Consultas;
using P1_AP1_Alvaro_20190269.UI.Registros;
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

namespace P1_AP1_Alvaro_20190269
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

        private void Aportes_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rAportes r = new rAportes();
            r.Show();
        }

        private void ConsultaAportes_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            cAportes c = new cAportes();
            c.Show();
        }
    }
}
