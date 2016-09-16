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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas.Ventas
{
    /// <summary>
    /// Lógica de interacción para MesaControl.xaml
    /// </summary>
    public partial class MesaControl : UserControl
    {
        public MesaControl()
        {
            InitializeComponent();
            btn11.Background = Brushes.Red;
            btn17.Background = Brushes.Red;
        }

        void mouseClickEvent(object sender, RoutedEventArgs args)
        {

            Button btn = (Button)args.OriginalSource;
            if (btn.Background == Brushes.Red) { MessageBox.Show("Mesa Ocupada"); }
            else
            {
                MessageBox.Show("Mesa Libre");
            }
        }
    }
}
