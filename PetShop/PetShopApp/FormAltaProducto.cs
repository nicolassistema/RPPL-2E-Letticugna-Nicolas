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
    public partial class FrmAltaProducto : Form
    {
        Usuario userForm;
        public FrmAltaProducto()
        {
            InitializeComponent();
        }


        public FrmAltaProducto(Usuario usuario) : this()
        {
            this.userForm = usuario;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Producto producto;
            //lblMensaje.Text = "";
            //StringBuilder sb = new StringBuilder();
            //List<Cliente> lista = new List<Cliente>();

            //if (Validaciones.ValidateNumber(txtCuit.Text))
            //{
            //    sb.AppendLine("*Cuit Incorrecto");
            //    lblMensaje.ForeColor = Color.Red;
            //    lblMensaje.Visible = true;
            //}
            //else
            //{
            //    lblMensaje.Visible = true;
            //}

            //if (Validaciones.ValidacionString(txtNombre.Text))
            //{
            //    sb.AppendLine("*Formato de nombre incorrecto");
            //    lblMensaje.ForeColor = Color.Red;
            //    lblMensaje.Visible = true;
            //}

            //if (Validaciones.ValidacionString(txtApellido.Text))
            //{
            //    sb.AppendLine("*Formato de apellido incorrecto");
            //    lblMensaje.ForeColor = Color.Red;
            //    lblMensaje.Visible = true;
            //}

            //producto = new Producto(txtCuit.Text, txtNombre.Text, txtApellido.Text, 0);
            //PetShop.AddProducto(producto);

       
                string valor = cmbTipoProd.SelectedValue.ToString();

         


            this.Hide();
            this.Close();
        }

        private void cmbTipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoProd.Text.ToString() != null)
            {
                string detalleTipoProducto = cmbTipoProd.Text.ToString();

                CargaDetalleTipoProd(detalleTipoProducto);
            }
        }

        private void CargaDetalleTipoProd(string detalle)
        {
            cmbDetalleTipoProd.Items.Clear();

            switch (detalle)
            {
                case "Juguete":
                    cmbDetalleTipoProd.Items.Add(new { Text = "Plastico", Value = "1" });
                    cmbDetalleTipoProd.Items.Add(new { Text = "Goma", Value = "2" });
                    break;
                case "Cama":
                    cmbDetalleTipoProd.Items.Add(new { Text = "Tamaño Chico", Value = "1" });
                    cmbDetalleTipoProd.Items.Add(new { Text = "Tamaño Grande", Value = "2" });
                    break;
                case "Alimento":
                    cmbDetalleTipoProd.Items.Add(new { Text = "Natural", Value = "1" });
                    cmbDetalleTipoProd.Items.Add(new { Text = "Balanceado", Value = "2" });
                    break;

                case "Art. Cuidado Mascota":
                    cmbDetalleTipoProd.Items.Add(new { Text = "Farmacia", Value = "1" });
                    cmbDetalleTipoProd.Items.Add(new { Text = "Limpieza", Value = "2" });
                    break;
                default:
                    break;
            }


        }
    }
}
