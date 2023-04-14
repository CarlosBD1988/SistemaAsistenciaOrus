using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaAsistenciaOrus.Logica;
using SistemaAsistenciaOrus.Datos;

namespace SistemaAsistenciaOrus.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = false;
            panelPaginado.Visible = false;
            panelRegistros.Visible = true;
            panelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            LimpiarInputs();

        }
        private void LimpiarInputs()
        {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtCargo.Clear();
            txtSueldoHora.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = false;
        }
    }
}
