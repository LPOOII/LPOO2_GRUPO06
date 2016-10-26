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

using System.Media;
using System.Windows.Threading;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Presentacion.xaml
    /// </summary>
    public partial class Presentacion : Window
    {
        SoundPlayer sonido = new SoundPlayer();
        DispatcherTimer time = new DispatcherTimer();
        public Presentacion()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            sonido.SoundLocation = "Media/sonido.wav";
            sonido.Play();
            // aqui creamos un reloj el cual demora 5 segundos 

            time.Tick += new EventHandler(time_Tick);
            time.Interval = new TimeSpan(0, 0, 4);
            time.Start();

        }

        void time_Tick(object sender, EventArgs e)
        {
            sonido.Stop();
            time.Stop();
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }

    }
}
