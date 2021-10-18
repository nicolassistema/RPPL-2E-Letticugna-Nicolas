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
        private const int CP_NOCLOSE_BUTTON = 0x200;
        Usuario userForm;


        /// <summary>
        /// Constructor sin parámetros de la clase frmLogin.
        /// </summary>
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


        /// <summary>
        /// Genera parametros para setearle al formulario que inhabilñite el boton [X] cerrar 
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }


        private void lbkUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUser.Text = "pepe";
            txtPass.Text = "123";
        }


        private void lbkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUser.Text = "admin";
            txtPass.Text = "admin";
        }
    }
}
