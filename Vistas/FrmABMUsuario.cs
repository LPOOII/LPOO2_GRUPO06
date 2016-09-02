using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
namespace Vistas
{
    public partial class FrmABMUsuario : Form
    {
        public FrmABMUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            
            
        }


        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnModificarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            traerListaCombo();
            cmbRolId.Text = "seleccionar";
            txtId.Text = "*";

        }
        //traer la lista del combo de roles: Model de la clase UsuarioModel
        private void traerListaCombo(){
            //DisplayMember:muestra la descripcion.
            cmbRolId.DisplayMember = "rol_descrip";
            //ValueMember: va a madar el id de refencia.
            cmbRolId.ValueMember = "rol_id";
            //DataSource: permite recibir el dataTable que va hacer uso de ese recurso.
            cmbRolId.DataSource = UsuarioModel.listarRol();
        
        }//fin-traerListaCombo

      
        
       


        //Mostrar Grilla
        /*Mostramos los datos de la grilla en los texbox.*/ 
        private void dataGridViewUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            

            if (dataGridViewUsuarios.CurrentRow != null)
            {
                switch (dataGridViewUsuarios.CurrentRow.Cells["Rol"].Value.ToString())
                {
                    case "Administrador": cmbRolId.SelectedValue = 1; break;
                    case "Repositor": cmbRolId.SelectedValue = 2; break;
                    case "Pastelero": cmbRolId.SelectedValue = 3; break;
                    case "Comprador": cmbRolId.SelectedValue = 4; break;
                    case "Vendedor": cmbRolId.SelectedValue = 5; break;
                    case "Cajero": cmbRolId.SelectedValue = 6; break;

                }
                txtApellido.Text = dataGridViewUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = dataGridViewUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEmail.Text = dataGridViewUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                txtUserName.Text = dataGridViewUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dataGridViewUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtId.Text = dataGridViewUsuarios.CurrentRow.Cells["Id Usuario"].Value.ToString();
                btnModificarUsuario.Enabled = true;
                btnEliminarUsuario.Enabled = true;
                btnGuardarUsuario.Enabled = false;

            }
            else
            {
                btnModificarUsuario.Enabled = false;
                btnEliminarUsuario.Enabled = false;
                BorrarCampos(gboxUsuario);
            }
             
        }



        private void cboRolUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        //metodo de MouseHover y MouseLeave:para cambiar de color a los botones
        private void btnGuardarUsuario_MouseHover(object sender, EventArgs e)
        {
            btnGuardarUsuario.ForeColor = Color.Red;
        }

        private void btnGuardarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnGuardarUsuario.ForeColor = Color.Black;
        }
        //metodo salir
        private void btnSalirUsuario_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.Red;
        }

        private void btnSalirUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.Black;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
        }

        //Metodo btnMostrarUsuario que permite traer a todos los usuarios
        private void btnMostrarUsuario_Click(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = UsuarioModel.listar_usuarios();

        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BorrarCampos(GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                  
                    ((TextBox)combo).Clear();
                }
                
            }
            btnGuardarUsuario.Enabled = true;
            txtId.Text = "*";
            cmbRolId.Text = "seleccionar";
        }

        public bool validarCampos(GroupBox gb)
        {
            
            foreach (Control c in gb.Controls)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                {
                    if (c.Text.Equals(""))
                    {
                        return false;
                       
                    }
                }
                else
                {
                    if (c.GetType().Equals(typeof(ComboBox)))
                    {

                        if (c.Text.Equals("seleccionar"))
                        {

                            return false;
                        }
                    }
                }
                    
            }    

            return true;
        }
        //modificar el usuario
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {   
            //mUser:modificar Usuario
            Usuario mUser = new Usuario();
            mUser.Usr_Id = Convert.ToInt32(txtId.Text);

            mUser.Usr_Nombre = txtNombre.Text;
            mUser.Usr_Apellido = txtApellido.Text;
            mUser.Usr_UserName = txtUserName.Text;
            mUser.Usr_Password = txtPassword.Text;
            mUser.Rol_Id = (int)cmbRolId.SelectedValue;
            mUser.Usr_Email = txtEmail.Text;

            UsuarioModel.update_usuario(mUser);
            MessageBox.Show("Se modifico exitosamente!");
            dataGridViewUsuarios.DataSource = UsuarioModel.listar_usuarios();
        }
        //eliminar el usuario
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Eliminar?", "Borrar Usuario",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                //eUser:eliminar Usuario
                Usuario eUser = new Usuario();

                eUser.Usr_Id = Convert.ToInt32(txtId.Text);


                eUser.Usr_Nombre = txtNombre.Text;
                eUser.Usr_Apellido = txtApellido.Text;
                eUser.Usr_UserName = txtUserName.Text;
                eUser.Usr_Password = txtPassword.Text;
                eUser.Rol_Id = (int)cmbRolId.SelectedValue;
                eUser.Usr_Email = txtEmail.Text;
                
                if (eUser.Rol_Id == 1)
                {
                    MessageBox.Show("No Puede Eliminar un Administrador!");
                }
                else
                {
                    UsuarioModel.deleteUsuario(eUser);
                    dataGridViewUsuarios.DataSource = UsuarioModel.listar_usuarios();
                }
               
            }
        }

        private void btnGuardarUsuario_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("valor del validar" + validarCampos(gboxUsuario));
            if (validarCampos(gboxUsuario))
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Usr_Nombre = txtNombre.Text;
                oUsuario.Usr_Apellido = txtApellido.Text;
                oUsuario.Usr_UserName = txtUserName.Text;
                oUsuario.Usr_Password = txtPassword.Text;
                oUsuario.Rol_Id = (int)cmbRolId.SelectedValue;
                oUsuario.Usr_Email = txtEmail.Text;
                //Se llama al metodo insertarUsuario y le pasamos el objeto con los datos de los text box.
                //Nota: Por que no se instancio la clase UsuarioModel?. 
                //Porque los metodos que estan dentro de la clase UsuarioModel son static

                UsuarioModel.insertarUsuario(oUsuario);
                MessageBox.Show("Se guardo exitosamente!");
                BorrarCampos(gboxUsuario);
                dataGridViewUsuarios.DataSource = UsuarioModel.listar_usuarios();
                
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos !!!");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            BorrarCampos(gboxUsuario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            if (!txtBuscarNombre.Text.Equals("") || !txtBuscarApellido.Text.Equals(""))
            {
                dataGridViewUsuarios.DataSource = UsuarioModel.search_usuarios(txtBuscarNombre.Text, txtBuscarApellido.Text);
                txtBuscarNombre.Text = "";
                txtBuscarApellido.Text = "";
            }
            else
            {
               
                MessageBox.Show("Ingrese alguna letra: Apellido ó Nombre");
            }
        }




    }//fin-FrmABMUsuario
}
