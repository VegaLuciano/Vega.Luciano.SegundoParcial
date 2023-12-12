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
    public partial class FrmLog : Form
    {
        List<string> lista;
        public FrmLog(List<string> lista)
        {
            this.lista = lista;
            InitializeComponent();
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Logs", typeof(string));

            // Agregar filas al DataTable con los elementos de la lista
            foreach (var cadena in lista)
            {
                dataTable.Rows.Add(cadena);
            }

            // Asignar el DataTable como DataSource del DataGridView
            this.dtgLog.DataSource = dataTable;
            this.dtgLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configurar la altura de la fila de encabezados de columnas
            this.dtgLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Obtener la última columna y configurar FillWeight
            DataGridViewColumn lastColumn = this.dtgLog.Columns[this.dtgLog.Columns.Count - 1];
            lastColumn.FillWeight = 1;  // Puedes ajustar este valor según tus necesidades
        }
    }

}
