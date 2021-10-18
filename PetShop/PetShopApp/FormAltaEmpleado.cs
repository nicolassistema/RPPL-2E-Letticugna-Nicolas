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
        private const int CP_NOCLOSE_BUTTON = 0x200;
        Usuario userForm;


        /// <summary>
        /// Constructor sin parámetros de la clase frmAltaEmpleado.
        /// </summary>
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Constructor con parámetros de la clase frmAltaEmpleado.
        /// </summary>
        /// <param name="usuario"></param>
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
                if (!(PetShop.ValidaUsuarioExistenteByCuit(txtCuit.Text)))
                {
                    if (Validaciones.ValidateNumberCuit(txtCuit.Text))
                    {
                        lblValidCuit.ForeColor = Color.Green;
                    }
                }
                else
                {
                    MessageBox.Show("El cuil del Usuario a cargar ya existe en el sistema. Por favor cargar uno nuevo o salir");
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

        /// <summary>
        /// Detecta si algun control de la lista tiene color rojo y devuelve true/False
        /// </summary>
        /// <returns>Devuelve True si algun control esta seteado con color rojo, caso contrarop false</returns>
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
                MessageBox.Show("Por favor completar los campos requeridos");
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


        private void lbkEmpleadoExistente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = PetShop.ObtenerUsuarioByCuit("20323205125");
            if (!(usuario is null))
            {
                txtCuit.Text = usuario.Cuit;
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtUsuario.Text = usuario.NameUsuario;
                txtPassword.Text = usuario.PassUsuario;
                cmbPerfil.Text = usuario.PerfilUsuario.ToString();
            }
            ValidacionMasivaAutomatica();
        }


        private void lbkEmpleadoInexistente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCuit.Text = "20323206032";
            txtNombre.Text = "Juan";
            txtApellido.Text = "Montoto";
            txtUsuario.Text = "pepe";
            txtPassword.Text = "1234";
            cmbPerfil.Text = "Admin";
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

            if (Validaciones.ValidacionString(txtUsuario.Text))
            {
                lblValidUser.ForeColor = Color.Green;
            }
            else
            {
                lblValidUser.ForeColor = Color.Red;
            }

            if (Validaciones.ValidacionString(txtPassword.Text))
            {
                lblValidPass.ForeColor = Color.Green;
            }
            else
            {
                lblValidPass.ForeColor = Color.Red;
            }

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
    }
}
