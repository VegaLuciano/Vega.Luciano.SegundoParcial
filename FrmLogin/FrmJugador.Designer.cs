namespace Forms
{
    partial class FrmJugador
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            cmbGenero = new ComboBox();
            lblErrorGenero = new Label();
            lblGenero = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            npdEdad = new NumericUpDown();
            lblEdad = new Label();
            lblErrorEdad = new Label();
            lblErrorDni = new Label();
            lblDni = new Label();
            npdDni = new NumericUpDown();
            lblErrorAltura = new Label();
            lblAltura = new Label();
            txtAltura = new TextBox();
            lblDeporte = new Label();
            cmbDeporte = new ComboBox();
            lblErrorDeporte = new Label();
            lblErrorDivision = new Label();
            cmbDivision = new ComboBox();
            lblDivision = new Label();
            btnContinuar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)npdEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdDni).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(54, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 27);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(54, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(54, 77);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(49, 15);
            lblErrorNombre.TabIndex = 2;
            lblErrorNombre.Text = "Nombre";
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(54, 162);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(74, 15);
            lblErrorApellido.TabIndex = 5;
            lblErrorApellido.Text = "ErrorApellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 109);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(54, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(161, 27);
            txtApellido.TabIndex = 3;
            // 
            // cmbGenero
            // 
            cmbGenero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(292, 46);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 28);
            cmbGenero.TabIndex = 6;
            // 
            // lblErrorGenero
            // 
            lblErrorGenero.AutoSize = true;
            lblErrorGenero.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorGenero.ForeColor = Color.Red;
            lblErrorGenero.Location = new Point(292, 76);
            lblErrorGenero.Name = "lblErrorGenero";
            lblErrorGenero.Size = new Size(68, 15);
            lblErrorGenero.TabIndex = 7;
            lblErrorGenero.Text = "ErrorGenero";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.Location = new Point(292, 23);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Genero";
            // 
            // npdEdad
            // 
            npdEdad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            npdEdad.Location = new Point(54, 302);
            npdEdad.Name = "npdEdad";
            npdEdad.Size = new Size(120, 27);
            npdEdad.TabIndex = 9;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(54, 279);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad";
            // 
            // lblErrorEdad
            // 
            lblErrorEdad.AutoSize = true;
            lblErrorEdad.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorEdad.ForeColor = Color.Red;
            lblErrorEdad.Location = new Point(54, 332);
            lblErrorEdad.Name = "lblErrorEdad";
            lblErrorEdad.Size = new Size(58, 15);
            lblErrorEdad.TabIndex = 11;
            lblErrorEdad.Text = "ErrorEdad";
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.Red;
            lblErrorDni.Location = new Point(54, 248);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(52, 15);
            lblErrorDni.TabIndex = 14;
            lblErrorDni.Text = "ErrorDNI";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(54, 195);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 13;
            lblDni.Text = "DNI";
            // 
            // npdDni
            // 
            npdDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            npdDni.Location = new Point(54, 218);
            npdDni.Name = "npdDni";
            npdDni.Size = new Size(120, 27);
            npdDni.TabIndex = 12;
            // 
            // lblErrorAltura
            // 
            lblErrorAltura.AutoSize = true;
            lblErrorAltura.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorAltura.ForeColor = Color.Red;
            lblErrorAltura.Location = new Point(292, 161);
            lblErrorAltura.Name = "lblErrorAltura";
            lblErrorAltura.Size = new Size(64, 15);
            lblErrorAltura.TabIndex = 17;
            lblErrorAltura.Text = "ErrorAltura";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltura.Location = new Point(292, 108);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(49, 20);
            lblAltura.TabIndex = 16;
            lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(292, 131);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(161, 27);
            txtAltura.TabIndex = 15;
            // 
            // lblDeporte
            // 
            lblDeporte.AutoSize = true;
            lblDeporte.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeporte.Location = new Point(292, 194);
            lblDeporte.Name = "lblDeporte";
            lblDeporte.Size = new Size(64, 20);
            lblDeporte.TabIndex = 18;
            lblDeporte.Text = "Deporte";
            // 
            // cmbDeporte
            // 
            cmbDeporte.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(292, 217);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(121, 28);
            cmbDeporte.TabIndex = 19;
            // 
            // lblErrorDeporte
            // 
            lblErrorDeporte.AutoSize = true;
            lblErrorDeporte.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorDeporte.ForeColor = Color.Red;
            lblErrorDeporte.Location = new Point(292, 247);
            lblErrorDeporte.Name = "lblErrorDeporte";
            lblErrorDeporte.RightToLeft = RightToLeft.Yes;
            lblErrorDeporte.Size = new Size(73, 15);
            lblErrorDeporte.TabIndex = 20;
            lblErrorDeporte.Text = "ErrorDeporte";
            // 
            // lblErrorDivision
            // 
            lblErrorDivision.AutoSize = true;
            lblErrorDivision.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorDivision.ForeColor = Color.Red;
            lblErrorDivision.Location = new Point(292, 330);
            lblErrorDivision.Name = "lblErrorDivision";
            lblErrorDivision.Size = new Size(73, 15);
            lblErrorDivision.TabIndex = 23;
            lblErrorDivision.Text = "ErrorDivision";
            // 
            // cmbDivision
            // 
            cmbDivision.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDivision.FormattingEnabled = true;
            cmbDivision.Location = new Point(292, 300);
            cmbDivision.Name = "cmbDivision";
            cmbDivision.Size = new Size(121, 28);
            cmbDivision.TabIndex = 22;
            // 
            // lblDivision
            // 
            lblDivision.AutoSize = true;
            lblDivision.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDivision.Location = new Point(292, 277);
            lblDivision.Name = "lblDivision";
            lblDivision.Size = new Size(62, 20);
            lblDivision.TabIndex = 21;
            lblDivision.Text = "Division";
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(292, 399);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(91, 29);
            btnContinuar.TabIndex = 24;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(54, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 29);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 455);
            Controls.Add(btnCancelar);
            Controls.Add(btnContinuar);
            Controls.Add(lblErrorDivision);
            Controls.Add(cmbDivision);
            Controls.Add(lblDivision);
            Controls.Add(lblErrorDeporte);
            Controls.Add(cmbDeporte);
            Controls.Add(lblDeporte);
            Controls.Add(lblErrorAltura);
            Controls.Add(lblAltura);
            Controls.Add(txtAltura);
            Controls.Add(lblErrorDni);
            Controls.Add(lblDni);
            Controls.Add(npdDni);
            Controls.Add(lblErrorEdad);
            Controls.Add(lblEdad);
            Controls.Add(npdEdad);
            Controls.Add(lblGenero);
            Controls.Add(lblErrorGenero);
            Controls.Add(cmbGenero);
            Controls.Add(lblErrorApellido);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "FrmJugador";
            Text = "FrmJugador";
            Load += FrmJugador_Load;
            ((System.ComponentModel.ISupportInitialize)npdEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdDni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Label label3;
        private TextBox txtApellido;
        private ComboBox cmbGenero;
        private Label lblErrorGenero;
        private Label lblGenero;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown npdEdad;
        private Label lblEdad;
        private Label lblErrorEdad;
        private Label lblErrorDni;
        private Label lblDni;
        private NumericUpDown npdDni;
        private Label lblErrorAltura;
        private Label lblAltura;
        private TextBox txtAltura;
        private Label lblDeporte;
        private ComboBox cmbDeporte;
        private Label lblErrorDeporte;
        private Label lblErrorDivision;
        private ComboBox cmbDivision;
        private Label lblDivision;
        private Button btnContinuar;
        private Button btnCancelar;
    }
}