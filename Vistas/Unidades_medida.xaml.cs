using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Unidades_medida.xaml
    /// </summary>
    public partial class Unidades_medida : Window
    {
        public Unidades_medida()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metodo para guardar unidada de metida en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Unidad_Medida um = new Unidad_Medida(1, descripcion.Text, abreviatura.Text);
            descripcion.Text = "";
            abreviatura.Text = "";
            dataGridUnidadM.Items.Add(um);
        }
    }
}
