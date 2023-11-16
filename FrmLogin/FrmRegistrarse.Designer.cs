namespace Forms
{
    partial class FrmRegistrarse
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
            txtApellido = new TextBox();
            txtMail = new TextBox();
            txtContraseña = new TextBox();
            txtRepContraseña = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblMail = new Label();
            lblContraseña = new Label();
            lblRepContraseña = new Label();
            btnContinuar = new Button();
            btnCancelar = new Button();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            lblErrorEmail = new Label();
            lblErrorContraseña = new Label();
            lblErrorRepContraseña = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(71, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(71, 134);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(214, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(71, 203);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(214, 27);
            txtMail.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(71, 272);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(214, 27);
            txtContraseña.TabIndex = 3;
            // 
            // txtRepContraseña
            // 
            txtRepContraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepContraseña.Location = new Point(71, 349);
            txtRepContraseña.Name = "txtRepContraseña";
            txtRepContraseña.Size = new Size(214, 27);
            txtRepContraseña.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(71, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(71, 111);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(71, 180);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(46, 20);
            lblMail.TabIndex = 7;
            lblMail.Text = "Email";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(71, 249);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = "Contraseña";
            // 
            // lblRepContraseña
            // 
            lblRepContraseña.AutoSize = true;
            lblRepContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRepContraseña.Location = new Point(71, 326);
            lblRepContraseña.Name = "lblRepContraseña";
            lblRepContraseña.Size = new Size(146, 20);
            lblRepContraseña.TabIndex = 9;
            lblRepContraseña.Text = "Confirme contraseña";
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(220, 422);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(90, 34);
            btnContinuar.TabIndex = 10;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(27, 422);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(71, 90);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(31, 15);
            lblErrorNombre.TabIndex = 12;
            lblErrorNombre.Text = "Error";
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(71, 164);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(31, 15);
            lblErrorApellido.TabIndex = 13;
            lblErrorApellido.Text = "Error";
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(71, 233);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(31, 15);
            lblErrorEmail.TabIndex = 14;
            lblErrorEmail.Text = "Error";
            // 
            // lblErrorContraseña
            // 
            lblErrorContraseña.AutoSize = true;
            lblErrorContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorContraseña.ForeColor = Color.Red;
            lblErrorContraseña.Location = new Point(71, 302);
            lblErrorContraseña.Name = "lblErrorContraseña";
            lblErrorContraseña.Size = new Size(31, 15);
            lblErrorContraseña.TabIndex = 15;
            lblErrorContraseña.Text = "Error";
            // 
            // lblErrorRepContraseña
            // 
            lblErrorRepContraseña.AutoSize = true;
            lblErrorRepContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorRepContraseña.ForeColor = Color.Red;
            lblErrorRepContraseña.Location = new Point(71, 379);
            lblErrorRepContraseña.Name = "lblErrorRepContraseña";
            lblErrorRepContraseña.Size = new Size(31, 15);
            lblErrorRepContraseña.TabIndex = 16;
            lblErrorRepContraseña.Text = "Error";
            // 
            // FrmRegistrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 482);
            Controls.Add(lblErrorRepContraseña);
            Controls.Add(lblErrorContraseña);
            Controls.Add(lblErrorEmail);
            Controls.Add(lblErrorApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnContinuar);
            Controls.Add(lblRepContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(lblMail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtRepContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtMail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FrmRegistrarse";
            Text = "FrmRegistrarse";
            Load += FrmRegistrarse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMail;
        private TextBox txtContraseña;
        private TextBox txtRepContraseña;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblMail;
        private Label lblContraseña;
        private Label lblRepContraseña;
        private Button btnContinuar;
        private Button btnCancelar;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Label lblErrorEmail;
        private Label lblErrorContraseña;
        private Label lblErrorRepContraseña;
    }
}