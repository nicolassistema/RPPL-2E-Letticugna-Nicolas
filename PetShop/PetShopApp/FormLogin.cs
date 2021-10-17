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
    public partial class frmLogin : Form
    {

        Usuario userForm;

        public frmLogin()
        {
            InitializeComponent();
            this.userForm = new Usuario();
        }

    
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.SalidaMensajeValidacion(txtUser.Text, txtPass.Text);
                this.userForm = PetShop.ObtenerUsuario(txtUser.Text, txtPass.Text);
                if (!(this.userForm is null))
                {
                    frmAdministracion administracion = new frmAdministracion(this.userForm);
                    this.Hide();
                    administracion.ShowDialog();
                    this.Close();
                }
            }
            catch (UsuarioInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (boton == DialogResult.Yes)
            {
                Dispose();
            }
        }

    }
}
