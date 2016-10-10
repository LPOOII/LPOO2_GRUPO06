﻿using System;
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
using System.Collections.ObjectModel;

namespace Vistas.Articulos
{
    /// <summary>
    /// Lógica de interacción para abm_articulos.xaml
    /// </summary>
    public partial class abm_articulos : Window
    {
        CollectionView view;
        ObservableCollection<Articulo> listaArt;
        public abm_articulos()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LISTA_ARTICULOS"];
            listaArt = odp.Data as ObservableCollection<Articulo>;

            view = (CollectionView)CollectionViewSource.GetDefaultView(canvas_container.DataContext);
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToFirst();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToLast();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToPrevious();
            if (view.IsCurrentBeforeFirst)
            {
                view.MoveCurrentToLast();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            
            view.MoveCurrentToNext();
            if(view.IsCurrentAfterLast)
            {
                view.MoveCurrentToFirst();
            }
        }

        private void btnPanelOperaciones_Click(object sender, RoutedEventArgs e)
        {
            Panel_articulos oPanelArt = new Panel_articulos();
            oPanelArt.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        
    }
}
