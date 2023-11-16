namespace FrmLogin
{
    partial class FrmLogin1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMail = new TextBox();
            txtContraseña = new TextBox();
            lblUsername = new Label();
            lblMail = new Label();
            lblError = new Label();
            btnIngresar = new Button();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(82, 97);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(186, 27);
            txtMail.TabIndex = 0;
            txtMail.Text = "lucianovega@parcial.com";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(82, 164);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(186, 27);
            txtContraseña.TabIndex = 1;
            txtContraseña.Text = "Password_1";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(82, 74);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(46, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Email";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(82, 141);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(83, 20);
            lblMail.TabIndex = 3;
            lblMail.Text = "Contraseña";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(82, 194);
            lblError.Name = "lblError";
            lblError.Size = new Size(31, 15);
            lblError.TabIndex = 4;
            lblError.Text = "Error";
            // 
            // btnIngresar
            // 
            btnIngresar.FlatAppearance.BorderColor = Color.Silver;
            btnIngresar.FlatAppearance.BorderSize = 2;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(124, 231);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(90, 33);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Location = new Point(124, 286);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(90, 33);
            btnRegistrarse.TabIndex = 7;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // FrmLogin1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(360, 388);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(lblError);
            Controls.Add(lblMail);
            Controls.Add(lblUsername);
            Controls.Add(txtContraseña);
            Controls.Add(txtMail);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLogin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtContraseña;
        private Label lblUsername;
        private Label lblMail;
        private Label lblError;
        private Button btnIngresar;
        private Button btnRegistrarse;
    }
}