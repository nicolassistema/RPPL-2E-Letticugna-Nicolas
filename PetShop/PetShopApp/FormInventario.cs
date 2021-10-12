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
                i++;
            }
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


    }
}
