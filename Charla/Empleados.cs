using System;
using System.Collections.Generic;
using System.Text;

namespace Charla
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public double Salario { get; set; }

        public bool CumpleSalarioMinimo(double salarioMinimo)
        {
            return Salario >= salarioMinimo;
        }
    }
}
