namespace Forms
{
    partial class FrmCRUD1
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
        public void InitializeComponent()
        {
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblErrorNombre = new Label();
            lblDivision = new Label();
            cmbDivision = new ComboBox();
            label2 = new Label();
            txtNombreEntrenador = new TextBox();
            lblErrorNombreEntrenador = new Label();
            npdCantJugadores = new NumericUpDown();
            lblCantJugadores = new Label();
            lblCantTitulares = new Label();
            npdCantTitulares = new NumericUpDown();
            npdCantSuplentes = new NumericUpDown();
            lblCanSuplentes = new Label();
            btnCargarPlanilla = new Button();
            lblErrorCargarPlanilla = new Label();
            lblErrorCantidades = new Label();
            btnContinuar = new Button();
            btnCancelar = new Button();
            lblErrorCmb = new Label();
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(56, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 21);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(56, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(52, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(56, 62);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(76, 13);
            lblErrorNombre.TabIndex = 2;
            lblErrorNombre.Text = "lblErrorNombre";
            // 
            // lblDivision
            // 
            lblDivision.AutoSize = true;
            lblDivision.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDivision.Location = new Point(257, 223);
            lblDivision.Name = "lblDivision";
            lblDivision.Size = new Size(50, 15);
            lblDivision.TabIndex = 5;
            lblDivision.Text = "Division";
            // 
            // cmbDivision
            // 
            cmbDivision.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDivision.FormattingEnabled = true;
            cmbDivision.Items.AddRange(new object[] { "Sub16", "Sub18", "Sub21", "Mayores" });
            cmbDivision.Location = new Point(257, 241);
            cmbDivision.Name = "cmbDivision";
            cmbDivision.Size = new Size(121, 23);
            cmbDivision.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 92);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre del entrenador";
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreEntrenador.Location = new Point(56, 110);
            txtNombreEntrenador.Name = "txtNombreEntrenador";
            txtNombreEntrenador.Size = new Size(170, 21);
            txtNombreEntrenador.TabIndex = 8;
            // 
            // lblErrorNombreEntrenador
            // 
            lblErrorNombreEntrenador.AutoSize = true;
            lblErrorNombreEntrenador.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNombreEntrenador.ForeColor = Color.Red;
            lblErrorNombreEntrenador.Location = new Point(56, 134);
            lblErrorNombreEntrenador.Name = "lblErrorNombreEntrenador";
            lblErrorNombreEntrenador.Size = new Size(128, 13);
            lblErrorNombreEntrenador.TabIndex = 9;
            lblErrorNombreEntrenador.Text = "lblErrorNombreEntrenador";
            // 
            // npdCantJugadores
            // 
            npdCantJugadores.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            npdCantJugadores.Location = new Point(56, 190);
            npdCantJugadores.Name = "npdCantJugadores";
            npdCantJugadores.Size = new Size(68, 21);
            npdCantJugadores.TabIndex = 10;
            // 
            // lblCantJugadores
            // 
            lblCantJugadores.AutoSize = true;
            lblCantJugadores.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantJugadores.Location = new Point(56, 167);
            lblCantJugadores.Name = "lblCantJugadores";
            lblCantJugadores.Size = new Size(131, 15);
            lblCantJugadores.TabIndex = 11;
            lblCantJugadores.Text = "Cantidad de jugadores";
            // 
            // lblCantTitulares
            // 
            lblCantTitulares.AutoSize = true;
            lblCantTitulares.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantTitulares.Location = new Point(56, 219);
            lblCantTitulares.Name = "lblCantTitulares";
            lblCantTitulares.Size = new Size(119, 15);
            lblCantTitulares.TabIndex = 12;
            lblCantTitulares.Text = "Cantidad de titulares";
            // 
            // npdCantTitulares
            // 
            npdCantTitulares.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            npdCantTitulares.Location = new Point(56, 242);
            npdCantTitulares.Name = "npdCantTitulares";
            npdCantTitulares.Size = new Size(68, 21);
            npdCantTitulares.TabIndex = 13;
            // 
            // npdCantSuplentes
            // 
            npdCantSuplentes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            npdCantSuplentes.Location = new Point(56, 295);
            npdCantSuplentes.Name = "npdCantSuplentes";
            npdCantSuplentes.Size = new Size(68, 21);
            npdCantSuplentes.TabIndex = 15;
            // 
            // lblCanSuplentes
            // 
            lblCanSuplentes.AutoSize = true;
            lblCanSuplentes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCanSuplentes.Location = new Point(56, 272);
            lblCanSuplentes.Name = "lblCanSuplentes";
            lblCanSuplentes.Size = new Size(129, 15);
            lblCanSuplentes.TabIndex = 14;
            lblCanSuplentes.Text = "Cantidad de suplentes";
            // 
            // btnCargarPlanilla
            // 
            btnCargarPlanilla.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarPlanilla.Location = new Point(491, 235);
            btnCargarPlanilla.Name = "btnCargarPlanilla";
            btnCargarPlanilla.Size = new Size(103, 33);
            btnCargarPlanilla.TabIndex = 16;
            btnCargarPlanilla.Text = "Cargar planilla";
            btnCargarPlanilla.UseVisualStyleBackColor = true;
            btnCargarPlanilla.Click += btnCargarPlanilla_Click;
            // 
            // lblErrorCargarPlanilla
            // 
            lblErrorCargarPlanilla.AutoSize = true;
            lblErrorCargarPlanilla.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCargarPlanilla.ForeColor = Color.Red;
            lblErrorCargarPlanilla.Location = new Point(491, 271);
            lblErrorCargarPlanilla.Name = "lblErrorCargarPlanilla";
            lblErrorCargarPlanilla.Size = new Size(103, 13);
            lblErrorCargarPlanilla.TabIndex = 17;
            lblErrorCargarPlanilla.Text = "lblErrorCargarPlanilla";
            // 
            // lblErrorCantidades
            // 
            lblErrorCantidades.AutoSize = true;
            lblErrorCantidades.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCantidades.ForeColor = Color.Red;
            lblErrorCantidades.Location = new Point(56, 319);
            lblErrorCantidades.Name = "lblErrorCantidades";
            lblErrorCantidades.Size = new Size(92, 13);
            lblErrorCantidades.TabIndex = 18;
            lblErrorCantidades.Text = "lblErrorCantidades";
            // 
            // btnContinuar
            // 
            btnContinuar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinuar.Location = new Point(485, 300);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(109, 31);
            btnContinuar.TabIndex = 19;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(257, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 31);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblErrorCmb
            // 
            lblErrorCmb.AutoSize = true;
            lblErrorCmb.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCmb.ForeColor = Color.Red;
            lblErrorCmb.Location = new Point(257, 267);
            lblErrorCmb.Name = "lblErrorCmb";
            lblErrorCmb.Size = new Size(60, 13);
            lblErrorCmb.TabIndex = 21;
            lblErrorCmb.Text = "lblErrorCmb";
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 343);
            Controls.Add(lblErrorCmb);
            Controls.Add(btnCancelar);
            Controls.Add(btnContinuar);
            Controls.Add(lblErrorCantidades);
            Controls.Add(lblErrorCargarPlanilla);
            Controls.Add(btnCargarPlanilla);
            Controls.Add(npdCantSuplentes);
            Controls.Add(lblCanSuplentes);
            Controls.Add(npdCantTitulares);
            Controls.Add(lblCantTitulares);
            Controls.Add(lblCantJugadores);
            Controls.Add(npdCantJugadores);
            Controls.Add(lblErrorNombreEntrenador);
            Controls.Add(txtNombreEntrenador);
            Controls.Add(label2);
            Controls.Add(cmbDivision);
            Controls.Add(lblDivision);
            Controls.Add(lblErrorNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "FrmCRUD";
            Text = "FrmCRUD";
            Load += FrmCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox txtNombre;
        protected Label lblNombre;
        protected Label lblErrorNombre;
        protected Label lblDivision;
        protected ComboBox cmbDivision;
        protected Label label2;
        protected TextBox txtNombreEntrenador;
        protected Label lblErrorNombreEntrenador;
        protected NumericUpDown npdCantJugadores;
        protected Label lblCantJugadores;
        protected Label lblCantTitulares;
        protected NumericUpDown npdCantTitulares;
        protected NumericUpDown npdCantSuplentes;
        protected Label lblCanSuplentes;
        protected Button btnCargarPlanilla;
        protected Label lblErrorCargarPlanilla;
        protected Label lblErrorCantidades;
        protected Button btnContinuar;
        protected Button btnCancelar;
        protected Label lblErrorCmb;
    }
}