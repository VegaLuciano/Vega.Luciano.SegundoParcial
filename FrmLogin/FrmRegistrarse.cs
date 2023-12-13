using Entidades;
using Tools;

namespace Forms
{
    public partial class FrmRegistrarse : Form
    {
        public List<Usuario> listaUsuarios;
        public FrmRegistrarse(List<Usuario> listaUsuarios)
        {
            InitializeComponent();
            this.listaUsuarios = listaUsuarios;
        }

        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {
            this.lblErrorApellido.Text = string.Empty;
            this.lblErrorContraseña.Text = string.Empty;
            this.lblErrorEmail.Text = string.Empty;
            this.lblErrorNombre.Text = string.Empty;
            this.lblErrorRepContraseña.Text = string.Empty;
            FrmMenuPrincipal.CambiarColoresControles(this.Controls, this, true);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            bool allOk = true;
            if (!Validaciones.ValidarAtributos(this.txtNombre.Text, 1))
            {
                this.lblErrorNombre.Text = "Error, nombre invalido";
                allOk = false;
            }
            else    
                this.lblErrorNombre.Text = string.Empty;
            
            if (!Validaciones.ValidarAtributos(this.txtApellido.Text, 1))
            {
                this.lblErrorApellido.Text = "Error, apellido invalido";
                allOk = false;
            }
            else
                this.lblErrorApellido.Text = string.Empty;

            if (!Validaciones.ValidarAtributos(this.txtMail.Text, 2))
            {
                this.lblErrorEmail.Text = "Error, mail invalido";
                allOk = false;
            }
            else
            { 
                if (Usuario.CampoRepetido(this.txtMail.Text, this.listaUsuarios))
                {
                    this.lblErrorEmail.Text = "Error, el mail ya esta registrado";
                    allOk = false;
                }
                else
                    this.lblErrorEmail.Text = string.Empty;
            }

            int validarContraseña = Usuario.ValidarContraseña(this.txtContraseña.Text);

            switch (validarContraseña)
            {
                case 1:
                    this.lblErrorContraseña.Text = "Error, contraseña demasiado corta";
                    allOk = false;
                    break;
                case 2:
                    this.lblErrorContraseña.Text = "Error, la contraseña debe tener una Mayúscula";
                    allOk = false;
                    break;
                case 3:
                    this.lblErrorContraseña.Text = "Error, la contraseña debe tener almenos un número";
                    allOk = false;
                    break;
                case 4:
                    this.lblErrorContraseña.Text = "Error, la contraseña debe tener almenos un caracter distinto ('/', '-', '.')";
                    allOk = false;
                    break;
                default:
                    if (this.txtContraseña.Text != this.txtRepContraseña.Text)
                    {
                        this.lblErrorRepContraseña.Text = "Las contraseñas no coinciden";    
                    }
                    else
                    {
                        this.lblErrorContraseña.Text = string.Empty;
                        this.lblErrorRepContraseña.Text = string.Empty;
                    }
                    break;
            };

            if (allOk)
            {
                this.listaUsuarios.Add(new Usuario(this.txtMail.Text, this.txtContraseña.Text, this.txtNombre.Text, this.txtApellido.Text, "vendedor"));
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
