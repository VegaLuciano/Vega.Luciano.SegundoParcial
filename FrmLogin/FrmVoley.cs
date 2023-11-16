using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace Forms
{
    public partial class FrmVoley : FrmCRUD1
    {
        private Voley equipoModificar;
        public FrmVoley(Tabla listaEquipo) : base(listaEquipo)
        {
            InitializeComponent();
            this.equipoModificar = new Voley();
        }
        public FrmVoley(Tabla listaEquipo, Voley equipo) : this(listaEquipo)
        {
            this.seModifica = true;
            this.equipoModificar = equipo;
        }
        private void FrmVoley_Load(object sender, EventArgs e)
        {
            this.cmbCancha.Items.AddRange(Enum.GetNames(typeof(ECancha)));
            if (seModifica == true)
            {
                SetearFormModificar();
            }
        }

        protected void SetearFormModificar()
        {
            this.txtNombre.Text = this.equipoModificar.Nombre;
            this.txtNombreEntrenador.Text = this.equipoModificar.Entrenador;
            this.cmbDivision.SelectedItem = this.equipoModificar.Division.ToString();
            this.npdCantJugadores.Value = this.equipoModificar.Jugadores.Count;
            this.npdCantSuplentes.Value = this.equipoModificar.CantSuplentes;
            this.npdCantTitulares.Value = this.equipoModificar.CantTitulares;
            this.cmbCancha.SelectedItem = this.equipoModificar.Cancha;
            this.txtSedeEquipo.Text = this.equipoModificar.SedeDelEquipo;
            this.listJugadores = this.equipoModificar.Jugadores;
        }

        public ECancha SetearCampoCancha()
        {
            ECancha retorno;
            if (this.cmbDivision.SelectedIndex == 0)
            {
                retorno = ECancha.Playa;

            }
            else
            {
                retorno = ECancha.Cemento;
            }

            return retorno;
        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            if (base.FuncionContinuar())
            {
                if (this.cmbCancha.SelectedIndex > -1)
                {
                    if (Validaciones.ValidarCampo(this.txtSedeEquipo.Text))
                    {
                        Voley EquipoVoley = new Voley(this.txtNombre.Text, (int)this.npdCantTitulares.Value, base.SetearCampoDivision(), this.txtNombreEntrenador.Text,
                            SetearCampoCancha(), this.txtSedeEquipo.Text, EDeporte.Voley, (int)this.npdCantSuplentes.Value);

                        EquipoVoley.Jugadores = this.listJugadores;
                        MessageBox.Show(EquipoVoley.ToString());
                        MessageBox.Show("Se cargó todo exitosamente!");
                        this.lblErrorSede.Text = string.Empty;
                        this.lblErrorCancha.Text = string.Empty;
                        if (seModifica == true)
                        {
                            int indice = this.tabla.ListaVoley.IndexOf(this.equipoModificar);

                            if (indice >= 0)
                            {
                                // Reemplaza el objeto en la misma posición.
                                this.tabla.ListaVoley[indice] = EquipoVoley;
                            }
                            this.Close();
                        }
                        else
                        {
                            this.tabla.ListaVoley.Add(EquipoVoley);
                        }
                    }
                    else
                    {
                        this.lblErrorSede.Text = "Error, seleccione sede invalida";
                    }
                }
                else
                {
                    this.lblErrorCancha.Text = "Error, seleccione un color";
                }

            }

        }
    }
}
