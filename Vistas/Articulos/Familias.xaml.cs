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
    /// Lógica de interacción para Familias.xaml
    /// </summary>
    public partial class Familias : Window
    {
        public Familias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metodo para guardar familia en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Familia familia = new Familia(1 , descripcion.Text);
            descripcion.Text = "";
            dataGridFamilias.Items.Add(familia);
            MessageBox.Show(familia.ToString());
        }
    }
}
