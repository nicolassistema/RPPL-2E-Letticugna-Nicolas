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
        string cuitInt;


        /// <summary>
        /// Constructor sin parámetros de la clase FormAltaCliente.
        /// </summary>
        public FormAltaCliente()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Constructor con parámetros de la clase FormAltaCliente.
        /// </summary>
        /// <param name="usuario"></param>
        public FormAltaCliente(Usuario usuario) : this()
        {
            this.userForm = usuario;
            pnlAutoCargaDatos.Visible = true;
        }


        /// <summary>
        /// Constructor con parámetros de la clase FormAltaCliente.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="cuitInt"></param>
        public FormAltaCliente(Usuario usuario, string cuitInt) : this()
        {
            this.userForm = usuario;
            this.Cuit = cuitInt;
            txtCuit.Text = cuitInt;
            pnlAutoCargaDatos.Visible = false;
        }


        /// <summary>
        /// Propiedad Cuit
        /// </summary>
        public string Cuit
        {
            get { return cuitInt; }
            set { cuitInt = value; }
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
                if (!(PetShop.ValidaClienteExistenteByCuit(txtCuit.Text)))
                {
                    if (Validaciones.ValidateNumberCuit(txtCuit.Text))
                    {
                        lblValidCuit.ForeColor = Color.Green;
                    }
                }
                else
                {
                    MessageBox.Show("El cuil del Cliente a cargar ya existe en el sistema. Por favor cargar uno nuevo o salir");
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


        /// <summary>
        /// Detecta si algun control de la lista tiene color rojo y devuelve true/False
        /// </summary>
        /// <returns>Devuelve True si algun control esta seteado con color rojo, caso contrarop false</returns>
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


        private void lbkClienteNuevo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCuit.Text = "20323206709";
            txtNombre.Text = "Juan";
            txtApellido.Text = "Gomez";
            ValidacionMasivaAutomatica();
        }


        private void lbkClienteExistente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente = PetShop.ObtenerClienteByCuit("20323206008");
            if (!(cliente is null))
            {
                txtCuit.Text = cliente.Cuit;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
            }
            ValidacionMasivaAutomatica();
        }


        /// <summary>
        /// Valida cada campo y le setea el color de labal segun resultado de la validacion
        /// </summary>
        private void ValidacionMasivaAutomatica()
        {
            if (Validaciones.ValidacionString(txtNombre.Text))
            {
                lblValidNombre.ForeColor = Color.Green;
            }
            else
            {
                lblValidNombre.ForeColor = Color.Red;
            }

            if (Validaciones.ValidacionString(txtApellido.Text))
            {
                lblValidApellido.ForeColor = Color.Green;
            }
            else
            {
                lblValidApellido.ForeColor = Color.Red;
            }
        }

    }
}
