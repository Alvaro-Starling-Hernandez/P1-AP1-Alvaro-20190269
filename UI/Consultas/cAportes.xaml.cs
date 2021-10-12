using P1_AP1_Alvaro_20190269.BLL;
using P1_AP1_Alvaro_20190269.Entidades;
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

namespace P1_AP1_Alvaro_20190269.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cAportes.xaml
    /// </summary>
    public partial class cAportes : Window
    {
        public cAportes()
        {
            InitializeComponent();
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        listado = AportesBLL.GetList(e => e.Persona.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        break;
                    case 1:
                        listado = AportesBLL.GetList(e => e.Concepto.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(c => true);
            }

            if (Desde_DataPicker.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date >= Desde_DataPicker.SelectedDate);
            if(Hasta_DatePicker.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date >= Hasta_DatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            int conteo = listado.Count;
            ConteoTextBox.Text = ""+ conteo;

            var Total = listado.Sum(x => x.Monto);
            TotalTextBox.Text =Total.ToString("N2");
        }
    }
}
