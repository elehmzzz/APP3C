namespace APP3C.Cafeteria
{
    partial class FrmCafeteria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtExtra2 = new System.Windows.Forms.TextBox();
            this.rdbArtesanal = new System.Windows.Forms.RadioButton();
            this.rdbEnergetica = new System.Windows.Forms.RadioButton();
            this.lblExtra2 = new System.Windows.Forms.Label();
            this.rdbAlcohol = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.rdbFria = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rdbCaliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreBebida = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura de bebidas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtExtra2);
            this.panel1.Controls.Add(this.rdbArtesanal);
            this.panel1.Controls.Add(this.rdbEnergetica);
            this.panel1.Controls.Add(this.lblExtra2);
            this.panel1.Controls.Add(this.rdbAlcohol);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtExtra);
            this.panel1.Controls.Add(this.lblExtra);
            this.panel1.Controls.Add(this.cmbTamanio);
            this.panel1.Controls.Add(this.rdbFria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.rdbCaliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreBebida);
            this.panel1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 581);
            this.panel1.TabIndex = 8;
            // 
            // txtExtra2
            // 
            this.txtExtra2.Location = new System.Drawing.Point(184, 437);
            this.txtExtra2.Name = "txtExtra2";
            this.txtExtra2.Size = new System.Drawing.Size(164, 45);
            this.txtExtra2.TabIndex = 15;
            // 
            // rdbArtesanal
            // 
            this.rdbArtesanal.AutoSize = true;
            this.rdbArtesanal.Location = new System.Drawing.Point(185, 71);
            this.rdbArtesanal.Name = "rdbArtesanal";
            this.rdbArtesanal.Size = new System.Drawing.Size(117, 40);
            this.rdbArtesanal.TabIndex = 13;
            this.rdbArtesanal.TabStop = true;
            this.rdbArtesanal.Text = "Artesanal";
            this.rdbArtesanal.UseVisualStyleBackColor = true;
            this.rdbArtesanal.CheckedChanged += new System.EventHandler(this.rdbArtesanal_CheckedChanged);
            // 
            // rdbEnergetica
            // 
            this.rdbEnergetica.AutoSize = true;
            this.rdbEnergetica.Location = new System.Drawing.Point(184, 25);
            this.rdbEnergetica.Name = "rdbEnergetica";
            this.rdbEnergetica.Size = new System.Drawing.Size(127, 40);
            this.rdbEnergetica.TabIndex = 12;
            this.rdbEnergetica.TabStop = true;
            this.rdbEnergetica.Text = "Energetica";
            this.rdbEnergetica.UseVisualStyleBackColor = true;
            this.rdbEnergetica.CheckedChanged += new System.EventHandler(this.rdbEnergetica_CheckedChanged);
            // 
            // lblExtra2
            // 
            this.lblExtra2.AutoSize = true;
            this.lblExtra2.Location = new System.Drawing.Point(178, 398);
            this.lblExtra2.Name = "lblExtra2";
            this.lblExtra2.Size = new System.Drawing.Size(178, 36);
            this.lblExtra2.TabIndex = 14;
            this.lblExtra2.Text = "Grados de alcohol:";
            // 
            // rdbAlcohol
            // 
            this.rdbAlcohol.AutoSize = true;
            this.rdbAlcohol.Location = new System.Drawing.Point(21, 117);
            this.rdbAlcohol.Name = "rdbAlcohol";
            this.rdbAlcohol.Size = new System.Drawing.Size(127, 40);
            this.rdbAlcohol.TabIndex = 11;
            this.rdbAlcohol.TabStop = true;
            this.rdbAlcohol.Text = "Alcohólica";
            this.rdbAlcohol.UseVisualStyleBackColor = true;
            this.rdbAlcohol.CheckedChanged += new System.EventHandler(this.rdbAlcohol_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 515);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 34);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(184, 327);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(164, 45);
            this.txtExtra.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(179, 288);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(169, 36);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Cantidad de hielo";
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmbTamanio.Location = new System.Drawing.Point(21, 437);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(121, 44);
            this.cmbTamanio.TabIndex = 7;
            // 
            // rdbFria
            // 
            this.rdbFria.AutoSize = true;
            this.rdbFria.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFria.Location = new System.Drawing.Point(21, 25);
            this.rdbFria.Name = "rdbFria";
            this.rdbFria.Size = new System.Drawing.Size(68, 40);
            this.rdbFria.TabIndex = 0;
            this.rdbFria.TabStop = true;
            this.rdbFria.Text = "Fria";
            this.rdbFria.UseVisualStyleBackColor = true;
            this.rdbFria.CheckedChanged += new System.EventHandler(this.rdbFria_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tamaño:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(18, 327);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 45);
            this.txtPrecio.TabIndex = 6;
            // 
            // rdbCaliente
            // 
            this.rdbCaliente.AutoSize = true;
            this.rdbCaliente.Location = new System.Drawing.Point(21, 71);
            this.rdbCaliente.Name = "rdbCaliente";
            this.rdbCaliente.Size = new System.Drawing.Size(106, 40);
            this.rdbCaliente.TabIndex = 1;
            this.rdbCaliente.TabStop = true;
            this.rdbCaliente.Text = "Caliente";
            this.rdbCaliente.UseVisualStyleBackColor = true;
            this.rdbCaliente.CheckedChanged += new System.EventHandler(this.rdbCaliente_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la bebida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio:";
            // 
            // txtNombreBebida
            // 
            this.txtNombreBebida.Location = new System.Drawing.Point(18, 228);
            this.txtNombreBebida.Name = "txtNombreBebida";
            this.txtNombreBebida.Size = new System.Drawing.Size(358, 45);
            this.txtNombreBebida.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 16.2F);
            this.groupBox2.Location = new System.Drawing.Point(489, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bebidas agregadas:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsbLista);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 413);
            this.panel2.TabIndex = 2;
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 36;
            this.lsbLista.Location = new System.Drawing.Point(3, 25);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(414, 292);
            this.lsbLista.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(15, 345);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 36);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // FrmCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(954, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCafeteria";
            this.Load += new System.EventHandler(this.FrmCafeteria_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreBebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCaliente;
        private System.Windows.Forms.RadioButton rdbFria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbAlcohol;
        private System.Windows.Forms.RadioButton rdbEnergetica;
        private System.Windows.Forms.RadioButton rdbArtesanal;
        private System.Windows.Forms.Label lblExtra2;
        private System.Windows.Forms.TextBox txtExtra2;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Panel panel2;
    }
}