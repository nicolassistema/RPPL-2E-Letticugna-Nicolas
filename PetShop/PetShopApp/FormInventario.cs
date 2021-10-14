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
    public partial class frmInventario : Form
    {
        Usuario userForm;

        public frmInventario()
        {
            InitializeComponent();
        }

        public frmInventario(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            CargarDataGridProducto();
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
            aux = aux.Substring(aux.IndexOf(".")+1);
            return aux;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dvgProductos.Rows.Clear();
            dvgProductos.DataSource = null;
            List<Producto> lista = new List<Producto>();
            lista = PetShop.ObtenerPorductos();
            foreach (var item in lista)
            {
                if (PetShop.BuscarProductoPorString(item, txtBuscar.Text.ToLower()))
                {
                    dvgProductos.Rows.Add(item.Codigo, item.Marca, item.Nombre, item.Descripcion, item.Cantidad, item.Precio, item.Kilogramos);
                    MakeReadOnly();
                }
            }
        }

        private void MakeReadOnly()
        {
            dvgProductos.AllowUserToAddRows = false;
            dvgProductos.AllowUserToDeleteRows = false;
            dvgProductos.ReadOnly = true;
        }

        private void bntAlta_Click(object sender, EventArgs e)
        {
            FrmAltaProducto producto = new FrmAltaProducto(this.userForm);
            producto.ShowDialog();

        }

        private void btnConfirmModificacion_Click(object sender, EventArgs e)
        {
            //List<Producto> producto = new List<Producto>();
            //for (int i = 0; i < dvgProductos.RowCount; i++)
            //{
            //    string aux = dvgProductos.Rows[i].Cells[5].Value.ToString();
            //    string codigoProducto = dvgProductos.Rows[i].Cells[0].Value.ToString();

            //    //if (userForm.Cuit == cuitAux)
            //    //{
            //    //    lblNombreUsuario.Text = dgvListaEmpleados.Rows[i].Cells[1].Value.ToString() + " " + dgvListaEmpleados.Rows[i].Cells[2].Value.ToString();
            //    //    userForm.Nombre = dgvListaEmpleados.Rows[i].Cells[1].Value.ToString();
            //    //    userForm.Apellido = dgvListaEmpleados.Rows[i].Cells[2].Value.ToString();
            //    //    userForm.NameUsuario = dgvListaEmpleados.Rows[i].Cells[3].Value.ToString();
            //    //    userForm.PassUsuario = dgvListaEmpleados.Rows[i].Cells[4].Value.ToString();
            //    //}




            //   // PetShop.ObtenerPorductos();



            //    Usuario usuario = new Usuario(dvgProductos.Rows[i].Cells[0].Value.ToString(),
            //                                                dvgProductos.Rows[i].Cells[1].Value.ToString(),
            //                                                dvgProductos.Rows[i].Cells[2].Value.ToString(),
            //                                                dvgProductos.Rows[i].Cells[3].Value.ToString(),
            //                                                dvgProductos.Rows[i].Cells[4].Value.ToString(),
            //                                                 dvgProductos.Rows[i].Cells[5].Value.ToString(),
            //                                                  dvgProductos.Rows[i].Cells[6].Value.ToString(),
            //                                                   dvgProductos.Rows[i].Cells[7].Value.ToString(),
            //                                                    dvgProductos.Rows[i].Cells[8].Value.ToString(),
            //                                                Entidades.Usuario.EPerfilUsuario.Admin);




            //    if (Entidades.Usuario.EPerfilUsuario.Admin.ToString() == aux)
            //    {
            //        Usuario usuario = new Usuario(dgvListaEmpleados.Rows[i].Cells[0].Value.ToString(),
            //                                                 dgvListaEmpleados.Rows[i].Cells[1].Value.ToString(),
            //                                                 dgvListaEmpleados.Rows[i].Cells[2].Value.ToString(),
            //                                                 dgvListaEmpleados.Rows[i].Cells[3].Value.ToString(),
            //                                                 dgvListaEmpleados.Rows[i].Cells[4].Value.ToString(),
            //                                                 Entidades.Usuario.EPerfilUsuario.Admin);
            //        auxList.Add(usuario);
            //    }
            //    else
            //    {
            //        Usuario usuario = new Usuario(dgvListaEmpleados.Rows[i].Cells[0].Value.ToString(),
            //                                                dgvListaEmpleados.Rows[i].Cells[1].Value.ToString(),
            //                                                dgvListaEmpleados.Rows[i].Cells[2].Value.ToString(),
            //                                                dgvListaEmpleados.Rows[i].Cells[3].Value.ToString(),
            //                                                dgvListaEmpleados.Rows[i].Cells[4].Value.ToString(),
            //                                                Entidades.Usuario.EPerfilUsuario.Empleado);

            //        auxList.Add(usuario);
            //    }
            //    PetShop.LimpiarListaUsarios();
            //    PetShop.CargarListaNuevamente(auxList);
            //}
        }





    }
}
