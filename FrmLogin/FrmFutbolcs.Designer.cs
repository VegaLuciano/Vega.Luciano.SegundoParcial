namespace Forms
{
    partial class FrmFutbol
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
            colorVisitante = new ColorDialog();
            btnCamisetaLocal = new Button();
            btnVisitante = new Button();
            lblErrorLocal = new Label();
            lblErrorVisitante = new Label();
            colorLocal = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(268, 60);
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.DarkGray;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(268, 37);
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.BackColor = Color.DarkGray;
            lblErrorNombre.Location = new Point(268, 84);
            lblErrorNombre.Size = new Size(63, 13);
            lblErrorNombre.Text = "ErroNombre";
            // 
            // lblDivision
            // 
            lblDivision.BackColor = Color.DarkGray;
            lblDivision.ForeColor = Color.White;
            lblDivision.Location = new Point(272, 126);
            // 
            // cmbDivision
            // 
            cmbDivision.Items.AddRange(new object[] { "Sub16", "Sub18", "Sub21", "Mayores", "Sub16", "Sub18", "Sub21", "Mayores" });
            cmbDivision.Location = new Point(270, 142);
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.ForeColor = Color.White;
            label2.Location = new Point(466, 40);
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEntrenador.Location = new Point(466, 58);
            // 
            // lblErrorNombreEntrenador
            // 
            lblErrorNombreEntrenador.BackColor = Color.DarkGray;
            lblErrorNombreEntrenador.Location = new Point(466, 82);
            lblErrorNombreEntrenador.Size = new Size(118, 13);
            lblErrorNombreEntrenador.Text = "ErrorNombreEntrenador";
            // 
            // npdCantJugadores
            // 
            npdCantJugadores.Location = new Point(96, 68);
            // 
            // lblCantJugadores
            // 
            lblCantJugadores.BackColor = Color.DarkGray;
            lblCantJugadores.ForeColor = Color.White;
            lblCantJugadores.Location = new Point(96, 45);
            // 
            // lblCantTitulares
            // 
            lblCantTitulares.BackColor = Color.DarkGray;
            lblCantTitulares.ForeColor = Color.White;
            lblCantTitulares.Location = new Point(96, 97);
            // 
            // npdCantTitulares
            // 
            npdCantTitulares.Location = new Point(96, 120);
            // 
            // npdCantSuplentes
            // 
            npdCantSuplentes.Location = new Point(96, 173);
            // 
            // lblCanSuplentes
            // 
            lblCanSuplentes.BackColor = Color.DarkGray;
            lblCanSuplentes.ForeColor = Color.White;
            lblCanSuplentes.Location = new Point(96, 150);
            // 
            // btnCargarPlanilla
            // 
            btnCargarPlanilla.BackColor = Color.CornflowerBlue;
            btnCargarPlanilla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarPlanilla.ForeColor = Color.Black;
            btnCargarPlanilla.Location = new Point(468, 142);
            btnCargarPlanilla.Size = new Size(109, 23);
            btnCargarPlanilla.UseVisualStyleBackColor = false;
            // 
            // lblErrorCargarPlanilla
            // 
            lblErrorCargarPlanilla.BackColor = Color.DarkGray;
            lblErrorCargarPlanilla.Location = new Point(468, 170);
            lblErrorCargarPlanilla.Size = new Size(62, 13);
            lblErrorCargarPlanilla.Text = "ErrorPlanilla";
            // 
            // lblErrorCantidades
            // 
            lblErrorCantidades.BackColor = Color.DarkGray;
            lblErrorCantidades.Location = new Point(96, 197);
            lblErrorCantidades.Size = new Size(82, 13);
            lblErrorCantidades.Text = "ErrorCantidades";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.CornflowerBlue;
            btnContinuar.ForeColor = Color.Black;
            btnContinuar.Location = new Point(475, 317);
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CornflowerBlue;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(268, 317);
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // lblErrorCmb
            // 
            lblErrorCmb.BackColor = Color.DarkGray;
            lblErrorCmb.Location = new Point(270, 168);
            lblErrorCmb.Size = new Size(66, 13);
            lblErrorCmb.Text = "ErrorNombre";
            // 
            // colorVisitante
            // 
            colorVisitante.AllowFullOpen = false;
            colorVisitante.SolidColorOnly = true;
            // 
            // btnCamisetaLocal
            // 
            btnCamisetaLocal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCamisetaLocal.Location = new Point(268, 226);
            btnCamisetaLocal.Name = "btnCamisetaLocal";
            btnCamisetaLocal.Size = new Size(160, 23);
            btnCamisetaLocal.TabIndex = 22;
            btnCamisetaLocal.Text = "Seleccionar color local";
            btnCamisetaLocal.UseVisualStyleBackColor = true;
            btnCamisetaLocal.Click += btnCamisetaLocal_Click;
            // 
            // btnVisitante
            // 
            btnVisitante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisitante.Location = new Point(466, 226);
            btnVisitante.Name = "btnVisitante";
            btnVisitante.Size = new Size(160, 23);
            btnVisitante.TabIndex = 23;
            btnVisitante.Text = "Seleccionar color visitante";
            btnVisitante.UseVisualStyleBackColor = true;
            btnVisitante.Click += btnVisitante_Click;
            // 
            // lblErrorLocal
            // 
            lblErrorLocal.AutoSize = true;
            lblErrorLocal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorLocal.ForeColor = Color.Red;
            lblErrorLocal.Location = new Point(268, 252);
            lblErrorLocal.Name = "lblErrorLocal";
            lblErrorLocal.Size = new Size(55, 13);
            lblErrorLocal.TabIndex = 24;
            lblErrorLocal.Text = "ErrorLocal";
            // 
            // lblErrorVisitante
            // 
            lblErrorVisitante.AutoSize = true;
            lblErrorVisitante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorVisitante.ForeColor = Color.Red;
            lblErrorVisitante.Location = new Point(466, 257);
            lblErrorVisitante.Name = "lblErrorVisitante";
            lblErrorVisitante.Size = new Size(69, 13);
            lblErrorVisitante.TabIndex = 25;
            lblErrorVisitante.Text = "ErrorVisitante";
            // 
            // colorLocal
            // 
            colorLocal.AllowFullOpen = false;
            colorLocal.SolidColorOnly = true;
            // 
            // FrmFutbol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(880, 433);
            Controls.Add(lblErrorVisitante);
            Controls.Add(lblErrorLocal);
            Controls.Add(btnVisitante);
            Controls.Add(btnCamisetaLocal);
            Name = "FrmFutbol";
            Text = "FrmFutbol";
            Load += FrmFutbol_Load;
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblErrorNombre, 0);
            Controls.SetChildIndex(lblDivision, 0);
            Controls.SetChildIndex(cmbDivision, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtNombreEntrenador, 0);
            Controls.SetChildIndex(lblErrorNombreEntrenador, 0);
            Controls.SetChildIndex(npdCantJugadores, 0);
            Controls.SetChildIndex(lblCantJugadores, 0);
            Controls.SetChildIndex(lblCantTitulares, 0);
            Controls.SetChildIndex(npdCantTitulares, 0);
            Controls.SetChildIndex(lblCanSuplentes, 0);
            Controls.SetChildIndex(npdCantSuplentes, 0);
            Controls.SetChildIndex(btnCargarPlanilla, 0);
            Controls.SetChildIndex(lblErrorCargarPlanilla, 0);
            Controls.SetChildIndex(lblErrorCantidades, 0);
            Controls.SetChildIndex(btnContinuar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblErrorCmb, 0);
            Controls.SetChildIndex(btnCamisetaLocal, 0);
            Controls.SetChildIndex(btnVisitante, 0);
            Controls.SetChildIndex(lblErrorLocal, 0);
            Controls.SetChildIndex(lblErrorVisitante, 0);
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorVisitante;
        private Button btnCamisetaLocal;
        private Button btnVisitante;
        private Label lblErrorLocal;
        private Label lblErrorVisitante;
        private ColorDialog colorLocal;
    }
}