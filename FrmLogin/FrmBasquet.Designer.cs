namespace Forms
{
    partial class FrmBasquet
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
            txtSponsor = new TextBox();
            lblSponsor = new Label();
            lblErrorSponsor = new Label();
            groupBox1 = new GroupBox();
            rdbNo = new RadioButton();
            RdbSi = new RadioButton();
            lblErrorEquipoMedico = new Label();
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(242, 38);
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.DarkGray;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(242, 15);
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.BackColor = Color.DarkGray;
            lblErrorNombre.Location = new Point(242, 62);
            lblErrorNombre.Size = new Size(66, 13);
            lblErrorNombre.Text = "ErrorNombre";
            // 
            // lblDivision
            // 
            lblDivision.BackColor = Color.DarkGray;
            lblDivision.ForeColor = Color.White;
            lblDivision.Location = new Point(242, 123);
            // 
            // cmbDivision
            // 
            cmbDivision.Location = new Point(242, 141);
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.ForeColor = Color.White;
            label2.Location = new Point(435, 20);
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEntrenador.Location = new Point(435, 38);
            // 
            // lblErrorNombreEntrenador
            // 
            lblErrorNombreEntrenador.BackColor = Color.DarkGray;
            lblErrorNombreEntrenador.Location = new Point(435, 62);
            lblErrorNombreEntrenador.Size = new Size(66, 13);
            lblErrorNombreEntrenador.Text = "ErrorApellido";
            // 
            // npdCantJugadores
            // 
            npdCantJugadores.Location = new Point(73, 38);
            // 
            // lblCantJugadores
            // 
            lblCantJugadores.BackColor = Color.DarkGray;
            lblCantJugadores.ForeColor = Color.White;
            lblCantJugadores.Location = new Point(73, 15);
            // 
            // lblCantTitulares
            // 
            lblCantTitulares.BackColor = Color.DarkGray;
            lblCantTitulares.ForeColor = Color.White;
            lblCantTitulares.Location = new Point(73, 67);
            // 
            // npdCantTitulares
            // 
            npdCantTitulares.Location = new Point(73, 90);
            // 
            // npdCantSuplentes
            // 
            npdCantSuplentes.Location = new Point(73, 143);
            // 
            // lblCanSuplentes
            // 
            lblCanSuplentes.BackColor = Color.DarkGray;
            lblCanSuplentes.ForeColor = Color.White;
            lblCanSuplentes.Location = new Point(73, 120);
            // 
            // btnCargarPlanilla
            // 
            btnCargarPlanilla.BackColor = Color.CornflowerBlue;
            btnCargarPlanilla.ForeColor = Color.Black;
            btnCargarPlanilla.Location = new Point(242, 218);
            btnCargarPlanilla.UseVisualStyleBackColor = false;
            // 
            // lblErrorCargarPlanilla
            // 
            lblErrorCargarPlanilla.BackColor = Color.DarkGray;
            lblErrorCargarPlanilla.Location = new Point(242, 254);
            lblErrorCargarPlanilla.Size = new Size(65, 13);
            lblErrorCargarPlanilla.Text = "ErrorPlantilla";
            // 
            // lblErrorCantidades
            // 
            lblErrorCantidades.BackColor = Color.DarkGray;
            lblErrorCantidades.Location = new Point(73, 167);
            lblErrorCantidades.Size = new Size(82, 13);
            lblErrorCantidades.Text = "ErrorCantidades";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.CornflowerBlue;
            btnContinuar.ForeColor = Color.Black;
            btnContinuar.Location = new Point(485, 364);
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CornflowerBlue;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(242, 364);
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblErrorCmb
            // 
            lblErrorCmb.BackColor = Color.DarkGray;
            lblErrorCmb.Location = new Point(242, 167);
            lblErrorCmb.Size = new Size(66, 13);
            lblErrorCmb.Text = "ErrorDivision";
            // 
            // txtSponsor
            // 
            txtSponsor.Location = new Point(435, 141);
            txtSponsor.Name = "txtSponsor";
            txtSponsor.Size = new Size(170, 23);
            txtSponsor.TabIndex = 22;
            // 
            // lblSponsor
            // 
            lblSponsor.AutoSize = true;
            lblSponsor.Location = new Point(435, 120);
            lblSponsor.Name = "lblSponsor";
            lblSponsor.Size = new Size(50, 15);
            lblSponsor.TabIndex = 23;
            lblSponsor.Text = "Sponsor";
            // 
            // lblErrorSponsor
            // 
            lblErrorSponsor.AutoSize = true;
            lblErrorSponsor.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorSponsor.ForeColor = Color.Red;
            lblErrorSponsor.Location = new Point(435, 167);
            lblErrorSponsor.Name = "lblErrorSponsor";
            lblErrorSponsor.Size = new Size(67, 13);
            lblErrorSponsor.TabIndex = 24;
            lblErrorSponsor.Text = "ErrorSponsor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNo);
            groupBox1.Controls.Add(RdbSi);
            groupBox1.Location = new Point(435, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 84);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Equipo medico";
            // 
            // rdbNo
            // 
            rdbNo.AutoSize = true;
            rdbNo.Location = new Point(14, 49);
            rdbNo.Name = "rdbNo";
            rdbNo.Size = new Size(41, 19);
            rdbNo.TabIndex = 1;
            rdbNo.TabStop = true;
            rdbNo.Text = "No";
            rdbNo.UseVisualStyleBackColor = true;
            // 
            // RdbSi
            // 
            RdbSi.AutoSize = true;
            RdbSi.Location = new Point(14, 24);
            RdbSi.Name = "RdbSi";
            RdbSi.Size = new Size(34, 19);
            RdbSi.TabIndex = 0;
            RdbSi.TabStop = true;
            RdbSi.Text = "Si";
            RdbSi.UseVisualStyleBackColor = true;
            // 
            // lblErrorEquipoMedico
            // 
            lblErrorEquipoMedico.AutoSize = true;
            lblErrorEquipoMedico.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorEquipoMedico.ForeColor = Color.Red;
            lblErrorEquipoMedico.Location = new Point(450, 254);
            lblErrorEquipoMedico.Name = "lblErrorEquipoMedico";
            lblErrorEquipoMedico.Size = new Size(67, 13);
            lblErrorEquipoMedico.TabIndex = 27;
            lblErrorEquipoMedico.Text = "ErrorSponsor";
            // 
            // FrmBasquet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(880, 433);
            Controls.Add(lblErrorEquipoMedico);
            Controls.Add(groupBox1);
            Controls.Add(lblErrorSponsor);
            Controls.Add(lblSponsor);
            Controls.Add(txtSponsor);
            Name = "FrmBasquet";
            Text = "Basquet";
            Load += FrmBasquet_Load;
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
            Controls.SetChildIndex(txtSponsor, 0);
            Controls.SetChildIndex(lblSponsor, 0);
            Controls.SetChildIndex(lblErrorSponsor, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(lblErrorEquipoMedico, 0);
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantSuplentes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSponsor;
        private Label lblSponsor;
        private Label lblErrorSponsor;
        private GroupBox groupBox1;
        private RadioButton rdbNo;
        private RadioButton RdbSi;
        private Label lblErrorEquipoMedico;
    }
}