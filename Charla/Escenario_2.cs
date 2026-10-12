using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Charla
{
    public partial class Escenario_2 : Form
    {
        private List<Empleado> empleados;

        public Escenario_2(List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            empleados = listaEmpleados;
        }

        // Bloquea números mientras el usuario escribe el nombre
        private void TB_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(TB_Nom, "El nombre no puede contener números");
            }
            else
            {
                errorProvider1.SetError(TB_Nom, "");
            }
        }

        // Solo permite números y punto decimal en el salario
        private void TB_Sal_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back;

            if (!esValido)
            {
                e.Handled = true;
                errorProvider1.SetError(TB_Sal, "Solo se permiten números");
            }
            else
            {
                errorProvider1.SetError(TB_Sal, "");
            }
        }



        private void BTN_Cam1_Click(object sender, EventArgs e)
        {
            Escenario_1 Cambio1 = new Escenario_1(empleados);
            this.Hide();
            Cambio1.Show();
        }

        private void BTN_Cam2_Click(object sender, EventArgs e)
        {
            Escenario_3 Cambio2 = new Escenario_3(empleados);
            this.Hide();
            Cambio2.Show();
        }

        // Valida y agrega el nuevo empleado a la lista compartida
        private void BTN_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Utilidades.EsNombreValido(TB_Nom.Text))
                {
                    throw new ArgumentException("El nombre ingresado no es válido");
                }

                double salario = Convert.ToDouble(TB_Sal.Text); // puede lanzar FormatException

                var nuevo = new Empleado
                {
                    Id = empleados.Count + 1,
                    Nombre = TB_Nom.Text,
                    Puesto = "Sin asignar",
                    Salario = salario
                };

                empleados.Add(nuevo);

                MessageBox.Show($"Empleado '{nuevo.Nombre}' agregado correctamente",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TB_Nom.Clear();
                TB_Sal.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("El salario debe ser un número válido", "Error de formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Nombre inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}