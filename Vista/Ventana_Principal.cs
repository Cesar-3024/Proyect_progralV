using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Programacios_lV_Grupo6.Modelo;

namespace Proyecto_Programacios_lV_Grupo6
{
    public partial class Ventana_Principal : Form
    {
        public Ventana_Principal()
        {
            InitializeComponent();
        }

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
            txtId.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var persona = new Persona
            {
                Nombre = txtNombre.Text,
                Primer_Apellido = txtPrimer_Apellido.Text,
                Segundo_Apellido = txtSegundo_Apellido.Text,
                Celular = txtCelular.Text,
                Correo_Electronico = txtCorreo_Electronico.Text
            };

            // Verificar si CurrentRow es null antes de acceder a sus celdas
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                persona.id = id;
                GuardarOActualizarPersona(persona, id != 0);
            }
            else
            {
                GuardarOActualizarPersona(persona, false);
            }

            RefreshPantalla();
        }

        private void GuardarOActualizarPersona(Persona persona, bool actualizar)
        {
            int result = actualizar ? Funciones.ModificarBD(persona) : Funciones.AgregarPersona(persona);
            string accion = actualizar ? "modificar" : "guardar";
            string mensaje = result > 0 ? $"Éxito al {accion}" : $"Error al {accion}";
            MessageBox.Show(mensaje);
        }

        public void RefreshPantalla()
        {
            dataGridView1.DataSource = Funciones.MostrarBase();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si CurrentRow es null antes de acceder a sus celdas
            if (dataGridView1.CurrentRow != null)
            {
                txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrimer_Apellido.Text = dataGridView1.CurrentRow.Cells["Primer_Apellido"].Value.ToString();
                txtSegundo_Apellido.Text = dataGridView1.CurrentRow.Cells["Segundo_Apellido"].Value.ToString();
                txtCelular.Text = dataGridView1.CurrentRow.Cells["Celular"].Value.ToString();
                txtCorreo_Electronico.Text = dataGridView1.CurrentRow.Cells["Correo_Electronico"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dataGridView1.CurrentCell = null;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrimer_Apellido.Clear();
            txtSegundo_Apellido.Clear();
            txtCelular.Clear();
            txtCorreo_Electronico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                EliminarPersona(id);
            }
            RefreshPantalla();
        }

        private void EliminarPersona(int id)
        {
            int resultado = Funciones.EliminarPersona(id);
            string mensaje = resultado > 0 ? "Éxito al Eliminar" : "Error al Eliminar";
            MessageBox.Show(mensaje);
        }

    }
}


