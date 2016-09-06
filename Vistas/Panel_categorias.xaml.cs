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
    /// Lógica de interacción para Panel_categoria.xaml
    /// </summary>
    public partial class Panel_categorias : Window
    {
        public Panel_categorias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metodo para guardar categorias en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Categoria categoria = new Categoria(1, descripcion.Text);
            descripcion.Text = "";
            dataGridCategoria.Items.Add(categoria);
        }
    }
}
