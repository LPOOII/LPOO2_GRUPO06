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

namespace Vistas.Articulos
{
    /// <summary>
    /// Lógica de interacción para ArticulosVistaPrevia.xaml
    /// </summary>
    public partial class ArticulosVistaPrevia : Window
    {
        public ArticulosVistaPrevia()
        {
            InitializeComponent();
        }

        private void btnClick_Imprimir(object sender, RoutedEventArgs e)
        {
            PrintDialog pdlog = new PrintDialog();
            if (pdlog.ShowDialog() == true)
            {
                pdlog.PrintDocument(((IDocumentPaginatorSource)DocMain).DocumentPaginator, "Imprimir");
            }
        }
    }
}
