using Entidades;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public List<Usuario> listaUsuarios;
        public Usuario usuario;
        private DateTime fecha;
        private string pathUsuarios;
        private string pathUsuariosRegistrados;
        private Form? formularioAcutal = null;
        public Tabla tabla;
        private Reloj reloj;

        public FrmMenuPrincipal(List<Usuario> listaUsuarios, Usuario usuario, string pathUsuariosRegistrados)
        {
            InitializeComponent();
            this.reloj = new Reloj();
            this.pathUsuariosRegistrados = pathUsuariosRegistrados;
            this.listaUsuarios = listaUsuarios;
            this.usuario = usuario;
            this.usuario.usuarioAnotado += Usuario_usuarioAnotado;
            this.fecha = DateTime.Now;
            this.pathUsuarios = "usuarios.log";
            this.lblUsuario.Text = this.usuario.Nombre;
            this.btnFutbol.Enabled = false;
            this.btnFutbol.Visible = false;
            this.btnVoley.Visible = false;
            this.btnVoley.Visible = false;
            this.btnBasquet.Visible = false;
            this.btnBasquet.Visible = false;
            this.tabla = new Tabla();
        }

        private void Usuario_usuarioAnotado(Usuario sender, InfoUsuariosEventArgs info)
        {
            MessageBox.Show($"Usuario {sender.ToString()} anotado \n {info.fecha}");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.btnFutbol.Enabled = true;
            this.btnFutbol.Visible = true;
            this.btnVoley.Visible = true;
            this.btnVoley.Visible = true;
            this.btnBasquet.Visible = true;
            this.btnBasquet.Visible = true;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.CargarEquipos();
            FrmCRUD1.ClearErrorLabels(this.Controls);
            usuario.guardarUsuario(this.usuario, this.pathUsuarios, this.fecha);
            reloj.SegundoCambiado += this.Reloj_corriendo;
            FrmMenuPrincipal.CambiarColoresControles(this.Controls, this, false);
            _ = reloj.IniciarRelojAsync(CancellationToken.None);
        }

        private void Reloj_corriendo(object sender, RelojEventArgs e)
        {
            this.lblReloj.Text = e.horaActual.ToString("HH:mm:ss");
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.GuardarArhivos();
            this.DialogResult = DialogResult.OK;
            if (MessageBox.Show("¿Estás seguro de que deseas cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            reloj.DetenerReloj();
        }

        private void GuardarArhivos()
        {
            Archivo.GuardarArchivoJson(this.pathUsuariosRegistrados, this.listaUsuarios);
        }

        private void CargarEquipos()
        {
            AccesoDatosEquipo db = new AccesoDatosEquipo();
            this.tabla.ListaBasquet = db.listaBasquet;
            this.tabla.ListaVoley = db.listaVoley;
            this.tabla.ListaFutbol = db.listaFutbol;
            this.tabla.ListaJugadores = db.listaJugadores;
            this.tabla.DesignarJugadores();
        }

        private void lblUsuario_Click_1(object sender, EventArgs e)
        {
            FrmUsuario1 frmUsuario = new FrmUsuario1(this.usuario);
            frmUsuario.ShowDialog();
        }

        private void btnVoley_Click(object sender, EventArgs e)
        {
            FrmVoley frmVoley = new FrmVoley(this.tabla);
            AbrirFormularioHijo(frmVoley);
        }

        private void btnFutbol_Click(object sender, EventArgs e)
        {
            FrmFutbol frmFutbol = new FrmFutbol(this.tabla);
            AbrirFormularioHijo(frmFutbol);
        }

        private void btnBasquet_Click(object sender, EventArgs e)
        {
            FrmBasquet frmBasquet = new FrmBasquet(this.tabla);
            AbrirFormularioHijo(frmBasquet);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AbrirFormularioHijo(Form formularioHijo)
        {

            if (formularioAcutal != null)
            {
                this.formularioAcutal.Close();
            }

            formularioAcutal = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            this.pnlFormulario.Controls.Add(formularioHijo);
            this.pnlFormulario.Tag = formularioHijo;

            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void btnMostrarVoley_Click(object sender, EventArgs e)
        {
            FrmMostrar1 frmMostrar = new FrmMostrar1(this.tabla, EDeporte.Voley);
            AbrirFormularioHijo(frmMostrar);
        }

        private void btnMostrarFutbol_Click(object sender, EventArgs e)
        {
            FrmMostrar1 frmMostrar = new FrmMostrar1(this.tabla, EDeporte.Futbol);
            AbrirFormularioHijo(frmMostrar);
        }

        private void btnMostrarBasquet_Click(object sender, EventArgs e)
        {
            FrmMostrar1 frmMostrar = new FrmMostrar1(this.tabla, EDeporte.Basquet);
            AbrirFormularioHijo(frmMostrar);
        }

        public static void CambiarColoresControles(Control.ControlCollection controles, Form form, bool esHijo)
        {
            Color colorLabel = new Color();
            if (esHijo)
            {
                form.BackColor = Color.DarkGray;
                colorLabel = Color.DarkGray;
            }
            else
            {
                form.BackColor = Color.DarkSlateGray;
                colorLabel = Color.DarkSlateGray;
            }

            foreach (Control control in controles)
            {
                if (control is System.Windows.Forms.Button)
                {
                    control.BackColor = Color.CornflowerBlue;
                    control.ForeColor = Color.Black;
                }
                else if (control is Panel)
                {
                    control.BackColor = Color.LightSlateGray;
                    control.ForeColor = Color.Black;
                }
                else if (control is System.Windows.Forms.TextBox)
                {

                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is Label)
                {
                    control.BackColor = colorLabel;
                    control.ForeColor = Color.White;
                }
            }

        }

        private void btnUsuarioPath_Click(object sender, EventArgs e)
        {
            List<string> extensiones = new List<string> { "folder" };
            string pathUsuarioslog = FrmCRUD1.LeerPath(this.lblErrorPath, extensiones);
            if (pathUsuarioslog != null)
            {
                this.pathUsuarios = pathUsuarioslog;
            }
        }

        private void btnVerLog_Click(object sender, EventArgs e)
        {
            this.verLog();
        }

        private void verLog() 
        {           
            try
            {
                if (File.Exists(this.pathUsuarios))
                {
                    string[] contenido = File.ReadAllLines(pathUsuarios);

                    if (!contenido.IsNullOrEmpty())
                    {
                        List<string> listaLogs = new List<string>();

                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < contenido.Length; i++)
                        {
                            if (i % 2 == 0) 
                            {
                                sb.AppendLine(contenido[i] + ", Fecha: " + contenido[i + 1]);
                                listaLogs.Add(sb.ToString());
                                sb.Clear(); 
                            }
                        }
                        //MessageBox.Show(listaLogs.Count.ToString());
                        FrmLog frmLog = new FrmLog(listaLogs);
                        frmLog.ShowDialog();
                    }
                }
      
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
    }
}
