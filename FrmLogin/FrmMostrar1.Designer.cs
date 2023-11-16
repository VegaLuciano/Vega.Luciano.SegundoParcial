namespace Forms
{
    partial class FrmMostrar1
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
            dtgMostrar = new DataGridView();
            btnJugadores = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAscendente = new Button();
            btnDescendiente = new Button();
            btnPresentacion = new Button();
            btnAgregarJugador = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).BeginInit();
            SuspendLayout();
            // 
            // dtgMostrar
            // 
            dtgMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMostrar.Location = new Point(12, 12);
            dtgMostrar.MultiSelect = false;
            dtgMostrar.Name = "dtgMostrar";
            dtgMostrar.ReadOnly = true;
            dtgMostrar.RowTemplate.Height = 25;
            dtgMostrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMostrar.Size = new Size(757, 378);
            dtgMostrar.TabIndex = 0;
            dtgMostrar.SelectionChanged += dtgMostrar_SelectionChanged;
            // 
            // btnJugadores
            // 
            btnJugadores.BackColor = Color.SlateBlue;
            btnJugadores.Cursor = Cursors.No;
            btnJugadores.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnJugadores.FlatStyle = FlatStyle.Flat;
            btnJugadores.ForeColor = SystemColors.ActiveCaptionText;
            btnJugadores.ImageAlign = ContentAlignment.BottomCenter;
            btnJugadores.Location = new Point(562, 409);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(140, 27);
            btnJugadores.TabIndex = 7;
            btnJugadores.Text = "Ver Jugadores";
            btnJugadores.TextAlign = ContentAlignment.BottomCenter;
            btnJugadores.UseVisualStyleBackColor = false;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SlateBlue;
            btnEliminar.Cursor = Cursors.No;
            btnEliminar.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.ImageAlign = ContentAlignment.BottomCenter;
            btnEliminar.Location = new Point(12, 409);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 27);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SlateBlue;
            btnModificar.Cursor = Cursors.No;
            btnModificar.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.ImageAlign = ContentAlignment.BottomCenter;
            btnModificar.Location = new Point(179, 409);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 27);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.BottomCenter;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAscendente
            // 
            btnAscendente.BackColor = Color.SlateBlue;
            btnAscendente.Cursor = Cursors.No;
            btnAscendente.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAscendente.FlatStyle = FlatStyle.Flat;
            btnAscendente.ForeColor = SystemColors.ActiveCaptionText;
            btnAscendente.ImageAlign = ContentAlignment.BottomCenter;
            btnAscendente.Location = new Point(775, 12);
            btnAscendente.Name = "btnAscendente";
            btnAscendente.Size = new Size(103, 27);
            btnAscendente.TabIndex = 10;
            btnAscendente.Text = "Ascendente";
            btnAscendente.TextAlign = ContentAlignment.BottomCenter;
            btnAscendente.UseVisualStyleBackColor = false;
            btnAscendente.Click += btnAscendente_Click;
            // 
            // btnDescendiente
            // 
            btnDescendiente.BackColor = Color.SlateBlue;
            btnDescendiente.Cursor = Cursors.No;
            btnDescendiente.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnDescendiente.FlatStyle = FlatStyle.Flat;
            btnDescendiente.ForeColor = SystemColors.ActiveCaptionText;
            btnDescendiente.ImageAlign = ContentAlignment.BottomCenter;
            btnDescendiente.Location = new Point(775, 45);
            btnDescendiente.Name = "btnDescendiente";
            btnDescendiente.Size = new Size(103, 27);
            btnDescendiente.TabIndex = 11;
            btnDescendiente.Text = "Descendiente";
            btnDescendiente.TextAlign = ContentAlignment.BottomCenter;
            btnDescendiente.UseVisualStyleBackColor = false;
            btnDescendiente.Click += btnDescendiente_Click;
            // 
            // btnPresentacion
            // 
            btnPresentacion.BackColor = Color.SlateBlue;
            btnPresentacion.Cursor = Cursors.No;
            btnPresentacion.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnPresentacion.FlatStyle = FlatStyle.Flat;
            btnPresentacion.ForeColor = SystemColors.ActiveCaptionText;
            btnPresentacion.ImageAlign = ContentAlignment.BottomCenter;
            btnPresentacion.Location = new Point(338, 409);
            btnPresentacion.Name = "btnPresentacion";
            btnPresentacion.Size = new Size(140, 27);
            btnPresentacion.TabIndex = 12;
            btnPresentacion.Text = "PresentarFormacion";
            btnPresentacion.TextAlign = ContentAlignment.BottomCenter;
            btnPresentacion.UseVisualStyleBackColor = false;
            btnPresentacion.Click += btnPresentacion_Click;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.BackColor = Color.SlateBlue;
            btnAgregarJugador.Cursor = Cursors.No;
            btnAgregarJugador.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAgregarJugador.FlatStyle = FlatStyle.Flat;
            btnAgregarJugador.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarJugador.ImageAlign = ContentAlignment.BottomCenter;
            btnAgregarJugador.Location = new Point(718, 409);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(140, 27);
            btnAgregarJugador.TabIndex = 13;
            btnAgregarJugador.Text = "AgregarJugador";
            btnAgregarJugador.TextAlign = ContentAlignment.BottomCenter;
            btnAgregarJugador.UseVisualStyleBackColor = false;
            btnAgregarJugador.Visible = false;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // FrmMostrar1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(934, 460);
            Controls.Add(btnAgregarJugador);
            Controls.Add(btnPresentacion);
            Controls.Add(btnDescendiente);
            Controls.Add(btnAscendente);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnJugadores);
            Controls.Add(dtgMostrar);
            Name = "FrmMostrar1";
            Text = "FrmMostrar";
            Load += FrmMostrar1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgMostrar;
        private Button btnJugadores;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAscendente;
        private Button btnDescendiente;
        private Button btnPresentacion;
        private Button btnAgregarJugador;
    }
}