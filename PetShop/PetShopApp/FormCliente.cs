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
    public partial class frmCliente : Form
    {
        Usuario userForm;
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public frmCliente()
        {
            InitializeComponent();
        }

        public frmCliente(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            CargarDataGrid();
        }


        /// <summary>
        /// Recarga el datagrid
        /// </summary>
        public void CargarDataGrid()
        {
            dvgListaClientes.Refresh();
            dvgListaClientes.DataSource = null;
            int i = 0;

            dvgListaClientes.RowCount = PetShop.ObtenerListaCliente().Count;
            foreach (var item in PetShop.ObtenerListaCliente())
            {
                dvgListaClientes.Rows[i].Cells[0].Value = item.IdCliente;
                dvgListaClientes.Rows[i].Cells[0].ReadOnly = true;
                dvgListaClientes.Rows[i].Cells[1].Value = item.Cuit;
                dvgListaClientes.Rows[i].Cells[2].Value = item.Nombre;
                dvgListaClientes.Rows[i].Cells[3].Value = item.Apellido;
                i++;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!(txtBuscar.Text == ""))
            {
                pnlMenuIzquierdo.Enabled = false;
                dvgListaClientes.Rows.Clear();
                dvgListaClientes.DataSource = null;
                List<Cliente> lista = new List<Cliente>();
                lista = PetShop.ObtenerListaCliente();
                foreach (var item in lista)
                {
                    if (PetShop.BuscarClientePorString(item, txtBuscar.Text.ToLower()))
                    {
                        dvgListaClientes.Rows.Add(item.IdCliente, item.Cuit, item.Nombre, item.Apellido);
                        MakeReadOnly();
                    }
                }
            }
            else
            {
                pnlMenuIzquierdo.Enabled = true;
                dvgListaClientes.Rows.Clear();
                dvgListaClientes.DataSource = null;
                List<Cliente> lista = new List<Cliente>();
                lista = PetShop.ObtenerListaCliente();
                foreach (var item in lista)
                {
                    if (PetShop.BuscarClientePorString(item, txtBuscar.Text.ToLower()))
                    {
                        dvgListaClientes.Rows.Add(item.IdCliente, item.Cuit, item.Nombre, item.Apellido);
                        dvgListaClientes.AllowUserToAddRows = false;
                        dvgListaClientes.AllowUserToDeleteRows = false;
                        dvgListaClientes.ReadOnly = false;
                    }
                }
            }

        }

        private void MakeReadOnly()
        {
            dvgListaClientes.AllowUserToAddRows = false;
            dvgListaClientes.AllowUserToDeleteRows = false;
            dvgListaClientes.ReadOnly = true;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            FormAltaCliente cliente = new FormAltaCliente(this.userForm);
            cliente.ShowDialog();
            this.CargarDataGrid();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int m = 0; m < dvgListaClientes.RowCount; m++)
            {
                if (!(Validaciones.ValidateNumberCuit(dvgListaClientes.Rows[m].Cells[1].Value.ToString())))
                {
                    MessageBox.Show("Por favor ingresar correctamente un numero de cuit valido");
                    flag = false;
                    CargarDataGrid();
                    break;
                }
            }


            if (flag)
            {
            List<Cliente> auxList = new List<Cliente>();
            PetShop.LimpiarListaClientes();

            string cuit;
            string nombre;
            string apellido;


            for (int i = 0; i < dvgListaClientes.RowCount; i++)
            {

                cuit = dvgListaClientes.Rows[i].Cells[1].Value.ToString();
                nombre = dvgListaClientes.Rows[i].Cells[2].Value.ToString();
                apellido = dvgListaClientes.Rows[i].Cells[3].Value.ToString();
                Cliente cliente = new Cliente(cuit, nombre, apellido, 0);
                auxList.Add(cliente);

                PetShop.CargarListaNuevamenteClientes(auxList);
            }
            btnCancelarMoficiacion.Enabled = false;

            }

        }

        private void btnCancelarMoficiacion_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void dvgListaClientes_DoubleClick(object sender, EventArgs e)
        {
            btnCancelarMoficiacion.Enabled = true;
        }

        private void dvgListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgListaClientes.AllowUserToDeleteRows = false;
            dvgListaClientes.AllowUserToAddRows = false;
        }

        private void dvgListaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgListaClientes.AllowUserToDeleteRows = false;
            dvgListaClientes.AllowUserToAddRows = false;
        }

        private void dvgListaClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dvgListaClientes.AllowUserToDeleteRows = false;
            dvgListaClientes.AllowUserToAddRows = false;
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
