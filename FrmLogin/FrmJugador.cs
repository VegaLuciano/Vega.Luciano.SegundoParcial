using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace Forms
{
    public partial class FrmJugador : Form
    {
        public Jugador Jugador;
        public Equipo equipo;
        private int index;
        private bool seModifica;

        public FrmJugador(Equipo equipo)
        {
            this.Jugador = new Jugador();
            this.equipo = equipo;
            this.seModifica = false;
        }

        public FrmJugador(Jugador jugador, Equipo equipo, int index) : this(equipo)
        {
            this.Jugador = jugador;
            InitializeComponent();
            this.index = index;
            this.seModifica = true;
        }

        private void FrmJugador_Load(object sender, EventArgs e)
        {
            FrmCRUD1.ClearErrorLabels(this.Controls);
            this.SetearCampoDeporte();
            FrmMenuPrincipal.CambiarColoresControles(this.Controls, this, true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            bool allOk = true;

            if (!Validaciones.ValidarAtributos(this.txtNombre.Text, 1))
            {
                allOk = false;
                this.lblErrorNombre.Text = "Error, nombre invalido";
            }
            else
                this.lblErrorNombre.Text = string.Empty;

            if (!Validaciones.ValidarAtributos(this.txtApellido.Text, 1))
            {
                allOk = false;
                this.lblErrorApellido.Text = "Error, apellido invalido";
            }
            else
                this.lblErrorApellido.Text = string.Empty;

            if (Validaciones.ValidarAtributos(this.npdEdad.Text, 1))
            {
                allOk = false;
                this.lblErrorEdad.Text = "Error, Edad invalido";
            }
            else
                this.lblErrorEdad.Text = string.Empty;

            if (Validaciones.ValidarAtributos(this.npdDni.Text, 1) || this.npdDni.Text.Length > 11)
            {
                allOk = false;
                this.lblErrorDni.Text = "Error, dni invalido";
            }
            else
                this.lblErrorDni.Text = string.Empty;

            if (Validaciones.ValidarAtributos(this.txtAltura.Text, 1) || !Validaciones.EsFormtatoAlturaValido(this.txtAltura.Text))
            {
                allOk = false;
                this.lblErrorAltura.Text = "Error, altura invalido";
            }
            else
                this.lblErrorAltura.Text = string.Empty;

            if (this.cmbDivision.SelectedItem == null)
            {
                allOk = false;
                this.lblErrorDivision.Text = "Error, complete el campo";
            }
            else
                this.lblErrorDivision.Text = string.Empty;

            if (this.cmbGenero.SelectedItem == null)
            {
                allOk = false;
                this.lblErrorGenero.Text = "Error, complete el campo";
            }
            else
                this.lblErrorGenero.Text = string.Empty;

            if (allOk)
            {
                this.Jugador = new Jugador(this.txtNombre.Text, this.txtApellido.Text, (int)this.npdEdad.Value, int.Parse(this.txtAltura.Text), (int)this.npdDni.Value,
                    (EDivisiones)this.cmbDivision.SelectedItem, (EGenero)this.cmbGenero.SelectedItem, false, (EDeporte)this.cmbDeporte.SelectedItem);

                this.equipo.Jugadores.Add(this.Jugador);
                DialogResult = DialogResult.OK;
            }
        }

        public void SetearCamposModificar()
        {
            if (this.seModifica)
            {
                this.npdDni.Enabled = false;
                this.cmbDeporte.Enabled = false;
            }
        }

        private void SetearCampoDeporte()
        {
            switch (this.equipo.Deporte)
            {
                case EDeporte.Futbol:
                    this.cmbDeporte.SelectedItem = this.cmbDeporte.Items[0];
                    break;
                case EDeporte.Basquet:
                    this.cmbDeporte.SelectedItem = this.cmbDeporte.Items[1];
                    break;
                case EDeporte.Voley:
                    this.cmbDeporte.SelectedItem = this.cmbDeporte.Items[2];
                    break;
            }
        }

    }
}
