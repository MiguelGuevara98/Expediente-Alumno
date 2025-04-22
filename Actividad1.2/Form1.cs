using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DatosAlumnos_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string nacimiento = txtNacimiento.Text;
            string direccion = txtDireccion.Text;
            string estado = lstEstados.SelectedItem != null ? lstEstados.SelectedItem.ToString() : "No seleccionado";
            string horario = rbMatutino.Checked ? "Matutino" : (rbVespertino.Checked ? "Vespertino" : "No seleccionado");

            string mensaje = $"Nombre: {nombre}\nFecha de nacimiento: {nacimiento}\nDirección: {direccion}\nEstado: {estado}\nHorario: {horario}";

            MessageBox.Show(mensaje, "Expediente guardado");

        }
    }
}
