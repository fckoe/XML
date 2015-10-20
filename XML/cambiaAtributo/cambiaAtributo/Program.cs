using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Configuration;
using cambiaAtributo;

namespace cambiaAtributo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("00. Inicializar Variables");
            string nombreVariable = ConfigurationManager.AppSettings["variableEntorno"].ToString();
            string rutaVariable = null;
            string valorWebService = null;
            string rutaInstalacion = null;
            string rutaNodo = null;
            Xml xml = new Xml();
            XmlDocument xmlDoc = new XmlDocument();
            


            try
            {
                rutaVariable = xml.obtieneValorVariable(nombreVariable);

                Console.WriteLine("10. Validar Variable de Entorno ");
                if (rutaVariable != null)
                {
                    Console.WriteLine("20. Obtener Valores de App.Config");
                    valorWebService = ConfigurationManager.AppSettings["nuevaRutaWebService"].ToString();
                    rutaInstalacion = ConfigurationManager.AppSettings["rutaInstalacion"].ToString();
                    rutaNodo = ConfigurationManager.AppSettings["rutaNodoWebService"].ToString();

                    xml.setRutaXml(rutaVariable + rutaInstalacion);
                    xml.setNombreAtributo(ConfigurationManager.AppSettings["nombreAtributo"].ToString());
                    Console.WriteLine("30. Abrir XML de configuracion de impresora");
                    xmlDoc.Load(xml.getRutaXml());

                    Console.WriteLine("40. Obtener nodo de XML de impresion");
                    XmlNode node = xmlDoc.SelectSingleNode(rutaNodo);
                    Console.WriteLine("50. Cambiar valor del atributo "+xml.getNombreAtributo());
                    node.Attributes[xml.getNombreAtributo()].Value = valorWebService;
                    Console.WriteLine("60. Guardar XML de configuración de impresora");
                    xmlDoc.Save(xml.getRutaXml());
                    Console.WriteLine("70. Fin. ## PRESIONE UNA TECLA PARA CERRAR LA APLICACION ##");
                    Console.WriteLine(" hola mundo");
                    Console.ReadLine();
   
                    


                }
                else {
                    Console.WriteLine("15. Variable de entorno "+nombreVariable+" no tiene valor. Presione una tecla para salir.");
                    Console.ReadLine();
                }
                
            }
            catch (Exception e) {
                Console.WriteLine(" 18. Error en la aplicación Contactese con casa central "+e.Message);
                Console.ReadLine();

            }




          //if (xml.existeVariable
        }
    }
}
