namespace Forms
{
    partial class FrmMenuPrincipal
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
            btnAgregar = new Button();
            lblUsuario = new Label();
            pnlFormulario = new Panel();
            btnBasquet = new Button();
            btnFutbol = new Button();
            btnVoley = new Button();
            btnMostrarVoley = new Button();
            btnMostrarFutbol = new Button();
            btnMostrarBasquet = new Button();
            lblReloj = new Label();
            button1 = new Button();
            lblErrorPath = new Label();
            btnVerLog = new Button();
            lblPerfil = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkSlateBlue;
            btnAgregar.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(12, 82);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 32);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar equipo";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.DarkSlateBlue;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(43, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click_1;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.SteelBlue;
            pnlFormulario.Location = new Point(158, 12);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(896, 472);
            pnlFormulario.TabIndex = 2;
            pnlFormulario.Paint += panel1_Paint;
            // 
            // btnBasquet
            // 
            btnBasquet.BackColor = Color.SlateBlue;
            btnBasquet.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnBasquet.FlatStyle = FlatStyle.Flat;
            btnBasquet.ForeColor = SystemColors.ActiveCaptionText;
            btnBasquet.Location = new Point(12, 158);
            btnBasquet.Name = "btnBasquet";
            btnBasquet.Size = new Size(140, 32);
            btnBasquet.TabIndex = 5;
            btnBasquet.Text = "Basquet";
            btnBasquet.UseVisualStyleBackColor = false;
            btnBasquet.Click += btnBasquet_Click;
            // 
            // btnFutbol
            // 
            btnFutbol.BackColor = Color.SlateBlue;
            btnFutbol.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnFutbol.FlatStyle = FlatStyle.Flat;
            btnFutbol.ForeColor = SystemColors.ActiveCaptionText;
            btnFutbol.Location = new Point(12, 120);
            btnFutbol.Name = "btnFutbol";
            btnFutbol.Size = new Size(140, 32);
            btnFutbol.TabIndex = 4;
            btnFutbol.Text = "Futbol";
            btnFutbol.UseVisualStyleBackColor = false;
            btnFutbol.Click += btnFutbol_Click;
            // 
            // btnVoley
            // 
            btnVoley.BackColor = Color.SlateBlue;
            btnVoley.Cursor = Cursors.No;
            btnVoley.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnVoley.FlatStyle = FlatStyle.Flat;
            btnVoley.ForeColor = SystemColors.ActiveCaptionText;
            btnVoley.ImageAlign = ContentAlignment.BottomCenter;
            btnVoley.Location = new Point(12, 196);
            btnVoley.Name = "btnVoley";
            btnVoley.Size = new Size(140, 32);
            btnVoley.TabIndex = 3;
            btnVoley.Text = "Voley";
            btnVoley.TextAlign = ContentAlignment.BottomCenter;
            btnVoley.UseVisualStyleBackColor = false;
            btnVoley.Click += btnVoley_Click;
            // 
            // btnMostrarVoley
            // 
            btnMostrarVoley.BackColor = Color.DarkSlateBlue;
            btnMostrarVoley.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnMostrarVoley.FlatStyle = FlatStyle.Flat;
            btnMostrarVoley.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrarVoley.Location = new Point(12, 310);
            btnMostrarVoley.Name = "btnMostrarVoley";
            btnMostrarVoley.Size = new Size(140, 32);
            btnMostrarVoley.TabIndex = 3;
            btnMostrarVoley.Text = "Mostrar Voley";
            btnMostrarVoley.UseVisualStyleBackColor = false;
            btnMostrarVoley.Click += btnMostrarVoley_Click;
            // 
            // btnMostrarFutbol
            // 
            btnMostrarFutbol.BackColor = Color.DarkSlateBlue;
            btnMostrarFutbol.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnMostrarFutbol.FlatStyle = FlatStyle.Flat;
            btnMostrarFutbol.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrarFutbol.Location = new Point(12, 272);
            btnMostrarFutbol.Name = "btnMostrarFutbol";
            btnMostrarFutbol.Size = new Size(140, 32);
            btnMostrarFutbol.TabIndex = 4;
            btnMostrarFutbol.Text = "Mostrar Futbol";
            btnMostrarFutbol.UseVisualStyleBackColor = false;
            btnMostrarFutbol.Click += btnMostrarFutbol_Click;
            // 
            // btnMostrarBasquet
            // 
            btnMostrarBasquet.BackColor = Color.DarkSlateBlue;
            btnMostrarBasquet.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnMostrarBasquet.FlatStyle = FlatStyle.Flat;
            btnMostrarBasquet.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrarBasquet.Location = new Point(12, 234);
            btnMostrarBasquet.Name = "btnMostrarBasquet";
            btnMostrarBasquet.Size = new Size(140, 32);
            btnMostrarBasquet.TabIndex = 5;
            btnMostrarBasquet.Text = "Mostrar Basquet";
            btnMostrarBasquet.UseVisualStyleBackColor = false;
            btnMostrarBasquet.Click += btnMostrarBasquet_Click;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.BackColor = Color.DarkSlateBlue;
            lblReloj.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblReloj.Location = new Point(43, 464);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(43, 20);
            lblReloj.TabIndex = 6;
            lblReloj.Text = "Reloj";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 387);
            button1.Name = "button1";
            button1.Size = new Size(140, 32);
            button1.TabIndex = 7;
            button1.Text = "Guardar usuarios.log";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnUsuarioPath_Click;
            // 
            // lblErrorPath
            // 
            lblErrorPath.AutoSize = true;
            lblErrorPath.ForeColor = Color.Red;
            lblErrorPath.Location = new Point(12, 422);
            lblErrorPath.Name = "lblErrorPath";
            lblErrorPath.Size = new Size(56, 15);
            lblErrorPath.TabIndex = 8;
            lblErrorPath.Text = "ErrorPath";
            // 
            // btnVerLog
            // 
            btnVerLog.BackColor = Color.DarkSlateBlue;
            btnVerLog.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnVerLog.FlatStyle = FlatStyle.Flat;
            btnVerLog.ForeColor = SystemColors.ActiveCaptionText;
            btnVerLog.Location = new Point(12, 349);
            btnVerLog.Name = "btnVerLog";
            btnVerLog.Size = new Size(140, 32);
            btnVerLog.TabIndex = 9;
            btnVerLog.Text = "Ver Log";
            btnVerLog.UseVisualStyleBackColor = false;
            btnVerLog.Click += btnVerLog_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.DarkSlateBlue;
            lblPerfil.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.Location = new Point(44, 42);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(42, 20);
            lblPerfil.TabIndex = 10;
            lblPerfil.Text = "Perfil";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1080, 513);
            Controls.Add(lblPerfil);
            Controls.Add(btnVerLog);
            Controls.Add(lblErrorPath);
            Controls.Add(button1);
            Controls.Add(lblReloj);
            Controls.Add(btnVoley);
            Controls.Add(btnBasquet);
            Controls.Add(btnMostrarBasquet);
            Controls.Add(btnFutbol);
            Controls.Add(btnMostrarFutbol);
            Controls.Add(btnMostrarVoley);
            Controls.Add(pnlFormulario);
            Controls.Add(lblUsuario);
            Controls.Add(btnAgregar);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FrmMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblUsuario;
        private Panel pnlFormulario;
        private Button btnFutbol;
        private Button btnVoley;
        private Button btnBasquet;
        private Button btnMostrarVoley;
        private Button btnMostrarFutbol;
        private Button btnMostrarBasquet;
        private Label lblReloj;
        private Button button1;
        private Label lblErrorPath;
        private Button btnVerLog;
        private Label lblPerfil;
    }
}