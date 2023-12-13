using Tools;
using Entidades;
using Forms;

namespace FrmLogin
{
    public partial class FrmLogin1 : Form
    {
        private Usuario usuario;
        private List<Usuario> usuariosRegistrados;
        private string pathUsuariosRegistrados = "MOCK_DATA.json";
        public FrmLogin1()
        {
            InitializeComponent();
            this.usuario = new Usuario();
            this.usuariosRegistrados = new List<Usuario>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblError.Text = string.Empty;
            this.CargarUsuarios();
            FrmMenuPrincipal.CambiarColoresControles(this.Controls, this, true);
        }


        /// <summary>
        /// Levanta la lista de usuarios guardad en el archivo .json, si hay algun error, muestra un messagebox
        /// </summary>
        public void CargarUsuarios()
        {
            List<Usuario>? listAux = Archivo.LeerArchivoJson<Usuario>(this.pathUsuariosRegistrados);
            if (listAux != null)
            {
                this.usuariosRegistrados = listAux;
            }
            else
            {
                MessageBox.Show("Error al Leer los usuarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lblError.Text = "No podrá iniciar seción";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuarioAux = new Usuario(this.txtMail.Text, this.txtContraseña.Text);

            try
            {
                int indexUser = Usuario.FindUser(usuarioAux, this.usuariosRegistrados);
                MessageBox.Show(usuarioAux.ToString());
                this.usuario = this.usuariosRegistrados[indexUser];
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(this.usuariosRegistrados, this.usuario, this.pathUsuariosRegistrados, this.usuario.Perfil);
                frmMenuPrincipal.ShowDialog();
                this.Visible = false;

                if (frmMenuPrincipal.DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (ExcepcionUsuarioInexistente ex)
            {
                this.lblError.Text = $"{ex.mensaje}";
                MessageBox.Show(usuarioAux.ToString());
            }
            catch (Exception ex)
            {
                this.lblError.Text = $"Otro error inesperado: {ex.Message}";
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse frmRegistrarse = new FrmRegistrarse(this.usuariosRegistrados);
            frmRegistrarse.ShowDialog();
        }
    }
}