
namespace PetShopApp
{
    partial class FrmAltaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCanelar = new System.Windows.Forms.Button();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.cmbTipoProd = new System.Windows.Forms.ComboBox();
            this.lblDetalleTipoProd = new System.Windows.Forms.Label();
            this.cmbDetalleTipoProd = new System.Windows.Forms.ComboBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblValidMarca = new System.Windows.Forms.Label();
            this.lblValidNombre = new System.Windows.Forms.Label();
            this.lblValidDescrip = new System.Windows.Forms.Label();
            this.lblValidStock = new System.Windows.Forms.Label();
            this.lblValidPrecio = new System.Windows.Forms.Label();
            this.lblValidKg = new System.Windows.Forms.Label();
            this.lblValidTipoProd = new System.Windows.Forms.Label();
            this.lblValidDetalleProd = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(67, 64);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(38, 138);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(69, 15);
            this.lblDescrip.TabIndex = 2;
            this.lblDescrip.Text = "Descripcion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(71, 178);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(67, 222);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(67, 267);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(40, 15);
            this.lblKg.TabIndex = 5;
            this.lblKg.Text = "Kg./U.";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(113, 61);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(165, 23);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            this.txtMarca.MouseHover += new System.EventHandler(this.txtMarca_MouseHover);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            this.txtNombre.MouseHover += new System.EventHandler(this.txtNombre_MouseHover);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(113, 135);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(165, 23);
            this.txtDescrip.TabIndex = 3;
            this.txtDescrip.Leave += new System.EventHandler(this.txtDescrip_Leave);
            this.txtDescrip.MouseHover += new System.EventHandler(this.txtDescrip_MouseHover);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(113, 175);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(165, 23);
            this.txtStock.TabIndex = 4;
            this.txtStock.Leave += new System.EventHandler(this.txtStock_Leave);
            this.txtStock.MouseHover += new System.EventHandler(this.txtStock_MouseHover);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(113, 218);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(165, 23);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            this.txtPrecio.MouseHover += new System.EventHandler(this.txtPrecio_MouseHover);
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(113, 260);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(165, 23);
            this.txtKg.TabIndex = 6;
            this.txtKg.Leave += new System.EventHandler(this.txtKg_Leave);
            this.txtKg.MouseHover += new System.EventHandler(this.txtKg_MouseHover);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(5, 407);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 64);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCanelar
            // 
            this.btnCanelar.Location = new System.Drawing.Point(143, 407);
            this.btnCanelar.Name = "btnCanelar";
            this.btnCanelar.Size = new System.Drawing.Size(124, 64);
            this.btnCanelar.TabIndex = 10;
            this.btnCanelar.Text = "Cancelar";
            this.btnCanelar.UseVisualStyleBackColor = true;
            this.btnCanelar.Click += new System.EventHandler(this.btnCanelar_Click);
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Location = new System.Drawing.Point(25, 305);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(82, 15);
            this.lblTipoProd.TabIndex = 14;
            this.lblTipoProd.Text = "Tipo Producto";
            // 
            // cmbTipoProd
            // 
            this.cmbTipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProd.FormattingEnabled = true;
            this.cmbTipoProd.Items.AddRange(new object[] {
            "Alimento",
            "Art. Cuidado Mascota",
            "Cama",
            "Juguete"});
            this.cmbTipoProd.Location = new System.Drawing.Point(113, 297);
            this.cmbTipoProd.Name = "cmbTipoProd";
            this.cmbTipoProd.Size = new System.Drawing.Size(165, 23);
            this.cmbTipoProd.TabIndex = 7;
            this.cmbTipoProd.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProd_SelectedIndexChanged);
            this.cmbTipoProd.SelectedValueChanged += new System.EventHandler(this.cmbTipoProd_SelectedValueChanged);
            this.cmbTipoProd.MouseHover += new System.EventHandler(this.cmbTipoProd_MouseHover);
            // 
            // lblDetalleTipoProd
            // 
            this.lblDetalleTipoProd.AutoSize = true;
            this.lblDetalleTipoProd.Location = new System.Drawing.Point(9, 347);
            this.lblDetalleTipoProd.Name = "lblDetalleTipoProd";
            this.lblDetalleTipoProd.Size = new System.Drawing.Size(98, 15);
            this.lblDetalleTipoProd.TabIndex = 16;
            this.lblDetalleTipoProd.Text = "Detalle  Producto";
            // 
            // cmbDetalleTipoProd
            // 
            this.cmbDetalleTipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetalleTipoProd.FormattingEnabled = true;
            this.cmbDetalleTipoProd.Location = new System.Drawing.Point(113, 340);
            this.cmbDetalleTipoProd.Name = "cmbDetalleTipoProd";
            this.cmbDetalleTipoProd.Size = new System.Drawing.Size(165, 23);
            this.cmbDetalleTipoProd.TabIndex = 8;
            this.cmbDetalleTipoProd.SelectedValueChanged += new System.EventHandler(this.cmbDetalleTipoProd_SelectedValueChanged);
            this.cmbDetalleTipoProd.MouseLeave += new System.EventHandler(this.cmbDetalleTipoProd_MouseLeave);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(38, 15);
            this.lblMensaje.TabIndex = 18;
            this.lblMensaje.Text = "label1";
            // 
            // lblValidMarca
            // 
            this.lblValidMarca.AutoSize = true;
            this.lblValidMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidMarca.ForeColor = System.Drawing.Color.Red;
            this.lblValidMarca.Location = new System.Drawing.Point(284, 64);
            this.lblValidMarca.Name = "lblValidMarca";
            this.lblValidMarca.Size = new System.Drawing.Size(17, 21);
            this.lblValidMarca.TabIndex = 19;
            this.lblValidMarca.Text = "*";
            // 
            // lblValidNombre
            // 
            this.lblValidNombre.AutoSize = true;
            this.lblValidNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidNombre.Location = new System.Drawing.Point(284, 100);
            this.lblValidNombre.Name = "lblValidNombre";
            this.lblValidNombre.Size = new System.Drawing.Size(17, 21);
            this.lblValidNombre.TabIndex = 20;
            this.lblValidNombre.Text = "*";
            // 
            // lblValidDescrip
            // 
            this.lblValidDescrip.AutoSize = true;
            this.lblValidDescrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidDescrip.ForeColor = System.Drawing.Color.Red;
            this.lblValidDescrip.Location = new System.Drawing.Point(284, 138);
            this.lblValidDescrip.Name = "lblValidDescrip";
            this.lblValidDescrip.Size = new System.Drawing.Size(17, 21);
            this.lblValidDescrip.TabIndex = 21;
            this.lblValidDescrip.Text = "*";
            // 
            // lblValidStock
            // 
            this.lblValidStock.AutoSize = true;
            this.lblValidStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidStock.ForeColor = System.Drawing.Color.Red;
            this.lblValidStock.Location = new System.Drawing.Point(284, 178);
            this.lblValidStock.Name = "lblValidStock";
            this.lblValidStock.Size = new System.Drawing.Size(17, 21);
            this.lblValidStock.TabIndex = 22;
            this.lblValidStock.Text = "*";
            // 
            // lblValidPrecio
            // 
            this.lblValidPrecio.AutoSize = true;
            this.lblValidPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblValidPrecio.Location = new System.Drawing.Point(284, 216);
            this.lblValidPrecio.Name = "lblValidPrecio";
            this.lblValidPrecio.Size = new System.Drawing.Size(17, 21);
            this.lblValidPrecio.TabIndex = 23;
            this.lblValidPrecio.Text = "*";
            // 
            // lblValidKg
            // 
            this.lblValidKg.AutoSize = true;
            this.lblValidKg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidKg.ForeColor = System.Drawing.Color.Red;
            this.lblValidKg.Location = new System.Drawing.Point(284, 262);
            this.lblValidKg.Name = "lblValidKg";
            this.lblValidKg.Size = new System.Drawing.Size(17, 21);
            this.lblValidKg.TabIndex = 24;
            this.lblValidKg.Text = "*";
            // 
            // lblValidTipoProd
            // 
            this.lblValidTipoProd.AutoSize = true;
            this.lblValidTipoProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidTipoProd.ForeColor = System.Drawing.Color.Red;
            this.lblValidTipoProd.Location = new System.Drawing.Point(284, 300);
            this.lblValidTipoProd.Name = "lblValidTipoProd";
            this.lblValidTipoProd.Size = new System.Drawing.Size(17, 21);
            this.lblValidTipoProd.TabIndex = 25;
            this.lblValidTipoProd.Text = "*";
            // 
            // lblValidDetalleProd
            // 
            this.lblValidDetalleProd.AutoSize = true;
            this.lblValidDetalleProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidDetalleProd.ForeColor = System.Drawing.Color.Red;
            this.lblValidDetalleProd.Location = new System.Drawing.Point(284, 342);
            this.lblValidDetalleProd.Name = "lblValidDetalleProd";
            this.lblValidDetalleProd.Size = new System.Drawing.Size(17, 21);
            this.lblValidDetalleProd.TabIndex = 26;
            this.lblValidDetalleProd.Text = "*";
            // 
            // FrmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 483);
            this.Controls.Add(this.lblValidDetalleProd);
            this.Controls.Add(this.lblValidTipoProd);
            this.Controls.Add(this.lblValidKg);
            this.Controls.Add(this.lblValidPrecio);
            this.Controls.Add(this.lblValidStock);
            this.Controls.Add(this.lblValidDescrip);
            this.Controls.Add(this.lblValidNombre);
            this.Controls.Add(this.lblValidMarca);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cmbDetalleTipoProd);
            this.Controls.Add(this.lblDetalleTipoProd);
            this.Controls.Add(this.cmbTipoProd);
            this.Controls.Add(this.lblTipoProd);
            this.Controls.Add(this.btnCanelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMarca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCanelar;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.ComboBox cmbTipoProd;
        private System.Windows.Forms.Label lblDetalleTipoProd;
        private System.Windows.Forms.ComboBox cmbDetalleTipoProd;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblValidMarca;
        private System.Windows.Forms.Label lblValidNombre;
        private System.Windows.Forms.Label lblValidDescrip;
        private System.Windows.Forms.Label lblValidStock;
        private System.Windows.Forms.Label lblValidPrecio;
        private System.Windows.Forms.Label lblValidKg;
        private System.Windows.Forms.Label lblValidTipoProd;
        private System.Windows.Forms.Label lblValidDetalleProd;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}