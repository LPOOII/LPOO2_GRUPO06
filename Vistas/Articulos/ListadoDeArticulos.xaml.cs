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

using System.Collections.ObjectModel;
using ClasesBase;
namespace Vistas.Articulos
{
    /// <summary>
    /// Lógica de interacción para ListadoDeArticulos.xaml
    /// </summary>
    public partial class ListadoDeArticulos : Window
    {
        private CollectionViewSource vistaColeccionFiltrada; // vista de colección filtrada
        public ListadoDeArticulos()
        {
            InitializeComponent();
            
            // Se accede al Recurso CollectionViewSource
            vistaColeccionFiltrada = Resources["VISTA_ARTICLE"] as CollectionViewSource; // x:Key del CollectionViewSource (XAML)
        }

        //se invocara mas adelante eventVistaArticulo_Filter
        private void eventVistaArticulo_Filter(object sender, FilterEventArgs e)
        {
           Articulo oArticle = e.Item as Articulo;            
            if (vistaColeccionFiltrada != null)
            {
                if (oArticle.Cat_Id.Cat_Id.Equals(cmbCategoria.SelectedValue))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
            
        }


        private void cmbCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (vistaColeccionFiltrada != null)
            {
                
                    vistaColeccionFiltrada.Filter += eventVistaArticulo_Filter;
                
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }        

    }
}
