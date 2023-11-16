namespace Forms
{
    partial class FrmUsuario1
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblMail = new Label();
            lblContraseña = new Label();
            lblUsNombre = new Label();
            lblUsApellido = new Label();
            lblUsMail = new Label();
            lblUsContraseña = new Label();
            btnVolver = new Button();
            chbVer = new CheckBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(60, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(58, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(58, 136);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(36, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "Email";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(58, 188);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsNombre
            // 
            lblUsNombre.AutoSize = true;
            lblUsNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsNombre.Location = new Point(58, 53);
            lblUsNombre.Name = "lblUsNombre";
            lblUsNombre.Size = new Size(114, 20);
            lblUsNombre.TabIndex = 4;
            lblUsNombre.Text = "NombreUsuario";
            // 
            // lblUsApellido
            // 
            lblUsApellido.AutoSize = true;
            lblUsApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsApellido.Location = new Point(58, 101);
            lblUsApellido.Name = "lblUsApellido";
            lblUsApellido.Size = new Size(116, 20);
            lblUsApellido.TabIndex = 5;
            lblUsApellido.Text = "ApellidoUsuario";
            // 
            // lblUsMail
            // 
            lblUsMail.AutoSize = true;
            lblUsMail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsMail.Location = new Point(60, 151);
            lblUsMail.Name = "lblUsMail";
            lblUsMail.Size = new Size(96, 20);
            lblUsMail.TabIndex = 6;
            lblUsMail.Text = "EmailUsuario";
            // 
            // lblUsContraseña
            // 
            lblUsContraseña.AutoSize = true;
            lblUsContraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsContraseña.Location = new Point(58, 203);
            lblUsContraseña.Name = "lblUsContraseña";
            lblUsContraseña.Size = new Size(133, 20);
            lblUsContraseña.TabIndex = 7;
            lblUsContraseña.Text = "ContraseñaUsuario";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(81, 248);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 24);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // chbVer
            // 
            chbVer.AutoSize = true;
            chbVer.Location = new Point(197, 206);
            chbVer.Name = "chbVer";
            chbVer.Size = new Size(42, 19);
            chbVer.TabIndex = 10;
            chbVer.Text = "Ver";
            chbVer.UseVisualStyleBackColor = true;
            chbVer.CheckedChanged += chbVer_CheckedChanged;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 305);
            Controls.Add(chbVer);
            Controls.Add(btnVolver);
            Controls.Add(lblUsContraseña);
            Controls.Add(lblUsMail);
            Controls.Add(lblUsApellido);
            Controls.Add(lblUsNombre);
            Controls.Add(lblContraseña);
            Controls.Add(lblMail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblMail;
        private Label lblContraseña;
        private Label lblUsNombre;
        private Label lblUsApellido;
        private Label lblUsMail;
        private Label lblUsContraseña;
        private Button btnVolver;
        private CheckBox chbVer;
    }
}