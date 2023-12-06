using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace Forms
{
    public partial class FrmBasquet : FrmCRUD1
    {
        Basquet equipoModificar;
        public FrmBasquet(Tabla tabla) : base(tabla)
        {
            InitializeComponent();
            this.equipoModificar = new Basquet();
        }
        public FrmBasquet(Tabla listaEquipo, Basquet equipo) : this(listaEquipo)
        {
            this.seModifica = true;
            this.equipoModificar = equipo;
        }

        protected void SetearFormModificar()
        {
            this.txtNombre.Text = this.equipoModificar.Nombre;
            this.txtNombreEntrenador.Text = this.equipoModificar.Entrenador;
            this.cmbDivision.SelectedItem = this.equipoModificar.Division;
            this.npdCantJugadores.Value = this.equipoModificar.Jugadores.Count;
            this.npdCantSuplentes.Value = this.equipoModificar.CantSuplentes;
            this.npdCantTitulares.Value = this.equipoModificar.CantTitulares;
            this.txtSponsor.Text = this.equipoModificar.Sponsor;
            if (this.equipoModificar.EquipoMedico)
                this.RdbSi.Checked = true;
            else
                this.RdbSi.Checked = false;
            this.listJugadores = equipoModificar.Jugadores;
        }
        private void FrmBasquet_Load(object sender, EventArgs e)
        {
            if (seModifica)
                this.SetearFormModificar();
        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            if (FuncionContinuar())
            {
                if (Validaciones.ValidarAtributos(this.txtSponsor.Text, 1))
                {
                    if (!this.rdbNo.Checked == this.RdbSi.Checked)
                    {

                        this.lblErrorSponsor.Text = string.Empty;
                        this.lblErrorCmb.Text = string.Empty;


                        Basquet EquipoBasquet = new Basquet(this.txtNombre.Text, (int)this.npdCantTitulares.Value, base.SetearCampoDivision(), this.txtNombreEntrenador.Text,
                            this.RdbSi.Checked, this.txtSponsor.Text, EDeporte.Basquet, (int)this.npdCantSuplentes.Value);
                        
                        EquipoBasquet.Jugadores = this.listJugadores;

                        MessageBox.Show(EquipoBasquet.ToString());                    
                        AccesoDatosEquipo db = new AccesoDatosEquipo();

                        if (seModifica == true)
                        {
                            int indice = this.tabla.ListaBasquet.IndexOf(this.equipoModificar);

                            // Reemplaza el objeto en la misma posición.                                                         
                            if (db.ModificarDato(EquipoBasquet))
                            {
                                this.tabla.ListaBasquet[indice] = EquipoBasquet;
                                MessageBox.Show("Se cargó todo exitosamente!");
                            }
                            else
                            {
                                MessageBox.Show("Algo Salio Mal");
                            }
                            this.Close();
                        }
                        else
                        {

                            int filas = db.AgregarDato(EquipoBasquet);

                            if (filas == 1)
                            {
                                MessageBox.Show("Se cargó todo exitosamente!");
                                this.tabla.ListaBasquet.Add(EquipoBasquet);
                                EquipoBasquet.SetearIdEquipoJugadores();
                                AccesoDatosJugador dbJugador = new AccesoDatosJugador();
                                dbJugador.agregarJugadores(EquipoBasquet.Jugadores);
                            }
                            else
                            {
                                MessageBox.Show("Todo mal");
                            }

                            MessageBox.Show(filas.ToString());
                        }
                    }
                    else
                    {
                        this.lblErrorSponsor.Text = "Error, complete los campos";
                    }
                }
                else
                {
                    this.lblErrorSponsor.Text = "Error, sponsor invalido";
                }
            }
        }
    }
}
