using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace PetShopApp
{
    public partial class FormFactura : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        Venta venta;


        /// <summary>
        /// Constructor sin parámetros de la clase FormFactura.
        /// </summary>
        public FormFactura()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Constructor con parámetros de la clase FormFactura.
        /// </summary>
        /// <param name="venta"></param>
        public FormFactura(Venta venta) : this()
        {
            rtxTicket.Enabled = false;
            this.venta = venta;
            ImprimirPorPantalla();
        }


        /// <summary>
        /// Genera en un string el formato deseado de una cadena de elementos
        /// </summary>
        private void ImprimirPorPantalla()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------Pet Shop------------------");
            sb.AppendLine("                    'El Pikachu Juan'             ");
            sb.AppendLine("           By Nicolas Ezequiel Letticugna       ");
            sb.AppendLine("       Av. Gral. Chamizo y Donovan - Gerli      ");
            sb.AppendLine("         Tel. 0800-2020-2020 (op. 3)            ");
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine(MostrarFecha());
            sb.Append(venta.ToString());
            rtxTicket.Text = sb.ToString();
        }


        /// <summary>
        /// Muestra fecha en una cadena de string
        /// </summary>
        /// <returns></returns>
        private string MostrarFecha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Factura N°  {FormatoNroFactura()}       " + DateTime.Today.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss"));
            return sb.ToString();
        }


        /// <summary>
        /// Le da formato al numero de la factura para que se puede imprimir con este formato Factura "0005"
        /// </summary>
        /// <returns>Devuelve el numero de factura con un formato particular</returns>
        private string FormatoNroFactura()
        {
            const int MaxLength = 5;
            int aux;
            string numeroFactura = (venta.NumeroFactura).ToString();
            aux = MaxLength - numeroFactura.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < aux; i++)
            {
                sb.Append("0");
            }
            sb.Append($"{ numeroFactura}");
            return sb.ToString();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        /// <summary>
        /// Genera un Txt con un formato en el nombre de alrchivo que esta configurado de la siguiente manera "Factura Nro_00005_16-10-2021"
        /// </summary>
        private void ImprimirEnTxt()
        {
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            saveFileDialog1.FileName = "Factura Nro_" + FormatoNroFactura() + "_" + DateTime.Today.ToString("dd-MM-yyyy");
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter tesxtoAGuardar = File.CreateText(txt);
                        tesxtoAGuardar.WriteLine(rtxTicket.Text);
                        tesxtoAGuardar.Close();
                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter tesxtoAGuardar = File.CreateText(txt);
                        tesxtoAGuardar.WriteLine(rtxTicket.Text);
                        tesxtoAGuardar.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirEnTxt();
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
        /// Setea el color a los objetos en negro
        /// </summary>
        private void ApagarDarkMode()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            rtxTicket.BackColor = this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            lblBlackTheme.Text = "Vision Black";
            rtxTicket.BackColor = Color.Black;
        }


        private void FormFactura_Load(object sender, EventArgs e)
        {
            if (ManejadorDeForms.DarkMode)
            {
                ApagarDarkMode();
            }
        }


        private void lblBlackTheme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManejadorDeForms.DarkMode = !ManejadorDeForms.DarkMode;

            if (ManejadorDeForms.DarkMode)
            {
                this.BackColor = Color.Black;
                rtxTicket.BackColor = Color.Black;
                lblBlackTheme.Text = "Vision White";
                rtxTicket.BackColor = Color.White;
            }
            else
            {
                ApagarDarkMode();
            }
        }

    }
}
