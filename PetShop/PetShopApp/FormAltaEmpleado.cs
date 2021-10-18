using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShopApp
{
    public partial class frmAltaEmpleado : Form
    {
        Usuario userForm;

        public frmAltaEmpleado()
        {
            InitializeComponent();
        }


        public frmAltaEmpleado(Usuario usuario) : this()
        {
            this.userForm = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cancelar el alta de empleado?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                this.Hide();
                this.Close();
            }
        }



        private void txtCuit_Leave(object sender, EventArgs e)
        {
            {
                if (Validaciones.ValidateNumberCuit(txtCuit.Text))
                {

                    lblValidCuit.ForeColor = Color.Green;
                }
                else
                {
                    lblValidCuit.ForeColor = Color.Red;
                }
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ValidacionString(txtNombre.Text))
            {
                lblValidNombre.ForeColor = Color.Green;
            }
            else
            {
                lblValidNombre.ForeColor = Color.Red;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ValidacionString(txtApellido.Text))
            {
                lblValidApellido.ForeColor = Color.Green;
            }
            else
            {
                lblValidApellido.ForeColor = Color.Red;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ValidacionString(txtUsuario.Text))
            {
                lblValidUser.ForeColor = Color.Green;
            }
            else
            {
                lblValidUser.ForeColor = Color.Red;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ValidacionString(txtPassword.Text))
            {
                lblValidPass.ForeColor = Color.Green;
            }
            else
            {
                lblValidPass.ForeColor = Color.Red;
            }
        }

        private void cmbPerfil_Leave(object sender, EventArgs e)
        {
            if (cmbPerfil.Items.Count < 1)
            {
                lblValidPerfil.ForeColor = Color.Red;
            }
            else if (cmbPerfil.SelectedIndex.Equals(-1))
            {
                lblValidPerfil.ForeColor = Color.Red;
            }
            else
            {
                lblValidPerfil.ForeColor = Color.Green;
            }
        }



        private bool FlagDetector()
        {
            if (lblValidCuit.ForeColor != Color.Red &&
                lblValidNombre.ForeColor != Color.Red &&
                 lblValidApellido.ForeColor != Color.Red &&
                 lblValidUser.ForeColor != Color.Red &&
                 lblValidPass.ForeColor != Color.Red &&
                 lblValidPerfil.ForeColor != Color.Red)
            {
                return true;
            }
            return false;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
        


            if (!(FlagDetector()))
            {
                MessageBox.Show("Por favor competar los campos requeridos");
            }
            else
            {

                Usuario usuario;
                lblMensaje.Text = "";
                StringBuilder sb = new StringBuilder();
                Dictionary<string, Usuario> lista = new Dictionary<string, Usuario>();
                usuario = new Usuario(txtCuit.Text, txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtPassword.Text, Entidades.Usuario.EPerfilUsuario.Admin);
                PetShop.AddUsuario(usuario);

                this.Hide();
                this.Close();
            }
        }

    }
}
