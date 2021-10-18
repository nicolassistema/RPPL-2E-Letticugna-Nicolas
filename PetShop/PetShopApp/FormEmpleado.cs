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
    public partial class FormEmpleado : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        Usuario userForm;

        public FormEmpleado()
        {
            InitializeComponent();
        }


        public FormEmpleado(Usuario usuario) : this()
        {
            this.userForm = usuario;
            lblNombreUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
            CargarDataGrid();
        }


        private void CargarDataGrid()
        {
            dgvListaEmpleados.Refresh();
            dgvListaEmpleados.DataSource = null;

            int i = 0;
            dgvListaEmpleados.RowCount = PetShop.ObtenerListaUsuarios().Count;

            foreach (var item in PetShop.ObtenerListaUsuarios())
            {
                if (item.Key == userForm.Cuit.ToString())
                {
                    dgvListaEmpleados.Rows[i].Cells[0].Value = item.Key;
                    dgvListaEmpleados.Rows[i].Cells[0].ReadOnly = true;
                    dgvListaEmpleados.Rows[i].Cells[5].ReadOnly = true;
                }
                else
                {
                    dgvListaEmpleados.Rows[i].Cells[0].Value = item.Key;
                }
                dgvListaEmpleados.Rows[i].Cells[1].Value = item.Value.Nombre;
                dgvListaEmpleados.Rows[i].Cells[2].Value = item.Value.Apellido;
                dgvListaEmpleados.Rows[i].Cells[3].Value = item.Value.NameUsuario;
                dgvListaEmpleados.Rows[i].Cells[4].Value = item.Value.PassUsuario;

                if (item.Value.PerfilUsuario == Entidades.Usuario.EPerfilUsuario.Admin)
                {
                    dgvListaEmpleados.Rows[i].Cells[5].Value = "Admin";
                }
                else
                {
                    dgvListaEmpleados.Rows[i].Cells[5].Value = "Empleado";
                }
                i++;
            }
        }

        public void RefrescarForm()
        {
            FormEmpleado form = new FormEmpleado();
            form.Refresh();
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
                pnlMenuIzquiedo.Enabled = false;
                dgvListaEmpleados.Rows.Clear();
                Dictionary<string, Usuario> lista = new Dictionary<string, Usuario>();
                lista = PetShop.ObtenerListaUsuarios();
                string aux;
                foreach (var item in lista)
                {
                    if (BuscarPorString(item.Value, txtBuscar.Text.ToLower()))
                    {
                        if (item.Value.PerfilUsuario == Entidades.Usuario.EPerfilUsuario.Admin)
                        {
                            aux = "Admin";
                        }
                        else
                        {
                            aux = "Empleado";
                        }
                        dgvListaEmpleados.Rows.Add(item.Value.Cuit, item.Value.Nombre, item.Value.Apellido, item.Value.NameUsuario, item.Value.PassUsuario, aux);
                        MakeReadOnly();
                    }
                }
            }
            else
            {
                pnlMenuIzquiedo.Enabled = true;
                dgvListaEmpleados.Rows.Clear();
                Dictionary<string, Usuario> lista = new Dictionary<string, Usuario>();
                lista = PetShop.ObtenerListaUsuarios();
                string aux;
                foreach (var item in lista)
                {
                    if (BuscarPorString(item.Value, txtBuscar.Text.ToLower()))
                    {
                        if (item.Value.PerfilUsuario == Entidades.Usuario.EPerfilUsuario.Admin)
                        {
                            aux = "Admin";
                        }
                        else
                        {
                            aux = "Empleado";
                        }
                        dgvListaEmpleados.Rows.Add(item.Value.Cuit, item.Value.Nombre, item.Value.Apellido, item.Value.NameUsuario, item.Value.PassUsuario, aux);
                        MakeReadOnly();
                        dgvListaEmpleados.ReadOnly = false;
                    }
                }
            }



        }

        private void MakeReadOnly()
        {
            dgvListaEmpleados.AllowUserToAddRows = false;
            dgvListaEmpleados.AllowUserToDeleteRows = false;
            dgvListaEmpleados.ReadOnly = true;
        }

        /// <summary>
        /// Buscar en todos los elementos del objeto palabras que contenga lo que se busca
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="palabra"></param>
        /// <returns>devuelve true si encuentre y false sino</returns>
        public bool BuscarPorString(Usuario usuario, string palabra)
        {
            if (
                usuario.Cuit.ToLower().Contains(palabra) ||
                usuario.Nombre.ToLower().Contains(palabra) ||
                usuario.Apellido.ToLower().Contains(palabra) ||
                usuario.NameUsuario.ToLower().Contains(palabra) ||
                usuario.PassUsuario.ToLower().Contains(palabra) ||
                usuario.PerfilUsuario.ToString().ToLower().Contains(palabra)
                )
            {
                return true;
            }
            return false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            dgvListaEmpleados.Enabled = true;

            frmAltaEmpleado empleado = new frmAltaEmpleado(this.userForm);
            empleado.ShowDialog();
            this.CargarDataGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvListaEmpleados.DataSource = null;
            Dictionary<string, Usuario> lista = new Dictionary<string, Usuario>();
            lista = PetShop.ObtenerListaUsuarios();
            string aux;
            foreach (DataGridViewCell oneCell in dgvListaEmpleados.SelectedCells)
            {
                aux = dgvListaEmpleados.Rows[dgvListaEmpleados.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (userForm.Cuit != aux)
                {
                    if (dgvListaEmpleados.SelectedCells.Count < 2)
                    {
                        if (oneCell.Selected)
                        {
                            foreach (var item in lista)
                            {
                                if (item.Key == aux)
                                {
                                    DialogResult dr = MessageBox.Show($"Esta seguro de eliminar el usuario\n {item.ToString()}?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dr != DialogResult.No)
                                    {
                                        PetShop.EliminarUsuario(item.Value);
                                        dgvListaEmpleados.DataSource = null;
                                        this.CargarDataGrid();
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
                else
                {
                    MessageBox.Show("No se puede borrar el usuario que esta loguado actualmente");
                    break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Dictionary<string, Usuario> auxList = new Dictionary<string, Usuario>();
            for (int i = 0; i < dgvListaEmpleados.RowCount; i++)
            {
                string aux = dgvListaEmpleados.Rows[i].Cells[5].Value.ToString();
                string cuitAux = dgvListaEmpleados.Rows[i].Cells[0].Value.ToString();

                if (userForm.Cuit == cuitAux)
                {
                    lblNombreUsuario.Text = dgvListaEmpleados.Rows[i].Cells[1].Value.ToString() + " " + dgvListaEmpleados.Rows[i].Cells[2].Value.ToString();
                    userForm.Nombre = dgvListaEmpleados.Rows[i].Cells[1].Value.ToString();
                    userForm.Apellido = dgvListaEmpleados.Rows[i].Cells[2].Value.ToString();
                    userForm.NameUsuario = dgvListaEmpleados.Rows[i].Cells[3].Value.ToString();
                    userForm.PassUsuario = dgvListaEmpleados.Rows[i].Cells[4].Value.ToString();
                }

                if (Entidades.Usuario.EPerfilUsuario.Admin.ToString() == aux)
                {
                    Usuario usuario = new Usuario(dgvListaEmpleados.Rows[i].Cells[0].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[1].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[2].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[3].Value.ToString(),
                                                             dgvListaEmpleados.Rows[i].Cells[4].Value.ToString(),
                                                             Entidades.Usuario.EPerfilUsuario.Admin);
                    auxList.Add(usuario.Cuit, usuario);
                }
                else
                {
                    Usuario usuario = new Usuario(dgvListaEmpleados.Rows[i].Cells[0].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[1].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[2].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[3].Value.ToString(),
                                                            dgvListaEmpleados.Rows[i].Cells[4].Value.ToString(),
                                                            Entidades.Usuario.EPerfilUsuario.Empleado);

                    auxList.Add(usuario.Cuit, usuario);
                }
                PetShop.LimpiarListaUsarios();
                PetShop.CargarListaNuevamente(auxList);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void dgvListaEmpleados_DoubleClick(object sender, EventArgs e)
        {
            dgvListaEmpleados.AllowUserToDeleteRows = false;
            dgvListaEmpleados.AllowUserToAddRows = false;
        }

        private void dgvListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaEmpleados.AllowUserToDeleteRows = false;
            dgvListaEmpleados.AllowUserToAddRows = false;
        }

        private void dgvListaEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaEmpleados.AllowUserToDeleteRows = false;
            dgvListaEmpleados.AllowUserToAddRows = false;
        }

        private void dgvListaEmpleados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaEmpleados.AllowUserToDeleteRows = false;
            dgvListaEmpleados.AllowUserToAddRows = false;
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






















