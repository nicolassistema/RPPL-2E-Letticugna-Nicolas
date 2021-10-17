using System;
using System.Collections.Generic;
using System.Reflection;
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
    public partial class formInventario : Form
    {
        Usuario userForm;

        public formInventario()
        {
            InitializeComponent();
        }

        public formInventario(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            RestartearListas();
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

        public void CargarDataGridProducto()
        {
            int i = 0;
            dvgProductos.Refresh();
            dvgProductos.DataSource = null;
            dvgProductos.RowCount = PetShop.ObtenerPorductos().Count;
            foreach (var item in PetShop.ObtenerPorductos())
            {
                dvgProductos.Rows[i].Cells[0].Value = item.Codigo;
                dvgProductos.Rows[i].Cells[1].Value = item.Marca;
                dvgProductos.Rows[i].Cells[2].Value = item.Nombre;
                dvgProductos.Rows[i].Cells[3].Value = item.Descripcion;
                dvgProductos.Rows[i].Cells[4].Value = item.Cantidad;
                dvgProductos.Rows[i].Cells[5].Value = item.Precio;
                dvgProductos.Rows[i].Cells[6].Value = item.Kilogramos;
                dvgProductos.Rows[i].Cells[7].Value = ObtenerNombreObjeto(item);
                dvgProductos.Rows[i].Cells[8].Value = ObtenerValorEnumeradoDeObjeto(item);
                i++;
            }
        }






        public static string ObtenerValorEnumeradoDeObjeto(Object objeto)
        {
            Type type = objeto.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                if (!(propertyInfo.GetType().IsEnum))
                {
                    string lala = propertyInfo.GetValue(objeto).ToString();
                    return lala;
                }
            }
            return null;
        }

        public static string ObtenerNombreObjeto(Object objeto)
        {
            string aux;
            Type type = objeto.GetType();
            aux = type.ToString();
            aux = aux.Substring(aux.IndexOf(".") + 1);
            return aux;
        }


        public static Type ObtenerTipoObjetoByNombre(string nombre)
        {
            switch (nombre)
            {
                case "Cama":
                    Cama cama = new Cama();
                    return cama.GetType();
                    break;
                case "Juguete":
                    Juguete juguete = new Juguete();
                    return juguete.GetType();
                    break;
                case "ArtCuidadoMascota":
                    ArtCuidadoMascota articulo = new ArtCuidadoMascota();
                    return articulo.GetType();
                    break;
                case "Alimento":
                    Alimento alimento = new Alimento();
                    return alimento.GetType();
                    break;

                default:
                    return null;
                    break;
            }

        }

        public void RestartearListas()
        {
            dvgProductos.Rows.Clear();
            CargarDataGridProducto();
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!(txtBuscar.Text == ""))
            {
                InhabilitarBotonesIzquierdos(false);
                dvgProductos.ReadOnly = false;
                dvgProductos.Rows.Clear();
                dvgProductos.DataSource = null;
                List<Producto> lista = new List<Producto>();
                lista = PetShop.ObtenerPorductos();
                foreach (var item in lista)
                {
                    if (PetShop.BuscarProductoPorString(item, txtBuscar.Text.ToLower()))
                    {
                        dvgProductos.Rows.Add(item.Codigo, item.Marca, item.Nombre, item.Descripcion, item.Cantidad, item.Precio, item.Kilogramos, ObtenerNombreObjeto(item), ObtenerValorEnumeradoDeObjeto(item));
                        //MakeReadOnly();
                    }
                }
                MakeReadOnly();
            }
            else
            {

                InhabilitarBotonesIzquierdos(true);
                dvgProductos.Rows.Clear();
                dvgProductos.DataSource = null;
                List<Producto> lista = new List<Producto>();
                lista = PetShop.ObtenerPorductos();
                foreach (var item in lista)
                {
                    if (PetShop.BuscarProductoPorString(item, txtBuscar.Text.ToLower()))
                    {
                        dvgProductos.Rows.Add(item.Codigo, item.Marca, item.Nombre, item.Descripcion, item.Cantidad, item.Precio, item.Kilogramos, ObtenerNombreObjeto(item), ObtenerValorEnumeradoDeObjeto(item));
                        //MakeReadOnly();
                    }
                }
                dvgProductos.ReadOnly = false;
            }
        }



        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            InhabilitarBotonesIzquierdos(true);

        }

        private void MakeReadOnly()
        {
            dvgProductos.AllowUserToAddRows = false;
            dvgProductos.AllowUserToDeleteRows = false;
            dvgProductos.ReadOnly = true;
        }


        private void InhabilitarBotonesIzquierdos(bool estado)
        {
            if (estado)
            {
                btnAlta.Enabled = true;
                btnConfirmModificacion.Enabled = true;
                btnCancelarModificacion.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnAlta.Enabled = false;
                btnConfirmModificacion.Enabled = false;
                btnCancelarModificacion.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }



        private void bntAlta_Click(object sender, EventArgs e)
        {
            FormAltaProducto producto = new FormAltaProducto(this.userForm);
            producto.ShowDialog();
            this.CargarDataGridProducto();
        }

        private void btnConfirmModificacion_Click(object sender, EventArgs e)
        {
            ActualizarInventario();
            dvgProductos.ClearSelection();
            btnCancelarModificacion.Enabled = false;
            btnEliminar.Enabled = false;
            CargarDataGridProducto();
        }


        public void Carga(List<Producto> producto)
        {
            List<Producto> productosTemporarios = new List<Producto>();
            for (int i = 0; i < dvgProductos.RowCount; i++)
            {
                string tipoObjetoAux = dvgProductos.Rows[i].Cells[7].Value.ToString();
                int codigoProducto = Convert.ToInt32(dvgProductos.Rows[i].Cells[0].Value.ToString());

                foreach (var item in producto)
                {
                    if (item.Codigo == codigoProducto)
                    {
                        switch (tipoObjetoAux)
                        {
                            case "Cama":
                                productosTemporarios += new Cama(dvgProductos.Rows[i].Cells[1].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[2].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[3].Value.ToString(),
                                                            Convert.ToInt32(dvgProductos.Rows[i].Cells[4].Value),
                                                            double.Parse(dvgProductos.Rows[i].Cells[5].Value.ToString()),
                                                            double.Parse(dvgProductos.Rows[i].Cells[6].Value.ToString()),
                                                            (Entidades.Cama.ETamanio)Enum.Parse(typeof(Entidades.Cama.ETamanio), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                                break;
                            case "Juguete":
                                productosTemporarios += new Juguete(dvgProductos.Rows[i].Cells[1].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[2].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[3].Value.ToString(),
                                                            Convert.ToInt32(dvgProductos.Rows[i].Cells[4].Value),
                                                            double.Parse(dvgProductos.Rows[i].Cells[5].Value.ToString()),
                                                            double.Parse(dvgProductos.Rows[i].Cells[6].Value.ToString()),
                                                            (Entidades.Juguete.EMaterial)Enum.Parse(typeof(Entidades.Juguete.EMaterial), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                                break;
                            case "Alimento":
                                productosTemporarios += new Alimento(dvgProductos.Rows[i].Cells[1].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[2].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[3].Value.ToString(),
                                                            Convert.ToInt32(dvgProductos.Rows[i].Cells[4].Value),
                                                            double.Parse(dvgProductos.Rows[i].Cells[5].Value.ToString()),
                                                            double.Parse(dvgProductos.Rows[i].Cells[6].Value.ToString()),
                                                            (Entidades.Alimento.ETipoAlimento)Enum.Parse(typeof(Entidades.Alimento.ETipoAlimento), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                                break;
                            case "ArtCuidadoMascota":
                                productosTemporarios += new ArtCuidadoMascota(dvgProductos.Rows[i].Cells[1].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[2].Value.ToString(),
                                                            dvgProductos.Rows[i].Cells[3].Value.ToString(),
                                                            Convert.ToInt32(dvgProductos.Rows[i].Cells[4].Value),
                                                            double.Parse(dvgProductos.Rows[i].Cells[5].Value.ToString()),
                                                            double.Parse(dvgProductos.Rows[i].Cells[6].Value.ToString()),
                                                            (Entidades.ArtCuidadoMascota.ETipoCuidado)Enum.Parse(typeof(Entidades.ArtCuidadoMascota.ETipoCuidado), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                                break;
                            default:
                                break;
                        }
                        break;

                    }
                }

                PetShop.LimpiarListaProductos();
                PetShop.CargarListaNuevamenteProducto(productosTemporarios);
           
            }
         
        }



        public List<Producto> ActualizarInventario()
        {
            bool flag = true;
            string nombre;
            string marca;
            string descripcion;
            int cantidad;
            double precio;
            double kiloG;
            PetShop.LimpiarListaProductos();


            for (int m = 0; m < dvgProductos.RowCount; m++)
            {
                if (!(Validaciones.ValidateNumber((dvgProductos.Rows[m].Cells[4].Value.ToString()))))
                {
                    MessageBox.Show("Por favor ingresar correctamente el stock  con formato del numero positivo ");
                    flag = false;
                    break;
                }

                if (Validaciones.ValidarDecimal((dvgProductos.Rows[m].Cells[5].Value.ToString())))
                {
                    dvgProductos.Rows[m].Cells[5].Value = Validaciones.PuntoToComa(dvgProductos.Rows[m].Cells[5].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Por favor ingresar correctamente el precio con formato del numero positivo decimal");
                    flag = false;
                    break;
                }

                if (Validaciones.ValidarDecimal((dvgProductos.Rows[m].Cells[6].Value.ToString())))
                {
                    dvgProductos.Rows[m].Cells[6].Value = Validaciones.PuntoToComa(dvgProductos.Rows[m].Cells[6].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Por favor ingresar correctamente el Kilogramo con formato del numero positivo decimal");
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                for (int i = 0; i < dvgProductos.RowCount; i++)
                {
                    marca = dvgProductos.Rows[i].Cells[1].Value.ToString();
                    nombre = dvgProductos.Rows[i].Cells[2].Value.ToString();
                    descripcion = dvgProductos.Rows[i].Cells[3].Value.ToString();
                    cantidad = Convert.ToInt32(dvgProductos.Rows[i].Cells[4].Value.ToString());
                    precio = double.Parse(dvgProductos.Rows[i].Cells[5].Value.ToString());
                    kiloG = double.Parse(dvgProductos.Rows[i].Cells[6].Value.ToString());

                    switch (dvgProductos.Rows[i].Cells[7].Value.ToString())
                    {
                        case "Juguete":
                            PetShop.listaProductos += new Juguete(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.Juguete.EMaterial)Enum.Parse(typeof(Entidades.Juguete.EMaterial), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                            break;
                        case "Cama":
                            PetShop.listaProductos += new Cama(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.Cama.ETamanio)Enum.Parse(typeof(Entidades.Cama.ETamanio), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                            break;
                        case "Alimento":
                            PetShop.listaProductos += new Alimento(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.Alimento.ETipoAlimento)Enum.Parse(typeof(Entidades.Alimento.ETipoAlimento), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                            break;
                        case "ArtCuidadoMascota":
                            PetShop.listaProductos += new ArtCuidadoMascota(marca, nombre, descripcion, cantidad, precio, kiloG, (Entidades.ArtCuidadoMascota.ETipoCuidado)Enum.Parse(typeof(Entidades.ArtCuidadoMascota.ETipoCuidado), dvgProductos.Rows[i].Cells[8].Value.ToString()));
                            break;
                        default:
                            break;
                    }
                }

            }
            return PetShop.ObtenerPorductos();
        }




        //public static bool ValidarNumerosEnDataGrid()
        //{



        //}





        public static Object ObtenerObjetoByString(string nombre)
        {

            switch (nombre)
            {
                case "Cama":
                    Cama cama = new Cama();
                    return cama;
                    break;
                case "Juguete":
                    Juguete juguete = new Juguete();
                    return juguete;
                    break;
                case "ArtCuidadoMascota":
                    ArtCuidadoMascota articulo = new ArtCuidadoMascota();
                    return articulo;
                    break;
                case "Alimento":
                    Alimento alimento = new Alimento();
                    return alimento;
                    break;

                //Falta agregar los otros dos tipos de productos
                default:
                    break;
            }

            return null;
        }






        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dvgProductos.DataSource = null;
            List<Producto> lista = new List<Producto>();
            lista = PetShop.ObtenerPorductos();
            int aux;
            foreach (DataGridViewCell oneCell in dvgProductos.SelectedCells)
            {
                aux = Convert.ToInt32(dvgProductos.Rows[dvgProductos.CurrentCell.RowIndex].Cells[0].Value.ToString());
                if (dvgProductos.SelectedCells.Count < 2)
                {
                    if (oneCell.Selected)
                    {
                        foreach (var item in lista)
                        {
                            if (item.Codigo == aux)
                            {
                                DialogResult dr = MessageBox.Show($"Esta seguro de eliminar el Producto\n {item.Nombre.ToString()}?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr != DialogResult.No)
                                {
                                    PetShop.EliminarProducto(item);
                                    dvgProductos.DataSource = null;
                                    this.CargarDataGridProducto();
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede seleccionar mas de una celda");
                    break;
                }
            }
        }

        private void dvgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgProductos.AllowUserToDeleteRows = false;
            dvgProductos.AllowUserToAddRows = false;
            btnCancelarModificacion.Enabled = true;
            btnEliminar.Enabled = true;
        }


        private void dvgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgProductos.AllowUserToDeleteRows = false;
            dvgProductos.AllowUserToAddRows = false;
            btnCancelarModificacion.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void dvgProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dvgProductos.AllowUserToDeleteRows = false;
            dvgProductos.AllowUserToAddRows = false;
            btnCancelarModificacion.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            CargarDataGridProducto();
        }

        private void dvgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelarModificacion.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
