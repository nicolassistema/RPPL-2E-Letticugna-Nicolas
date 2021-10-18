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
    public partial class frmFacturacion : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private Timer ti;

        Usuario userForm;
        List<Venta> listaVentas;
        Facturacion facturacion;


        /// <summary>
        /// Constructor sin parámetros de la clase frmFacturacion.
        /// </summary>
        public frmFacturacion()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
            lblTimer.Visible = true;
        }


        /// <summary>
        /// Constructor con parámetros de la clase frmFacturacion.
        /// </summary>
        /// <param name="usuario"></param>
        public frmFacturacion(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
        }


        /// <summary>
        /// Constructor con parámetros de la clase frmFacturacion.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="ventas"></param>
        public frmFacturacion(Usuario usuario, List<Venta> ventas) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            this.listaVentas = ventas;
            CargarTexto();
        }


        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lblTimer.Text = hoy.ToString("F", CultureInfo.CreateSpecificCulture("es-ES"));
        }


        private void lblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Dese Volver a la pantalla principal", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                frmAdministracion administracion = new frmAdministracion(this.userForm);
                this.Hide();
                administracion.ShowDialog();
                this.Close();
            }
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


        /// <summary>
        /// Toma la lista de ventas y muestra el total de las ventas
        /// </summary>
        private  void CargarTexto()
        {
            lblFecha.Visible = true;
            facturacion = new Facturacion(listaVentas);
            lblFecha.Text = facturacion.ToString();
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


        /// <summary>
        /// Seteo de Color en los objetos
        /// </summary>
        private void ApagarDarkMode()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            lblNombreUsuario.ForeColor = Color.Black;
            lblFecha.ForeColor = Color.Black;
            lblTimer.ForeColor = Color.Black;
            lblVisionOscura.Text = "Visiion Black";
        }


        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            if (ManejadorDeForms.DarkMode)
            {
                ApagarDarkMode();
            }
        }


        private void lblVisionOscura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManejadorDeForms.DarkMode = !ManejadorDeForms.DarkMode;
            if (ManejadorDeForms.DarkMode)
            {
                this.BackColor = Color.Black;
                lblNombreUsuario.ForeColor = Color.White;
                lblFecha.ForeColor = Color.White;
                lblTimer.ForeColor = Color.White;
                lblVisionOscura.Text = "Visiion White";
            }
            else
            {
                ApagarDarkMode();
            }
        }

    }
}
