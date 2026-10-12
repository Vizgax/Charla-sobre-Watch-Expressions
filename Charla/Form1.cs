using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Charla
{
    public partial class Escenario_1 : Form
    {
        private List<Empleado> empleados;

        public Escenario_1()
        {
            InitializeComponent();

            empleados = new List<Empleado>();
            empleados.Add(new Empleado { Id = 1, Nombre = "Ana López", Puesto = "Analista", Salario = 850 });
            empleados.Add(new Empleado { Id = 2, Nombre = "Luis Gómez", Puesto = "Soporte", Salario = 450 });

            dgvEmpleados.DataSource = empleados;
        }

        // Constructor alterno: cuando regresas desde otro escenario,
        // ya con la lista actualizada (no se pierde lo agregado)
        public Escenario_1(List<Empleado> listaEmpleados)
        {
            InitializeComponent();

            empleados = listaEmpleados;
            dgvEmpleados.DataSource = empleados;
        }

        private void BTN_Cam_Click(object sender, EventArgs e)
        {
            Escenario_2 Cambio = new Escenario_2(empleados);
            this.Hide();
            Cambio.Show();
        }
    }
}