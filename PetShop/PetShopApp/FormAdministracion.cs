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
using System.Globalization;

namespace PetShopApp
{
    public partial class frmAdministracion : Form
    {
        private Timer ti;

        Usuario userForm;
        private const int CP_NOCLOSE_BUTTON = 0x200;


        /// <summary>
        /// Constructor sin parámetros de la clase frmAdministracion.
        /// </summary>
        public frmAdministracion()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
            lblTimer.Visible = true;
        }


        /// <summary>
        /// Constructor con parámetros de la clase frmAdministracion.
        /// </summary>
        /// <param name="usuario"></param>
        public frmAdministracion(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblBienvenido.Text = "Bienvenido: " + usuario.Nombre + " " + usuario.Apellido;
            if (!(Usuario.IsAdmin(userForm)))
            {
                btnClientes.Visible = false;
                btnEmpleados.Visible = false;
                btnFacturacion.Visible = false;
            }
        }


        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lblTimer.Text = hoy.ToString("F", CultureInfo.CreateSpecificCulture("es-ES"));
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            FormVenta venta = new FormVenta(this.userForm);
            this.Hide();
            venta.ShowDialog();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente venta = new frmCliente(this.userForm);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleado venta = new FormEmpleado(this.userForm);
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }


        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion venta = new frmFacturacion(this.userForm, PetShop.ObtenerListaVentas());
            this.Hide();
            venta.ShowDialog();
            this.Close();
        }


        private void lblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Dese cerrar session?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            formInventario inventario = new formInventario(this.userForm);
            this.Hide();
            inventario.ShowDialog();
            this.Close();
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


        private void lbkBlackTheme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManejadorDeForms.DarkMode = !ManejadorDeForms.DarkMode;
            if (ManejadorDeForms.DarkMode)
            {
                this.BackColor = Color.Black;
                lblTimer.ForeColor = Color.White;
                btnClientes.BackColor = Color.Black;
                btnVender.BackColor = Color.Black;
                btnInventario.BackColor = Color.Black;
                btnEmpleados.BackColor = Color.Black;
                btnFacturacion.BackColor = Color.Black;
                pnlLogo.BackColor = Color.Black;
                pnlMenu.BackColor = Color.Black;
                this.pnlLogoDos.BackColor = Color.Black; ;
                lbkBlackTheme.Text = "Visiion Black";
            }
            else
            {
                ApagarDarkMode();
            }
        }


        /// <summary>
        /// Setea color de dark mode en los objetos del formulario
        /// </summary>
        private void ApagarDarkMode()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            lblTimer.ForeColor = Color.Black;
            btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            pnlLogo.BackColor = this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            pnlMenu.BackColor = this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));

            this.pnlLogoDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            lbkBlackTheme.Text = "Visiion White";
        }


        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            if (ManejadorDeForms.DarkMode)
            {
                ApagarDarkMode();
            }
        }
    }
}