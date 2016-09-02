using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class CargaSistema : Form
    {
        public CargaSistema()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Width < 320)
            {
                panel2.Width = panel2.Width + 4;
            }
            else
            {
                timer1.Enabled = false;
                this.Close();

            }
        }

        private void CargaSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
