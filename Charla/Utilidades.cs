using System;
using System.Collections.Generic;
using System.Text;

namespace Charla
{
    public static class Utilidades
    {
        public static List<Empleado> FiltrarPorSalarioMinimo(List<Empleado> lista, double minimo)
        {
            var resultado = new List<Empleado>();
            foreach (var emp in lista)
            {
                if (emp.CumpleSalarioMinimo(minimo))
                    resultado.Add(emp);
            }
            return resultado;
        }

        public static bool EsNombreValido(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return false;

            foreach (char c in nombre)
            {
                if (char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
