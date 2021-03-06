using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Entidades;
using System.Diagnostics.Tracing;

namespace PetShopApp
{
    public partial class FormVenta : Form
    {

        Usuario userForm;
        private const int CP_NOCLOSE_BUTTON = 0x200;

        /// <summary>
        /// Constructor sin parámetros de la clase FormVenta.
        /// </summary>
        public FormVenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor con parámetros de la clase FormVenta.
        /// </summary>
        /// <param name="usuario"></param>
        public FormVenta(Usuario usuario) : this()
        {
            InicializadorCuadras();
            chkSinEnvio.Checked = true;
            ActiveDesctiveEnvio(false);
            this.userForm = usuario;
            btnSalirDeVenta.Visible = false;
            btnCompraNueva.Visible = false;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            btnCancelaCompra.Enabled = false;
            btnAceptaCompra.Enabled = false;
            dgvListaProdSelecc.AllowUserToAddRows = false;
            ActivDesactivPnlCompra(false);
            ActivDesactivPnlVenta(false);
            VisibilidadPnlVenta(false);
            RestartearListas();
            btnSacar.Enabled = false;
            btnLimpiarSelectProd.Enabled = false;
            FocusPnlBuscarCliente(true);
            VisibilidadPnlConfirmarCompra(false);
        }


        /// <summary>
        /// Carga el datagrid con informacion de la lista
        /// </summary>
        private void CargarDataGridProducto()
        {
            int i = 0;
            dgvListaProductos.Refresh();
            dgvListaProductos.DataSource = null;
            dgvListaProductos.RowCount = PetShop.ObtenerPorductos().Count;
            foreach (var item in PetShop.ObtenerPorductos())
            {
                dgvListaProductos.Rows[i].Cells[0].Value = item.Codigo;
                dgvListaProductos.Rows[i].Cells[1].Value = item.Marca;
                dgvListaProductos.Rows[i].Cells[2].Value = item.Nombre;
                dgvListaProductos.Rows[i].Cells[3].Value = item.Descripcion;
                dgvListaProductos.Rows[i].Cells[4].Value = item.Cantidad;
                dgvListaProductos.Rows[i].Cells[5].Value = item.Precio;
                dgvListaProductos.Rows[i].Cells[6].Value = item.Kilogramos;
                dgvListaProductos.Rows[i].Cells[7].Value = Validaciones.ObtenerNombreObjeto(item);
                dgvListaProductos.Rows[i].Cells[8].Value = Validaciones.ObtenerValorEnumeradoDeObjeto(item);
                i++;
            }
        }


        /// <summary>
        /// Actualiza la lista de productos con la informacion del datagrid
        /// </summary>
        /// <returns>devuelve la lista de productos luego de ser actualizada</returns>
        private List<Producto> ActualizarInventario()
        {
            List<Producto> listaAux = new List<Producto>();
            string nombre;
            string marca;
            string descripcion;
            int cantidad;
            double precio;
            double kiloG;
            PetShop.LimpiarListaProductos();

            for (int i = 0; i < dgvListaProductos.RowCount; i++)
            {
                marca = dgvListaProductos.Rows[i].Cells[1].Value.ToString();
                nombre = dgvListaProductos.Rows[i].Cells[2].Value.ToString();
                descripcion = dgvListaProductos.Rows[i].Cells[3].Value.ToString();
                cantidad = Convert.ToInt32(dgvListaProductos.Rows[i].Cells[4].Value.ToString());
                precio = double.Parse(dgvListaProductos.Rows[i].Cells[5].Value.ToString());
                kiloG = double.Parse(dgvListaProductos.Rows[i].Cells[6].Value.ToString());

                switch (dgvListaProductos.Rows[i].Cells[7].Value.ToString())
                {
                    case "Juguete":
                        PetShop.listaProductos += new Juguete(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.Juguete.EMaterial)Enum.Parse(typeof(Entidades.Juguete.EMaterial), dgvListaProductos.Rows[i].Cells[8].Value.ToString()));
                        break;
                    case "Cama":
                        PetShop.listaProductos += new Cama(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.Cama.ETamanio)Enum.Parse(typeof(Entidades.Cama.ETamanio), dgvListaProductos.Rows[i].Cells[8].Value.ToString()));
                        break;
                    case "Alimento":
                        PetShop.listaProductos += new Alimento(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.Alimento.ETipoAlimento)Enum.Parse(typeof(Entidades.Alimento.ETipoAlimento), dgvListaProductos.Rows[i].Cells[8].Value.ToString()));
                        break;
                    case "ArtCuidadoMascota":
                        PetShop.listaProductos += new ArtCuidadoMascota(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.ArtCuidadoMascota.ETipoCuidado)Enum.Parse(typeof(Entidades.ArtCuidadoMascota.ETipoCuidado), dgvListaProductos.Rows[i].Cells[8].Value.ToString()));
                        break;
                    default:
                        break;
                }
            }
            return PetShop.ObtenerPorductos();
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


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            List<Cliente> lista = new List<Cliente>();
            lista = PetShop.ObtenerListaCliente();

            if (!(Validaciones.ValidateNumberCuit(txtCuit.Text)))
            {
                lblMensajeCliente.Text = "Cuit Incorrecto";
                lblMensajeCliente.Visible = true;
                lblCuit.Visible = false;
                lblNombre.Visible = false;
                lblApellido.Visible = false;
                ActivDesactivPnlCompra(false);
            }
            else if (PetShop.ObtenerClientePorCuit(txtCuit.Text) is null)
            {
                DialogResult boton = MessageBox.Show("Cliente inexistente. Desea cargarlo en el sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (boton == DialogResult.Yes)
                {
                    FormAltaCliente cliente = new FormAltaCliente(this.userForm, txtCuit.Text);
                    cliente.ShowDialog();
                }
            }
            else
            {
                btnLimpiarSelectProd.Enabled = true;
                foreach (var item in lista)
                {
                    if (item.Cuit.ToString() == txtCuit.Text)
                    {
                        if (PetShop.BuscarClientePorString(item, txtCuit.Text.ToLower()))
                        {
                            if (dgvListaProdSelecc.RowCount > 0)
                            {
                                btnSacar.Enabled = true;
                                btnAceptaCompra.Enabled = true;
                                btnCancelaCompra.Enabled = true;
                            }
                            else
                            {
                                btnLimpiarSelectProd.Enabled = false;
                            }
                            if (double.Parse(lblMostrarTotal.Text) <= 0)
                            {
                                btnLimpiarSelectProd.Enabled = false;
                            }

                            btnCancelaCompra.Enabled = true;
                            ActivDesactivPnlCompra(true);
                            lblMensajeCliente.Visible = false;
                            lblCuit.Text = item.Cuit.ToString();
                            lblCuit.Visible = true;
                            lblNombre.Text = item.Nombre.ToString();
                            lblNombre.Visible = true;
                            lblApellido.Text = item.Apellido.ToString();
                            lblApellido.Visible = true;
                            ActivDesactivPnlBuscarCliente(false);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Restartea valores del formulario y el datagrid
        /// </summary>
        private void RestartearListas()
        {
            dgvListaProductos.Rows.Clear();
            dgvListaProdSelecc.Rows.Clear();
            CargarDataGridProducto();
            lblMostrarTotal.Text = "0.00";
            lblKgNumber.Text = "0.00";
            lblTipoEnvio.Text = "Moto: $";
            lblMontoTipoEnvio.Text = "100";
        }


        /// <summary>
        /// Restartea objetos que estan relacionados con la venta en el formulario
        /// </summary>
        private void RestartearVta()
        {
            pnlVenta.Visible = false;
            lblMontoVta.Text = "0.00";
            cmbFromaPago.Text = "";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
        }


        /// <summary>
        /// Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana
        /// </summary>
        /// <param name="estado"></param>
        private void FocusPnlBuscarCliente(bool estado)
        {
            if (estado)
            {
                if (ManejadorDeForms.DarkMode)
                {
                    this.pnlBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
                    this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;

                }
                else
                {
                    pnlBuscarCliente.BackColor = Color.LightYellow;
                    this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                }

            }
            else
            {
                if (ManejadorDeForms.DarkMode)
                {
                    this.pnlBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
                    this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;


                }
                else
                {
                    this.pnlBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
                    this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                }
            }
        }


        /// <summary>
        /// Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana
        /// </summary>
        /// <param name="estado"></param>
        private void FocusPnlCompra(bool estado)
        {
            if (estado)
            {
                if (ManejadorDeForms.DarkMode)
                {
                    pnlCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
                    this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
                else
                {
                    pnlCompra.BackColor = Color.LightYellow;
                    this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
            else
            {
                if (ManejadorDeForms.DarkMode)
                {
                    pnlCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
                    this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
                else
                {
                    pnlCompra.BackColor = Color.LightYellow;
                    this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
        }


        /// <summary>
        /// Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana
        /// </summary>
        /// <param name="estado"></param>
        private void FocusPnlVenta(bool estado)
        {
            if (estado)
            {
                if (ManejadorDeForms.DarkMode)
                {
                    pnlVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
                    this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
                else
                {
                    pnlVenta.BackColor = Color.LightYellow;
                    this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
            else
            {
                if (ManejadorDeForms.DarkMode)
                {
                    pnlVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
                    this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
                else
                {
                    pnlVenta.BackColor = Color.LightYellow;
                    this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
                    
            }
        }


        /// <summary>
        ///  Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana
        /// </summary>
        /// <param name="estado"></param>
        private void FocusPnlConfirm(bool estado)
        {
            if (estado)
            {
                pnlConfirmarCompra.BackColor = Color.LightYellow;
                this.pnlConfirmarCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                this.pnlConfirmarCompra.BackColor = System.Drawing.SystemColors.Control;
                this.pnlConfirmarCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }


        /// <summary>
        ///  Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana y activa o desactiva un objeto
        /// </summary>
        /// <param name="estado"></param>
        private void ActivDesactivPnlBuscarCliente(bool estado)
        {
            if (estado)
            {
                pnlBuscarCliente.Enabled = true;
                FocusPnlBuscarCliente(true);
            }
            else
            {

                pnlBuscarCliente.Enabled = false;
                FocusPnlBuscarCliente(false);
            }
        }





        /// <summary>
        ///  Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana y activa o desactiva un objeto
        /// </summary>
        /// <param name="estado"></param>
        private void ActivDesactivPnlCompra(bool estado)
        {
            if (estado)
            {
                FocusPnlCompra(true);
                pnlCompra.Enabled = true;
            }
            else
            {
                FocusPnlCompra(false);
                pnlCompra.Enabled = false;
                btnLimpiarSelectProd.Enabled = false;
            }
        }


        /// <summary>
        ///  Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana y activa o desactiva un objeto
        /// </summary>
        /// <param name="estado"></param>
        private void ActivDesactivPnlVenta(bool estado)
        {
            if (estado)
            {
                pnlVenta.Enabled = true;
                FocusPnlVenta(true);
            }
            else
            {
                pnlVenta.Enabled = false;
                FocusPnlVenta(false);
            }
        }


        /// <summary>
        ///  Realza un grupo de objetos ubicados en el formulario por medio de activacion por variable booleana y activa o desactiva un objeto
        /// </summary>
        /// <param name="estado"></param>
        private void ActiveDesactivePnlConfirm(bool estado)
        {
            if (estado)
            {
                pnlConfirmarCompra.Enabled = true;
                FocusPnlConfirm(true);
            }
            else
            {
                pnlConfirmarCompra.Enabled = false;
                FocusPnlConfirm(false);
            }
        }


        /// <summary>
        /// Activa o desactiva un grupo de objetos  por medio de activacion por variable booleana 
        /// </summary>
        /// <param name="estado"></param>
        private void ActiveDesctiveEnvio(bool estado)
        {
            if (estado)
            {
                lblKg.Visible = true;
                lblKgNumber.Visible = true;
                lblTipoEnvio.Visible = true;
                lblTipoEnvioDescrip.Visible = true;
                lblDescripMax.Visible = true;
                lblMontoTipoEnvio.Visible = true;
                lblDistancia.Visible = true;
                lblDistancia2.Visible = true;
                lblCantCuadras.Visible = true;
                lblPrcioXCuadra.Visible = true;
            }
            else
            {
                lblKg.Visible = false;
                lblKgNumber.Visible = false;
                lblTipoEnvio.Visible = false;
                lblTipoEnvioDescrip.Visible = false;
                lblDescripMax.Visible = false;
                lblMontoTipoEnvio.Visible = false;
                lblDistancia.Visible = false;
                lblDistancia2.Visible = false;
                lblCantCuadras.Visible = false;
                lblPrcioXCuadra.Visible = false;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double acum = 0;
            int stock = 0;
            double kg = 0;
            btnLimpiarSelectProd.Enabled = true;
            lblKgNumber.Text = "0.00";
            lblMontoVta.Text = "0.00";
            cmbFromaPago.Text = "";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
            btnAceptaCompra.Enabled = true;
            btnCancelaCompra.Enabled = true;
            btnSacar.Enabled = true;

            Producto productoAux = new Producto();
            int aux = Convert.ToInt32(dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[0].Value);
            productoAux = PetShop.ObtenerProductoByID(aux);
            if (!(Convert.ToInt32(dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[4].Value) < 1))
            {
                dgvListaProdSelecc.Rows.Add(new[] { productoAux.Codigo.ToString(), productoAux.Marca.ToString(), productoAux.Nombre.ToString(), productoAux.Precio.ToString(), productoAux.Kilogramos.ToString(), Validaciones.ObtenerNombreObjeto(productoAux) });
                dgvListaProdSelecc.AllowUserToAddRows = false;
                for (int i = 0; i < dgvListaProdSelecc.RowCount; i++)
                {
                    acum += double.Parse(dgvListaProdSelecc.Rows[i].Cells[3].Value.ToString());
                    kg += double.Parse(dgvListaProdSelecc.Rows[i].Cells[4].Value.ToString());
                }
                if (kg > 100)
                {
                    lblTipoEnvio.Text = "MiniFlete: $";
                    lblMontoTipoEnvio.Text = "500";
                }
                lblMostrarTotal.Text = string.Format("{0:f2}", acum);
                lblKgNumber.Text = string.Format("{0:f2}", kg);
                stock = Convert.ToInt32(dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[4].Value);
                stock -= 1;
                dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].Cells[4].Value = stock.ToString();
            }
            else
            {
                MessageBox.Show("Producto sin stock!!!");
            }
        }


        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnLimpiarSelectProd.Enabled = true;
            lblMontoVta.Text = "0.00";
            cmbFromaPago.Text = "";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
            int idAux = Convert.ToInt32(dgvListaProdSelecc.Rows[dgvListaProdSelecc.CurrentCell.RowIndex].Cells[0].Value);
            int stock = 0;
            double acumDos = double.Parse(lblMostrarTotal.Text);
            double totalKg = double.Parse(lblKgNumber.Text);
            double acum = double.Parse(dgvListaProdSelecc.CurrentRow.Cells[3].Value.ToString());
            double acumKg = double.Parse(dgvListaProdSelecc.CurrentRow.Cells[4].Value.ToString());
            dgvListaProdSelecc.Rows.Remove(dgvListaProdSelecc.CurrentRow);
            lblMostrarTotal.Text = string.Format("{0:f2}", (acumDos - acum));
            lblKgNumber.Text = string.Format("{0:f2}", (totalKg - acumKg));

            if ((totalKg - acumKg) <= 100)
            {
                lblTipoEnvio.Text = "Moto: $";
                lblMontoTipoEnvio.Text = "100";
            }
            for (int i = 0; i < dgvListaProductos.RowCount; i++)
            {
                if (idAux == Convert.ToInt32(dgvListaProductos.Rows[i].Cells[0].Value.ToString()))
                {
                    stock = Convert.ToInt32(dgvListaProductos.Rows[i].Cells[4].Value.ToString());
                    stock += 1;
                    dgvListaProductos.Rows[i].Cells[4].Value = stock.ToString();
                    break;
                }
            }
            if (double.Parse(lblMostrarTotal.Text) <= 0)
            {
                btnAceptaCompra.Enabled = false;
                btnSacar.Enabled = false;
                btnLimpiarSelectProd.Enabled = false;
            }
        }



        private void btnAceptaCompra_Click(object sender, EventArgs e)
        {
            double precioXCuadra = 0;
            double total = 0;
            double resultado = 0;
            double montoTipoEnvio = 0;
            ActivDesactivPnlCompra(false);
            ActivDesactivPnlVenta(true);
            pnlVenta.Visible = true;
            cmbFromaPago.Enabled = true;
            txtMontoAPagar.Enabled = true;
            btnAceptarVta.Enabled = true;
            btnCancelarVta.Enabled = true;
            cmbFromaPago.Text = "Efectivo";
            txtMontoAPagar.Text = "";
            lblMontoPagar.Text = "0.00";
            lblVto.Text = "0.00";
            if (!chkConEnvio.Checked)
            {
                lblMontoVta.Text = string.Format("{0:f2}", double.Parse(lblMostrarTotal.Text.ToString()));
            }
            else
            {
                precioXCuadra = double.Parse(lblPrcioXCuadra.Text.ToString());
                total = double.Parse(lblMostrarTotal.Text.ToString());
                montoTipoEnvio = double.Parse(lblMontoTipoEnvio.Text.ToString());
                resultado = precioXCuadra + total + montoTipoEnvio;
                lblMontoVta.Text = string.Format("{0:f2}", double.Parse(resultado.ToString()));
            }
        }
        private void btnCancelaCompra_Click(object sender, EventArgs e)
        {
            btnSacar.Enabled = false;
            btnAceptaCompra.Enabled = false;
            btnCancelaCompra.Enabled = false;
            ActivDesactivPnlCompra(false);
            ActivDesactivPnlBuscarCliente(true);
        }



        private void btnLimpiarSelectProd_Click(object sender, EventArgs e)
        {
            btnLimpiarSelectProd.Enabled = false;
            btnCancelaCompra.Enabled = true;
            btnAceptaCompra.Enabled = false;
            btnSacar.Enabled = false;
            lblMostrarTotal.Text = "0.00";
            lblKgNumber.Text = "0.00";
            dgvListaProdSelecc.Rows.Clear();
            CargarDataGridProducto();
        }


        /// <summary>
        /// Activa/desactiva visibilidad de un objeto por medio de parametro variable booleana
        /// </summary>
        /// <param name="estado"></param>
        private void VisibilidadPnlVenta(bool estado)
        {
            if (estado)
            {
                pnlVenta.Visible = true;
            }
            else
            {
                pnlVenta.Visible = false;
            }
        }


        /// <summary>
        /// Activa/desactiva visibilidad de un objeto por medio de parametro variable booleana
        /// </summary>
        /// <param name="estado"></param>
        private void VisibilidadPnlConfirmarCompra(bool estado)
        {
            if (estado)
            {
                pnlConfirmarCompra.Visible = true;
            }
            else
            {
                pnlConfirmarCompra.Visible = false;
            }

        }


        private void btnCancelarVta_Click(object sender, EventArgs e)
        {
            btnAceptaCompra.Enabled = true;
            btnCancelaCompra.Enabled = true;
            RestartearVta();
            ActivDesactivPnlCompra(true);
            btnLimpiarSelectProd.Enabled = true;
        }


        private void btnAceptarVta_Click(object sender, EventArgs e)
        {
            double montoTotal;
            double montoPago;
            if (!(txtMontoAPagar.Text == ""))
            {
                if (Validaciones.ValidarDecimal(txtMontoAPagar.Text.ToString()))
                {
                    txtMontoAPagar.Text = Validaciones.PuntoToComa(txtMontoAPagar.Text.ToString());
                    try
                    {
                        Validaciones.ValidaSaldoAPagar(lblMontoVta.Text, txtMontoAPagar.Text);
                        lblMontoPagar.Text = txtMontoAPagar.Text.ToString();
                        montoTotal = double.Parse(lblMontoVta.Text.ToString());
                        montoPago = double.Parse(lblMontoPagar.Text.ToString());
                        lblVto.Text = string.Format("{0:f2}", (montoPago - montoTotal));
                        VisibilidadPnlConfirmarCompra(true);
                        pnlVenta.Enabled = false;
                        FocusPnlVenta(false);
                        FocusPnlConfirm(true);
                    }
                    catch (ClienteSinDineroExcepcion ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Error al ingresar el monto a pagar. Por favor ingresar correctamente un numero en formato decimal positivo");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresar el monto a pagar");
            }
        }


        private void btnCancelarConfirmCompra_Click(object sender, EventArgs e)
        {
            VisibilidadPnlConfirmarCompra(false);
            ActivDesactivPnlVenta(true);
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            int id;
            string marca;
            string nombre;
            double precio;
            double montoEnvio = 0;
            double tipoMontoEnvio = 0;
            List<Producto> listaProducto = new List<Producto>();

            for (int i = 0; i < dgvListaProdSelecc.RowCount; i++)
            {
                id = Convert.ToInt32(dgvListaProdSelecc.Rows[i].Cells[0].Value.ToString());
                marca = dgvListaProdSelecc.Rows[i].Cells[1].Value.ToString();
                nombre = dgvListaProdSelecc.Rows[i].Cells[2].Value.ToString();
                precio = double.Parse(dgvListaProdSelecc.Rows[i].Cells[3].Value.ToString());
                Producto producto = new Producto(id, marca, nombre, precio);
                listaProducto += (producto);
            }
            Cliente cliente = PetShop.ObtenerClientePorCuit(txtCuit.Text);
            if (chkConEnvio.Checked)
            {
                montoEnvio = double.Parse(lblPrcioXCuadra.Text.ToString());
                tipoMontoEnvio = double.Parse(lblMontoTipoEnvio.Text.ToString());
            }
            Venta venta = new Venta(userForm, cliente, double.Parse(lblMontoVta.Text.ToString()), listaProducto, montoEnvio, tipoMontoEnvio);
            FormFactura factura = new FormFactura(venta);
            PetShop.listaVentas += venta;
            PetShop.LimpiarListaProductos();
            ActualizarInventario();
            PasoFinal();
            factura.ShowDialog();
        }


        /// <summary>
        /// Activa y desactiva un grupo de objetos determinados
        /// </summary>
        public void PasoFinal()
        {
            btnSalirDeVenta.Visible = true;
            btnCompraNueva.Visible = true;
            btnConfirmarCompra.Visible = false;
            btnCancelarConfirmCompra.Visible = false;
        }



        private void btnSalirDeVenta_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Dese Salir de la pantalla venta hacia el menu principal?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.No)
            {
                frmAdministracion administracion = new frmAdministracion(this.userForm);
                this.Hide();
                administracion.ShowDialog();
                this.Close();
            }
        }



        private void btnCompraNueva_Click(object sender, EventArgs e)
        {
            FormVenta fm = new FormVenta(this.userForm);
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }



        private void chkSinEnvio_CheckedChanged(object sender, EventArgs e)
        {
            chkConEnvio.Checked = false;
            ActiveDesctiveEnvio(false);
        }



        private void chkConEnvio_CheckedChanged(object sender, EventArgs e)
        {
            chkSinEnvio.Checked = false;
            ActiveDesctiveEnvio(true);
        }



        private void CheckedSinEnvio(object sender, MouseEventArgs e)
        {
            chkSinEnvio.Checked = true;
        }


        private void CheckedConEnvio(object sender, MouseEventArgs e)
        {
            chkConEnvio.Checked = true;
        }


        /// <summary>
        /// Genera un valor random
        /// </summary>
        /// <returns>devuelve el valor random</returns>
        private int RandomCuadra()
        {
            Random r = new Random();
            return int.Parse(r.Next(1, 90).ToString());
        }


        /// <summary>
        /// Devuelve un valor segun numero pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve un valor segun numero pasado por parametro</returns>
        private int CalculoCuadra(int numero)
        {
            if (numero <= 30)
            {
                return 150;
            }
            else if (numero <= 60)
            {
                return 300;
            }
            else if (numero <= 90)
            {
                return 450;
            }
            else if (numero > 90)
            {
                return 60;
            }
            return 0;
        }


        /// <summary>
        /// Devuelve la informacion segun valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve la informacion segun valor pasado por parametro</returns>
        private string InfoCuadras(int numero)
        {
            if (numero <= 30)
            {
                return "Hasta 30: $";
            }
            else if (numero <= 60)
            {
                return "Hasta 60: $";
            }
            else if (numero <= 90)
            {
                return "Hasta 90: $";
            }
            else if (numero > 90)
            {
                return "Mas de 90: $";
            }
            return "";
        }


        /// <summary>
        /// Inicializa valores de objetos en el formulario
        /// </summary>
        private void InicializadorCuadras()
        {
            int numero = RandomCuadra();
            lblCantCuadras.Text = InfoCuadras(numero);
            lblPrcioXCuadra.Text = CalculoCuadra(numero).ToString();
        }


        private void lblDescuento_Click(object sender, EventArgs e)
        {
            if (PetShop.listaDescuentos.Count > 0)
            {
                Producto producto = new Producto();
                producto = PetShop.listaDescuentos.Pop();

                DialogResult dr = MessageBox.Show($"Felicidades!!! tiene promocion del producto {producto.ToString()} Desea aceptar la promo?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.No)
                {
                    dgvListaProdSelecc.Rows.Add(new[] { producto.Codigo.ToString(), producto.Marca.ToString(), producto.Nombre.ToString(), producto.Precio.ToString(), producto.Kilogramos.ToString(), producto.Descripcion.ToString() });
                }
                else
                {
                    PetShop.listaDescuentos.Push(producto);
                }
            }
            else
            {
                MessageBox.Show("Ya no hay productos en promocion");
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


        private void lbkClienteExistente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCuit.Text = "20323205109";
        }


        private void lbkNoCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCuit.Text = "20323206024";
        }


        private void ApagarDarkMode()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            lblNombreUsuario.ForeColor = Color.Black;
            lbkBlackTheme.Text = "DarkMode ON";
            pnlBuscarCliente.BackColor = Color.LightYellow;
            this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCompra.BackColor = Color.LightYellow;
            pnlVenta.BackColor = Color.LightYellow;
            this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void PrenderDarkMode()
        {
            this.BackColor = Color.Black;
            lblNombreUsuario.ForeColor = Color.White;
            lbkBlackTheme.Text = "DarkMode OFF";
            this.pnlBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
            pnlCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
            this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(117)))), ((int)(((byte)(33)))));
            this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }


        private void lblDarkMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManejadorDeForms.DarkMode = !ManejadorDeForms.DarkMode;
            if (ManejadorDeForms.DarkMode)
            {
                PrenderDarkMode();
            }
            else
            {
                ApagarDarkMode();
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            if (ManejadorDeForms.DarkMode)
            {
                PrenderDarkMode();
            }
            else
            {
                ApagarDarkMode();
            }
        }
    }
}
