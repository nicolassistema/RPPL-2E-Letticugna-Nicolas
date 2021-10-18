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
using System.IO;


namespace PetShopApp
{
    public partial class FormAltaProducto : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        Usuario userForm;
        Producto producto;
        formInventario inventario;
        public FormAltaProducto()
        {
            InitializeComponent();
        }


        public FormAltaProducto(Usuario usuario) : this()
        {
            this.userForm = usuario;
        }


        public FormAltaProducto(Usuario usuario, Producto producto) : this()
        {
            this.userForm = usuario;
            this.producto = producto;

            txtMarca.Text = producto.Marca;
            txtNombre.Text = producto.Nombre;
            txtDescrip.Text = producto.Descripcion;
            txtStock.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            txtKg.Text = producto.Kilogramos.ToString();
            cmbTipoProd.Text = formInventario.ObtenerNombreObjeto(producto);
            cmbDetalleTipoProd.Text = formInventario.ObtenerValorEnumeradoDeObjeto(producto);
        }



        private void btnCanelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cancelar el alta del Producto?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                this.Hide();
                this.Close();
            }
        }




        private void cmbTipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoProd.Text.ToString() != null)
            {
                string detalleTipoProducto = cmbTipoProd.Text.ToString();
                CargaDetalleTipoProd(detalleTipoProducto);
            }
        }

        public void VisualizacionTooltip(bool estado)
        {
            if (!estado)
            {
                this.ttMensaje.RemoveAll();
                this.ttMensaje.Hide(this);
            }
        }

        public void MensajeTooltip(Control control, string mensaje)
        {
            this.ttMensaje.AutoPopDelay = 5000;
            this.ttMensaje.InitialDelay = 1;
            this.ttMensaje.ReshowDelay = 1;
            this.ttMensaje.ShowAlways = true;
            this.ttMensaje.SetToolTip(control, mensaje);
        }

        private void CargaDetalleTipoProd(string detalle)
        {
            cmbDetalleTipoProd.Items.Clear();

            switch (detalle)
            {
                case "Juguete":
                    cmbDetalleTipoProd.Items.Add("Plastico");
                    cmbDetalleTipoProd.Items.Add("Goma");
                    break;
                case "Cama":
                    cmbDetalleTipoProd.Items.Add("Chico");
                    cmbDetalleTipoProd.Items.Add("Grande");
                    break;
                case "Alimento":
                    cmbDetalleTipoProd.Items.Add("Natural");
                    cmbDetalleTipoProd.Items.Add("Balanceado");
                    break;

                case "Art. Cuidado Mascota":
                    cmbDetalleTipoProd.Items.Add("Farmacia");
                    cmbDetalleTipoProd.Items.Add("Limpieza");
                    break;
                default:
                    break;
            }


        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (!(Validaciones.EspacioEnBlancoOVacio(txtMarca.Text)))
            {
                lblValidMarca.ForeColor = Color.Green;
            }
            else
            {
                lblValidMarca.ForeColor = Color.Red;
            }
        }

        private void txtMarca_MouseHover(object sender, EventArgs e)
        {
            if (!(Validaciones.EspacioEnBlancoOVacio(txtMarca.Text)))
            {
                VisualizacionTooltip(false);
            }
            else
            {
                MensajeTooltip(txtMarca, "Por favor ingresar una marca");
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

        private void txtNombre_MouseHover(object sender, EventArgs e)
        {
            if (!(Validaciones.EspacioEnBlancoOVacio(txtNombre.Text)))
            {
                VisualizacionTooltip(false);
            }
            else
            {
                MensajeTooltip(txtNombre, "Por favor Ingresar nombre de producto");
            }
        }

        private void txtDescrip_Leave(object sender, EventArgs e)
        {
            if (!(Validaciones.EspacioEnBlancoOVacio(txtDescrip.Text)))
            {
                lblValidDescrip.ForeColor = Color.Green;
            }
            else
            {
                lblValidDescrip.ForeColor = Color.Red;
            }
        }

        private void txtDescrip_MouseHover(object sender, EventArgs e)
        {
            if (!(Validaciones.EspacioEnBlancoOVacio(txtDescrip.Text)))
            {
                VisualizacionTooltip(false);
            }
            else
            {
                MensajeTooltip(txtDescrip, "Por favor Ingresar Descripcion del producto");
            }
        }

        private void txtStock_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ValidateNumber(txtStock.Text.ToString()))
            {
                lblValidStock.ForeColor = Color.Green;
            }
            else
            {
                lblValidStock.ForeColor = Color.Red;
            }
        }

        private void txtStock_MouseHover(object sender, EventArgs e)
        {
            if (Validaciones.ValidateNumber(txtStock.Text.ToString()))
            {
                VisualizacionTooltip(false);
            }
            else
            {
                MensajeTooltip(txtStock, "Ingresar numeros enteros positivos");
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ValidarDecimal(txtPrecio.Text))
            {
                txtPrecio.Text = Validaciones.PuntoToComa(txtPrecio.Text);
                lblValidPrecio.ForeColor = Color.Green;
            }
            else
            {
                lblValidPrecio.ForeColor = Color.Red;
            }
        }

        private void txtPrecio_MouseHover(object sender, EventArgs e)
        {
            if (Validaciones.ValidarDecimal(txtPrecio.Text))
            {
                VisualizacionTooltip(false);
            }
            else
            {
                MensajeTooltip(txtPrecio, "Ingresar numeros decimales positivos");
            }
        }

        private void txtKg_MouseHover(object sender, EventArgs e)
        {
            if (Validaciones.ValidarDecimal(txtKg.Text))
            {
                VisualizacionTooltip(false);
            }
            else
            {
                MensajeTooltip(txtKg, "Ingresar numeros decimales positivos");
            }
        }

        private void txtKg_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ValidarDecimal(txtKg.Text))
            {
                txtKg.Text = Validaciones.PuntoToComa(txtKg.Text);
                lblValidKg.ForeColor = Color.Green;
            }
            else
            {
                lblValidKg.ForeColor = Color.Red;
            }
        }

        private void cmbTipoProd_MouseHover(object sender, EventArgs e)
        {
            if (cmbTipoProd.SelectedIndex.Equals(-1))
            {
                MensajeTooltip(cmbTipoProd, "Seleccione un tipo de producto");
            }
            else
            {
                VisualizacionTooltip(false);
            }
        }

        private void cmbTipoProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoProd.SelectedIndex.Equals(-1))
            {
                lblValidTipoProd.ForeColor = Color.Red;
            }
            else
            {
                lblValidTipoProd.ForeColor = Color.Green;
            }
        }

        private void cmbDetalleTipoProd_MouseLeave(object sender, EventArgs e)
        {
            if (cmbDetalleTipoProd.Items.Count < 1)
            {
                MensajeTooltip(cmbDetalleTipoProd, "Primero seleccione un tipo de producto para luego seleccionar el tipo detalle del producto");
            }
            else if (cmbDetalleTipoProd.SelectedIndex.Equals(-1))
            {
                MensajeTooltip(cmbDetalleTipoProd, "Seleccione  el tipo detalle del producto");
            }
            else
            {
                VisualizacionTooltip(false);
            }
        }

        private void cmbDetalleTipoProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDetalleTipoProd.Items.Count < 1)
            {
                lblValidDetalleProd.ForeColor = Color.Red;
            }
            else if (cmbDetalleTipoProd.SelectedIndex.Equals(-1))
            {
                lblValidDetalleProd.ForeColor = Color.Red;
            }
            else
            {
                lblValidDetalleProd.ForeColor = Color.Green;
            }
        }

        private bool FlagDetector()
        {
            if (lblValidMarca.ForeColor != Color.Red &&
                lblValidNombre.ForeColor != Color.Red &&
                 lblValidDescrip.ForeColor != Color.Red &&
                 lblValidStock.ForeColor != Color.Red &&
                 lblValidPrecio.ForeColor != Color.Red &&
                 lblValidKg.ForeColor != Color.Red &&
                 lblValidTipoProd.ForeColor != Color.Red &&
                 lblValidDetalleProd.ForeColor != Color.Red)
            {
                return true;
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        //    formInventario fm = new formInventario(this.userForm);

            if (!FlagDetector())
            {
                MessageBox.Show("Por favor competar los campos requeridos");
            }
            else
            {
                switch (cmbTipoProd.SelectedItem.ToString())
                {
                    case "Juguete":
                        PetShop.AddProducto((new Juguete(txtMarca.Text, txtNombre.Text, txtDescrip.Text, Convert.ToInt32(txtStock.Text), double.Parse(txtPrecio.Text), double.Parse(txtKg.Text), (Entidades.Juguete.EMaterial)Enum.Parse(typeof(Entidades.Juguete.EMaterial), cmbDetalleTipoProd.SelectedItem.ToString()))));
                        this.Hide();
                        this.Close();
                        break;
                    case "Cama":
                        PetShop.AddProducto((new Cama(txtMarca.Text, txtNombre.Text, txtDescrip.Text, Convert.ToInt32(txtStock.Text), double.Parse(txtPrecio.Text), double.Parse(txtKg.Text), (Entidades.Cama.ETamanio)Enum.Parse(typeof(Entidades.Cama.ETamanio), cmbDetalleTipoProd.SelectedItem.ToString()))));
                        this.Hide();
                        this.Close();
                        break;
                    case "Alimento":
                        PetShop.AddProducto((new Alimento(txtMarca.Text, txtNombre.Text, txtDescrip.Text, Convert.ToInt32(txtStock.Text), double.Parse(txtPrecio.Text), double.Parse(txtKg.Text), (Entidades.Alimento.ETipoAlimento)Enum.Parse(typeof(Entidades.Alimento.ETipoAlimento), cmbDetalleTipoProd.SelectedItem.ToString()))));
                        this.Hide();
                        this.Close();
                        break;
                    case "Art. Cuidado Mascota":
                        PetShop.AddProducto((new ArtCuidadoMascota(txtMarca.Text, txtNombre.Text, txtDescrip.Text, Convert.ToInt32(txtStock.Text), double.Parse(txtPrecio.Text), double.Parse(txtKg.Text), (Entidades.ArtCuidadoMascota.ETipoCuidado)Enum.Parse(typeof(Entidades.ArtCuidadoMascota.ETipoCuidado), cmbDetalleTipoProd.SelectedItem.ToString()))));
                        this.Hide();
                        this.Close();
                        break;

                    default:
                        break;
                }


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
