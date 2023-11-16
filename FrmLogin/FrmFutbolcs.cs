﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmFutbol : FrmCRUD1
    {
        private Color colorCamisetaLocal;
        private Color colorCamisetaVisitante;
        private Futbol equipoModificar;

        public FrmFutbol(Tabla listaEquipo) : base(listaEquipo)
        {
            InitializeComponent();
            this.equipoModificar = new Futbol();
        }

        public FrmFutbol(Tabla listaEquipo, Futbol equipo) : this(listaEquipo)
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
            this.btnCamisetaLocal.BackColor = this.equipoModificar.ColorCamiseteLocal;
            this.btnVisitante.BackColor = this.equipoModificar.ColorCamisetaVisitante;
            this.listJugadores = equipoModificar.Jugadores;
        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            Color defaultBackColor = Color.FromKnownColor(KnownColor.Control);

            if (base.FuncionContinuar())
            {
                if (this.colorLocal.Color != defaultBackColor)
                {

                    if (this.colorVisitante.Color != defaultBackColor)
                    {

                        Futbol EquipoFutbol = new Futbol(this.txtNombre.Text, (int)this.npdCantTitulares.Value, base.SetearCampoDivision(), this.txtNombreEntrenador.Text,
                            this.colorCamisetaLocal, this.colorCamisetaVisitante, EDeporte.Futbol, (int)this.npdCantSuplentes.Value);
                        EquipoFutbol.Jugadores = this.listJugadores;
                        MessageBox.Show(EquipoFutbol.ToString());
                        MessageBox.Show("Se cargó todo exitosamente!");
                        this.lblErrorLocal.Text = string.Empty;
                        this.lblErrorVisitante.Text = string.Empty;
                        if (seModifica == true)
                        {
                            int indice = this.tabla.ListaFutbol.IndexOf(this.equipoModificar);

                            if (indice >= 0)
                            {
                                // Reemplaza el objeto en la misma posición.
                                this.tabla.ListaFutbol[indice] = EquipoFutbol;
                            }
                            this.Close();
                        }
                        else
                        {
                            this.tabla.ListaFutbol.Add(EquipoFutbol);
                        }
                    }
                    else
                    {
                        this.lblErrorVisitante.Text = "Error, seleccione un color";
                    }
                }
                else
                {
                    this.lblErrorLocal.Text = "Error, seleccione un color";
                }

            }
        }

        private void btnCamisetaLocal_Click(object sender, EventArgs e)
        {
            if (colorLocal.ShowDialog() == DialogResult.OK)
            {
                this.colorCamisetaLocal = colorLocal.Color;
                this.btnCamisetaLocal.BackColor = this.colorLocal.Color;
            }
        }

        private void btnVisitante_Click(object sender, EventArgs e)
        {
            if (colorVisitante.ShowDialog() == DialogResult.OK)
            {
                this.btnVisitante.BackColor = this.colorVisitante.Color;
                this.colorCamisetaVisitante = colorVisitante.Color;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmFutbol_Load(object sender, EventArgs e)
        {
            if (seModifica)
                this.SetearFormModificar();
        }
    }
}
