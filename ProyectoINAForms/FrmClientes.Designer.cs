namespace ProyectoINAForms
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.numDesc = new System.Windows.Forms.NumericUpDown();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cboTipoCli = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFoto = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbTipoCli = new System.Windows.Forms.Label();
            this.lbFechaNa = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbApe2 = new System.Windows.Forms.Label();
            this.lbApe1 = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.numDesc);
            this.gbxCliente.Controls.Add(this.pcbFoto);
            this.gbxCliente.Controls.Add(this.dtFechaNac);
            this.gbxCliente.Controls.Add(this.cboTipoCli);
            this.gbxCliente.Controls.Add(this.cboGenero);
            this.gbxCliente.Controls.Add(this.txtApe1);
            this.gbxCliente.Controls.Add(this.txtApe2);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.lbFoto);
            this.gbxCliente.Controls.Add(this.lbDesc);
            this.gbxCliente.Controls.Add(this.lbTipoCli);
            this.gbxCliente.Controls.Add(this.lbFechaNa);
            this.gbxCliente.Controls.Add(this.lbGenero);
            this.gbxCliente.Controls.Add(this.lbApe2);
            this.gbxCliente.Controls.Add(this.lbApe1);
            this.gbxCliente.Controls.Add(this.lbNom);
            this.gbxCliente.Controls.Add(this.lbNombre);
            this.gbxCliente.Controls.Add(this.mskCedula);
            this.gbxCliente.Location = new System.Drawing.Point(12, 68);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(410, 520);
            this.gbxCliente.TabIndex = 0;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos de cliente";
            this.gbxCliente.Enter += new System.EventHandler(this.gbxCliente_Enter);
            // 
            // numDesc
            // 
            this.numDesc.Location = new System.Drawing.Point(161, 386);
            this.numDesc.Name = "numDesc";
            this.numDesc.Size = new System.Drawing.Size(159, 20);
            this.numDesc.TabIndex = 22;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(161, 434);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(159, 59);
            this.pcbFoto.TabIndex = 21;
            this.pcbFoto.TabStop = false;
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(161, 296);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(159, 20);
            this.dtFechaNac.TabIndex = 20;
            // 
            // cboTipoCli
            // 
            this.cboTipoCli.FormattingEnabled = true;
            this.cboTipoCli.Location = new System.Drawing.Point(161, 339);
            this.cboTipoCli.Name = "cboTipoCli";
            this.cboTipoCli.Size = new System.Drawing.Size(159, 21);
            this.cboTipoCli.TabIndex = 19;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Maculino",
            "Femenino",
            "Payaso"});
            this.cboGenero.Location = new System.Drawing.Point(161, 247);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(159, 21);
            this.cboGenero.TabIndex = 18;
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(161, 158);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(159, 20);
            this.txtApe1.TabIndex = 14;
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(161, 197);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(159, 20);
            this.txtApe2.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(112, 434);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(28, 13);
            this.lbFoto.TabIndex = 9;
            this.lbFoto.Text = "Foto";
            this.lbFoto.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(81, 388);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(59, 13);
            this.lbDesc.TabIndex = 8;
            this.lbDesc.Text = "Descuento";
            // 
            // lbTipoCli
            // 
            this.lbTipoCli.AutoSize = true;
            this.lbTipoCli.Location = new System.Drawing.Point(77, 342);
            this.lbTipoCli.Name = "lbTipoCli";
            this.lbTipoCli.Size = new System.Drawing.Size(63, 13);
            this.lbTipoCli.TabIndex = 7;
            this.lbTipoCli.Text = "Tipo Cliente";
            // 
            // lbFechaNa
            // 
            this.lbFechaNa.AutoSize = true;
            this.lbFechaNa.Location = new System.Drawing.Point(47, 296);
            this.lbFechaNa.Name = "lbFechaNa";
            this.lbFechaNa.Size = new System.Drawing.Size(93, 13);
            this.lbFechaNa.TabIndex = 6;
            this.lbFechaNa.Text = "Fecha Nacimiento";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(98, 250);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(42, 13);
            this.lbGenero.TabIndex = 5;
            this.lbGenero.Text = "Genero";
            // 
            // lbApe2
            // 
            this.lbApe2.AutoSize = true;
            this.lbApe2.Location = new System.Drawing.Point(50, 204);
            this.lbApe2.Name = "lbApe2";
            this.lbApe2.Size = new System.Drawing.Size(90, 13);
            this.lbApe2.TabIndex = 4;
            this.lbApe2.Text = "Segundo Apellido";
            // 
            // lbApe1
            // 
            this.lbApe1.AutoSize = true;
            this.lbApe1.Location = new System.Drawing.Point(64, 158);
            this.lbApe1.Name = "lbApe1";
            this.lbApe1.Size = new System.Drawing.Size(76, 13);
            this.lbApe1.TabIndex = 3;
            this.lbApe1.Text = "Primer Apellido";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(96, 112);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(44, 13);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nombre";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(100, 66);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(40, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Cédula";
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(161, 59);
            this.mskCedula.Mask = "#-####-####";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(159, 20);
            this.mskCedula.TabIndex = 0;
            this.mskCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(115, 594);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 74);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(256, 594);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 74);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(150, 26);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(151, 25);
            this.lbTitulo.TabIndex = 23;
            this.lbTitulo.Text = "Crear Cliente";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(437, 710);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        public System.Windows.Forms.Label lbFoto;
        public System.Windows.Forms.Label lbDesc;
        public System.Windows.Forms.Label lbTipoCli;
        public System.Windows.Forms.Label lbFechaNa;
        public System.Windows.Forms.Label lbGenero;
        public System.Windows.Forms.Label lbApe2;
        public System.Windows.Forms.Label lbApe1;
        public System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.NumericUpDown numDesc;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.ComboBox cboTipoCli;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbTitulo;
    }
}