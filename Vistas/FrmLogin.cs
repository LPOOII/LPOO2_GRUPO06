using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        
      
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            Usuario oUser = UsuarioModel.traer_usuario(txtNombre.Text);

            if (oUser != null)
            {
                if (oUser.Usr_UserName == txtNombre.Text && oUser.Usr_Password == txtPassword.Text)
                {
                   

                    //**********   Historial_Login fecha_ingreso = new Historial_Login(oUser.Usr_Id, DateTime.Now);
                   
                    
                    //DateTime fechaHoy = DateTime.Now;

                    //********************         UsuarioModel.insert_auditoria(fecha_ingreso);
                    
                    
                    Program.userValido = oUser;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("user o contrasenia invalidos !!!!");
                    this.DialogResult = DialogResult.No;
                }
            }
            else
            {
               
                MessageBox.Show("El Usuaro no existe !!!");
                this.DialogResult = DialogResult.No;
                
                
            }
        }
        
        public FrmLogin()
        {
            InitializeComponent();
        } 
        
        //metodos de los eventos Mouse: hover y leave para el boton Ingresar
        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.Red;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.Black;
        }


    }
}
