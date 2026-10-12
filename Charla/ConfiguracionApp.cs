using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Charla
{
    public static class ConfiguracionApp
    {
        public static double SalarioMinimo { get; private set; } = 500; // valor por defecto

        public static void CargarConfiguracion(string rutaArchivo)
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    throw new FileNotFoundException("No se encontró el archivo config.xml");
                }

                XmlDocument doc = new XmlDocument();
                doc.Load(rutaArchivo);

                XmlNode nodo = doc.SelectSingleNode("//SalarioMinimo");
                if (nodo != null)
                {
                    SalarioMinimo = Convert.ToDouble(nodo.InnerText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo leer config.xml, se usará el valor por defecto.\nDetalle: {ex.Message}",
                    "Aviso de configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
