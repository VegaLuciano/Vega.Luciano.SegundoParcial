namespace Forms
{
    partial class FrmVoley
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
            txtSedeEquipo = new TextBox();
            lblSede = new Label();
            lblErrorSede = new Label();
            cmbCancha = new ComboBox();
            lblCancha = new Label();
            lblErrorCancha = new Label();
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(259, 110);
            txtNombre.Text = "Protas";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.DarkGray;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(259, 87);
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.BackColor = Color.DarkGray;
            lblErrorNombre.Location = new Point(259, 134);
            lblErrorNombre.Size = new Size(66, 13);
            lblErrorNombre.Text = "ErrorNombre";
            // 
            // lblDivision
            // 
            lblDivision.BackColor = Color.DarkGray;
            lblDivision.ForeColor = Color.White;
            lblDivision.Location = new Point(259, 167);
            // 
            // cmbDivision
            // 
            cmbDivision.Location = new Point(259, 185);
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.ForeColor = Color.White;
            label2.Location = new Point(462, 92);
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEntrenador.Location = new Point(462, 110);
            txtNombreEntrenador.Text = "Jose";
            // 
            // lblErrorNombreEntrenador
            // 
            lblErrorNombreEntrenador.BackColor = Color.DarkGray;
            lblErrorNombreEntrenador.Location = new Point(462, 134);
            lblErrorNombreEntrenador.Size = new Size(118, 13);
            lblErrorNombreEntrenador.Text = "ErrorNombreEntrenador";
            // 
            // npdCantJugadores
            // 
            npdCantJugadores.Location = new Point(61, 40);
            // 
            // lblCantJugadores
            // 
            lblCantJugadores.BackColor = Color.DarkGray;
            lblCantJugadores.ForeColor = Color.White;
            lblCantJugadores.Location = new Point(61, 17);
            // 
            // lblCantTitulares
            // 
            lblCantTitulares.BackColor = Color.DarkGray;
            lblCantTitulares.ForeColor = Color.White;
            lblCantTitulares.Location = new Point(61, 69);
            // 
            // npdCantTitulares
            // 
            npdCantTitulares.Location = new Point(61, 92);
            npdCantTitulares.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // npdCantSuplentes
            // 
            npdCantSuplentes.Location = new Point(61, 145);
            // 
            // lblCanSuplentes
            // 
            lblCanSuplentes.BackColor = Color.DarkGray;
            lblCanSuplentes.ForeColor = Color.White;
            lblCanSuplentes.Location = new Point(61, 122);
            // 
            // btnCargarPlanilla
            // 
            btnCargarPlanilla.BackColor = Color.CornflowerBlue;
            btnCargarPlanilla.ForeColor = Color.Black;
            btnCargarPlanilla.Location = new Point(462, 180);
            btnCargarPlanilla.Size = new Size(109, 31);
            btnCargarPlanilla.UseVisualStyleBackColor = false;
            // 
            // lblErrorCargarPlanilla
            // 
            lblErrorCargarPlanilla.BackColor = Color.DarkGray;
            lblErrorCargarPlanilla.Location = new Point(462, 212);
            lblErrorCargarPlanilla.Size = new Size(62, 13);
            lblErrorCargarPlanilla.Text = "ErrorPlanilla";
            // 
            // lblErrorCantidades
            // 
            lblErrorCantidades.BackColor = Color.DarkGray;
            lblErrorCantidades.Location = new Point(61, 169);
            lblErrorCantidades.Size = new Size(82, 13);
            lblErrorCantidades.Text = "ErrorCantidades";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.CornflowerBlue;
            btnContinuar.ForeColor = Color.Black;
            btnContinuar.Location = new Point(462, 321);
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CornflowerBlue;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(259, 321);
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblErrorCmb
            // 
            lblErrorCmb.BackColor = Color.DarkGray;
            lblErrorCmb.Location = new Point(259, 217);
            lblErrorCmb.Size = new Size(66, 13);
            lblErrorCmb.Text = "ErrorDivision";
            // 
            // txtSedeEquipo
            // 
            txtSedeEquipo.Location = new Point(259, 38);
            txtSedeEquipo.Name = "txtSedeEquipo";
            txtSedeEquipo.Size = new Size(169, 23);
            txtSedeEquipo.TabIndex = 22;
            txtSedeEquipo.Text = "Quilmes";
            // 
            // lblSede
            // 
            lblSede.AutoSize = true;
            lblSede.Location = new Point(259, 16);
            lblSede.Name = "lblSede";
            lblSede.Size = new Size(32, 15);
            lblSede.TabIndex = 23;
            lblSede.Text = "Sede";
            // 
            // lblErrorSede
            // 
            lblErrorSede.AutoSize = true;
            lblErrorSede.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorSede.ForeColor = Color.Red;
            lblErrorSede.Location = new Point(259, 64);
            lblErrorSede.Name = "lblErrorSede";
            lblErrorSede.Size = new Size(51, 13);
            lblErrorSede.TabIndex = 24;
            lblErrorSede.Text = "ErrorSede";
            // 
            // cmbCancha
            // 
            cmbCancha.FormattingEnabled = true;
            cmbCancha.Location = new Point(462, 38);
            cmbCancha.Name = "cmbCancha";
            cmbCancha.Size = new Size(169, 23);
            cmbCancha.TabIndex = 25;
            // 
            // lblCancha
            // 
            lblCancha.AutoSize = true;
            lblCancha.Location = new Point(462, 20);
            lblCancha.Name = "lblCancha";
            lblCancha.Size = new Size(47, 15);
            lblCancha.TabIndex = 26;
            lblCancha.Text = "Cancha";
            // 
            // lblErrorCancha
            // 
            lblErrorCancha.AutoSize = true;
            lblErrorCancha.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorCancha.ForeColor = Color.Red;
            lblErrorCancha.Location = new Point(465, 70);
            lblErrorCancha.Name = "lblErrorCancha";
            lblErrorCancha.Size = new Size(66, 13);
            lblErrorCancha.TabIndex = 27;
            lblErrorCancha.Text = "ErrorCancha";
            // 
            // FrmVoley
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(880, 433);
            Controls.Add(lblErrorCancha);
            Controls.Add(lblCancha);
            Controls.Add(cmbCancha);
            Controls.Add(lblErrorSede);
            Controls.Add(lblSede);
            Controls.Add(txtSedeEquipo);
            Name = "FrmVoley";
            Text = "FrmVoley";
            Load += FrmVoley_Load;
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
            Controls.SetChildIndex(txtSedeEquipo, 0);
            Controls.SetChildIndex(lblSede, 0);
            Controls.SetChildIndex(lblErrorSede, 0);
            Controls.SetChildIndex(cmbCancha, 0);
            Controls.SetChildIndex(lblCancha, 0);
            Controls.SetChildIndex(lblErrorCancha, 0);
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSedeEquipo;
        private Label lblSede;
        private Label lblErrorSede;
        private ComboBox cmbCancha;
        private Label lblCancha;
        private Label lblErrorCancha;
    }
}