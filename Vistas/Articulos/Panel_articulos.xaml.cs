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
using System.Data;
using System.Collections.ObjectModel;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Panel_articulos.xaml
    /// </summary>
    public partial class Panel_articulos : Window
    {
        ObservableCollection<Articulo> listaArticulo;

        public Panel_articulos()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LIST_ARTICLE"];
            listaArticulo = odp.Data as ObservableCollection<Articulo>;
            txtDeleteArt.Text = "";

        }
             

        /// <summary>
        /// metodo para guardar en el datagridview el articulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarBtn_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("¿Agregar Articulo?", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Articulo articulo = new Articulo();
                articulo.Art_Id = listaArticulo[listaArticulo.Count - 1].Art_Id + 1;
                articulo.Art_Descrip = descripcion.Text;
                Familia of = new Familia();
                of.Fam_Descrip = cmbFamilia.SelectedValue.ToString();
                articulo.Fam_Id = of;
                Unidad_Medida um = new Unidad_Medida();
                um.Um_Descrip = cmbUnidadMedida.SelectedValue.ToString();
                articulo.Um_Id = um;
                Categoria cat = new Categoria();
                cat.Cat_Descrip = cmbCategoria.SelectedValue.ToString();
                articulo.Cat_Id = cat;
                articulo.Art_Costo = Convert.ToDecimal(costo.Text);
                articulo.Art_Stock_Min = Convert.ToDecimal(minimo.Text);
                articulo.Art_Stock_Max = Convert.ToDecimal(maximo.Text);
                articulo.Art_Precio = Convert.ToDecimal(precio.Text);
                articulo.Art_Stock_Reposicion = Convert.ToDecimal(reposicion.Text);
                articulo.Art_Stock_Actual = Convert.ToDecimal(actual.Text);
                articulo.Art_Margen_Beneficio = articulo.Art_Precio - articulo.Art_Stock_Actual;
                if (radioSi.IsChecked == true)
                {
                    articulo.Art_Maneja_Stock = true;
                }
                else
                {
                    if (radioSi.IsChecked == false)
                    {
                        articulo.Art_Maneja_Stock = false;
                    }
                }

                listaArticulo.Add(articulo);
            }
            
           
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Eliminar Articulo?", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Articulo oArticle = null;
                for (int i = 0; i < listaArticulo.Count; i++)
                {
                    if (listaArticulo[i].Art_Id == Convert.ToInt32(txtDeleteArt.Text))
                    {
                        oArticle = listaArticulo[i];
                    }
                }

                if (oArticle != null)
                {
                    listaArticulo.Remove(oArticle);
                }
                else
                {
                    MessageBox.Show("El Elemento No Se Encuentra En La Lista ...");
                }
            
            }
            
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("¿Modificar Articulo?", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Articulo articulo = new Articulo();
                articulo.Art_Id = listaArticulo[encontrador].Art_Id;

                articulo.Art_Descrip = descripcion.Text;
                Familia of = new Familia();
                of.Fam_Descrip = cmbFamilia.SelectedValue.ToString();
                articulo.Fam_Id = of;
                Unidad_Medida um = new Unidad_Medida();
                um.Um_Descrip = cmbUnidadMedida.SelectedValue.ToString();
                articulo.Um_Id = um;
                Categoria cat = new Categoria();
                cat.Cat_Descrip = cmbCategoria.SelectedValue.ToString();
                articulo.Cat_Id = cat;
                articulo.Art_Costo = Convert.ToDecimal(costo.Text);
                articulo.Art_Stock_Min = Convert.ToDecimal(minimo.Text);
                articulo.Art_Stock_Max = Convert.ToDecimal(maximo.Text);
                articulo.Art_Precio = Convert.ToDecimal(precio.Text);
                articulo.Art_Stock_Reposicion = Convert.ToDecimal(reposicion.Text);
                articulo.Art_Stock_Actual = Convert.ToDecimal(actual.Text);
                articulo.Art_Margen_Beneficio = articulo.Art_Precio - articulo.Art_Stock_Actual;
                if (radioSi.IsChecked == true)
                {
                    articulo.Art_Maneja_Stock = true;
                }
                else
                {
                    if (radioSi.IsChecked == false)
                    {
                        articulo.Art_Maneja_Stock = false;
                    }
                }

                listaArticulo[encontrador] = articulo;
            }                    
            
                       
        }
        int encontrador = 0;
        private void txtDeleteArt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDeleteArt.Text != "")
            {
                Articulo oArticle = null;
                for (int i = 0; i < listaArticulo.Count; i++)
                {
                    if (txtDeleteArt.Text != null)
                    {
                        if (listaArticulo[i].Art_Id == Convert.ToInt32(txtDeleteArt.Text))
                        {
                            oArticle = listaArticulo[i];
                            encontrador = i;
                        }

                    }
                }

                if (oArticle != null)
                {
                    descripcion.Text = oArticle.Art_Descrip;
                    cmbFamilia.Text = oArticle.Fam_Id.Fam_Descrip;
                    cmbCategoria.Text = oArticle.Cat_Id.Cat_Descrip;
                    cmbUnidadMedida.Text = oArticle.Um_Id.Um_Descrip;
                    costo.Text = oArticle.Art_Costo.ToString();
                    minimo.Text = oArticle.Art_Stock_Min.ToString();
                    maximo.Text = oArticle.Art_Stock_Max.ToString();
                    precio.Text = oArticle.Art_Precio.ToString();
                    reposicion.Text = oArticle.Art_Stock_Reposicion.ToString();
                    actual.Text = oArticle.Art_Stock_Actual.ToString();

                    oArticle = null;
                   
                }


            }



        }

       

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            limpieza();
        }

        public void limpieza()
        {

            descripcion.Text = "";
            cmbFamilia.Text = "";
            cmbCategoria.Text = "";
            cmbUnidadMedida.Text = "";
            costo.Text = "";
            minimo.Text = "";
            maximo.Text = "";
            precio.Text = "";
            reposicion.Text = "";
            actual.Text = "";
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
