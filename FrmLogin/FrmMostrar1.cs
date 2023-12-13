using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FrmMostrar1 : Form
    {
        private Tabla tabla;
        private EDeporte deporteSeleccionado;
        private Equipo equipoSeleccionado;

        public FrmMostrar1()
        {
            InitializeComponent();
            this.tabla = new Tabla();
        }

        public FrmMostrar1(Tabla tabla, EDeporte deporte) : this()
        {
            this.tabla = tabla;
            this.deporteSeleccionado = deporte;
        }


        private void FrmMostrar1_Load(object sender, EventArgs e)
        {
            FrmMenuPrincipal.CambiarColoresControles(this.Controls, this, true);
            switch (deporteSeleccionado)
            {
                case EDeporte.Futbol:
                    this.dtgMostrar.DataSource = this.tabla.ListaFutbol;
                    ActualizarDataGridView();
                    break;
                case EDeporte.Basquet:
                    this.dtgMostrar.DataSource = this.tabla.ListaBasquet;
                    ActualizarDataGridView();
                    break;
                case EDeporte.Voley:
                    this.dtgMostrar.DataSource = this.tabla.ListaVoley;
                    ActualizarDataGridView();
                    break;
            };
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            List<Jugador>? list = new List<Jugador>();
            list = this.equipoSeleccionado.Jugadores;

            if (this.dtgMostrar.SelectedRows.Count > 0)
            {
                this.dtgMostrar.DataSource = null;
                this.dtgMostrar.DataSource = list;
            }

        }

        private void dtgMostrar_SelectionChanged(object sender, EventArgs e)
        {

            if (this.dtgMostrar.SelectedRows.Count > 0)
            {
                int index = this.dtgMostrar.SelectedRows[0].Index;

                if (index >= 0)
                {
                    try
                    {
                        switch (this.deporteSeleccionado)
                        {
                            case EDeporte.Futbol:
                                this.equipoSeleccionado = this.tabla.ListaFutbol[index];
                                break;
                            case EDeporte.Voley:
                                this.equipoSeleccionado = this.tabla.ListaVoley[index];
                                break;
                            case EDeporte.Basquet:
                                this.equipoSeleccionado = this.tabla.ListaBasquet[index];
                                break;
                        };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ActualizarDataGridView()
        {
            this.dtgMostrar.DataSource = null;

            switch (this.deporteSeleccionado)
            {
                case EDeporte.Futbol:
                    this.dtgMostrar.DataSource = this.tabla.ListaFutbol;
                    break;
                case EDeporte.Voley:
                    this.dtgMostrar.DataSource = this.tabla.ListaVoley;
                    break;
                case EDeporte.Basquet:
                    this.dtgMostrar.DataSource = this.tabla.ListaBasquet;
                    break;

            };
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoDatosEquipo db = new AccesoDatosEquipo();
            bool confirmacion = false;
            if (PreguntarEliminar())
            {
                switch (this.deporteSeleccionado)
                {
                    case EDeporte.Futbol:
                        this.tabla.ListaFutbol.Remove((Futbol)this.equipoSeleccionado);
                        confirmacion = db.EliminarEquipo((Futbol)this.equipoSeleccionado);
                        break;
                    case EDeporte.Voley:
                        this.tabla.ListaVoley.Remove((Voley)this.equipoSeleccionado);
                        confirmacion = db.EliminarEquipo((Voley)this.equipoSeleccionado);
                        break;
                    case EDeporte.Basquet:
                        this.tabla.ListaBasquet.Remove((Basquet)this.equipoSeleccionado);
                        confirmacion = db.EliminarEquipo((Basquet)this.equipoSeleccionado);
                        break;
                }

                if (confirmacion)
                {
                    MessageBox.Show("Equipo eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.ActualizarDataGridView();
        }

        private bool PreguntarEliminar()
        {
            bool retorno = false;
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este equipo?", "Eliminar Equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                retorno = true;
            }
            return retorno;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (this.deporteSeleccionado)
            {
                case EDeporte.Futbol:
                    FrmFutbol frmFutbol = new FrmFutbol(this.tabla, (Futbol)this.equipoSeleccionado);
                    frmFutbol.ShowDialog();
                    break;
                case EDeporte.Voley:
                    FrmVoley frmVoley = new FrmVoley(this.tabla, (Voley)this.equipoSeleccionado);
                    frmVoley.ShowDialog();
                    break;
                case EDeporte.Basquet:
                    FrmBasquet frmBasquet = new FrmBasquet(this.tabla, (Basquet)this.equipoSeleccionado);
                    frmBasquet.ShowDialog();
                    break;
            };
        }

        private void btnDescendiente_Click(object sender, EventArgs e)
        {

            this.tabla.ListaFutbol = Futbol.OrdenarPorNombre(this.tabla.ListaFutbol, false);
            this.ActualizarDataGridView();

            this.tabla.ListaVoley = Voley.OrdenarPorNombre(this.tabla.ListaVoley, false);
            this.ActualizarDataGridView();

            this.tabla.ListaBasquet = Basquet.OrdenarPorNombre(this.tabla.ListaBasquet, false);
            this.ActualizarDataGridView();


        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {

            this.tabla.ListaFutbol = Futbol.OrdenarPorNombre(this.tabla.ListaFutbol, true);
            this.ActualizarDataGridView();


            this.tabla.ListaVoley = Voley.OrdenarPorNombre(this.tabla.ListaVoley, true);
            this.ActualizarDataGridView();


            this.tabla.ListaBasquet = Basquet.OrdenarPorNombre(this.tabla.ListaBasquet, true);
            this.ActualizarDataGridView();


        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(this.equipoSeleccionado.PresentarFormacion());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.ActualizarDataGridView();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            FrmJugador frmJugador = new FrmJugador(this.equipoSeleccionado);
            frmJugador.ShowDialog();


        }
    }

}