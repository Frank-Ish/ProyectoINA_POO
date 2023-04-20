namespace ProyectoINAForms
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFechaIng = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.gbxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(333, -96);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(151, 25);
            this.lbTitulo.TabIndex = 27;
            this.lbTitulo.Text = "Crear Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Crear Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(247, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 74);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(102, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 74);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.dtFechaNac);
            this.gbxCliente.Controls.Add(this.cboGenero);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.lbFechaIng);
            this.gbxCliente.Controls.Add(this.lblRol);
            this.gbxCliente.Controls.Add(this.lbNom);
            this.gbxCliente.Controls.Add(this.lbNombre);
            this.gbxCliente.Controls.Add(this.mskCedula);
            this.gbxCliente.Location = new System.Drawing.Point(-1, 51);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(410, 336);
            this.gbxCliente.TabIndex = 28;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos de cliente";
            this.gbxCliente.Enter += new System.EventHandler(this.gbxCliente_Enter);
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(161, 198);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(159, 20);
            this.dtFechaNac.TabIndex = 20;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Maculino",
            "Femenino",
            "Payaso"});
            this.cboGenero.Location = new System.Drawing.Point(161, 112);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(159, 21);
            this.cboGenero.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 156);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lbFechaIng
            // 
            this.lbFechaIng.AutoSize = true;
            this.lbFechaIng.Location = new System.Drawing.Point(51, 204);
            this.lbFechaIng.Name = "lbFechaIng";
            this.lbFechaIng.Size = new System.Drawing.Size(90, 13);
            this.lbFechaIng.TabIndex = 6;
            this.lbFechaIng.Text = "Fecha de Ingreso";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(100, 115);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = "Rol";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(100, 156);
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
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lbFechaIng;
        public System.Windows.Forms.Label lblRol;
        public System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.MaskedTextBox mskCedula;
    }
}