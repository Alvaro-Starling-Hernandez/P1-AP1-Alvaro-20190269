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

namespace P1_AP1_Alvaro_20190269.UI.Registros
{
    /// <summary>
    /// Interaction logic for rAportes.xaml
    /// </summary>
    public partial class rAportes : Window
    {
        Aportes aporte = new Aportes();

        public rAportes()
        {
            InitializeComponent();
            this.DataContext = aporte;
        }

        private void Limpiar()
        {
            this.aporte = new Aportes();
            this.DataContext = aporte;
        }

        private bool Validar()
        {
            bool esValido = true;

            if(AporteID_TextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("El Campo Aporte Id no puede estar vacio", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (Persona_TextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("El Campo Persona no puede estar vacio", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (Concepto_TextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("El Campo Concepto no Puede estar vacio", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (Monto_TextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("El Campo Monto no Puede estar vacio", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;

        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            var aporte = AportesBLL.Buscar(Utilidades.ToInt(AporteID_TextBox.Text));
            if (aporte == null)
                MessageBox.Show("No existe Aporte con ese id", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            if (aporte != null)
                this.aporte = aporte;
            else
                aporte = new Aportes();
            this.DataContext = this.aporte;

        }

        private void Nuevo_Button_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Guardar_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = AportesBLL.Guardar(aporte);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void Eliminar_Button_Click(object sender, RoutedEventArgs e)
        {
            if (AportesBLL.Eliminar(Utilidades.ToInt(AporteID_TextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
