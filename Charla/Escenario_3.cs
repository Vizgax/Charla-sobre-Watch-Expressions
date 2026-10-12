using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Charla
{
    public partial class Escenario_3 : Form
    {
        private List<Empleado> empleados;

        public Escenario_3(List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            empleados = listaEmpleados;

            lblSalarioMinimo.Text = $"Salario mínimo actual: {ConfiguracionApp.SalarioMinimo}";
        }

        private void btnCargarConfig_Click(object sender, EventArgs e)
        {
            ConfiguracionApp.CargarConfiguracion("config.xml");
            lblSalarioMinimo.Text = $"Salario mínimo actual: {ConfiguracionApp.SalarioMinimo}";

            MessageBox.Show("Configuración recargada correctamente", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtrados = Utilidades.FiltrarPorSalarioMinimo(
                    empleados,
                    ConfiguracionApp.SalarioMinimo
                );

                dgvFiltrados.DataSource = null;
                dgvFiltrados.DataSource = filtrados;

                if (filtrados.Count == 0)
                {
                    MessageBox.Show("Ningún empleado cumple con el salario mínimo",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Escenario_2 Cambio2 = new Escenario_2(empleados);
            this.Hide();
            Cambio2.Show();
        }
    }
}