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
    public partial class FormAltaCliente : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        Usuario userForm;

        public FormAltaCliente()
        {
            InitializeComponent();
        }


        public FormAltaCliente(Usuario usuario) : this()
        {
            this.userForm = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cancelar el alta del Cliente?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (!(Validaciones.EspacioEnBlancoOVacio(txtNombre.Text)))
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
            if (!(Validaciones.EspacioEnBlancoOVacio(txtApellido.Text)))
            {
                lblValidApellido.ForeColor = Color.Green;
            }
            else
            {
                lblValidApellido.ForeColor = Color.Red;
            }
        }

        private bool FlagDetector()
        {
            if (lblValidCuit.ForeColor != Color.Red &&
                lblValidApellido.ForeColor != Color.Red &&
                 lblValidNombre.ForeColor != Color.Red)
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
                Cliente cliente;
                lblMensaje.Text = "";
                StringBuilder sb = new StringBuilder();
                cliente = new Cliente(txtCuit.Text, txtNombre.Text, txtApellido.Text, 0);
                PetShop.AddCliente(cliente);

                this.Hide();
                this.Close();
            }
        }



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }





    }
}
