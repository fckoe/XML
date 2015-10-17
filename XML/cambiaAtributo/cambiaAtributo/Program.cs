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

            string nombreVariable = ConfigurationManager.AppSettings["variableEntorno"].ToString();
            string rutaVariable = null;
            string valorWebService = null;
            string rutaInstalación = null;
            Console.WriteLine(nombreVariable);
            Console.ReadLine();
            Xml xml = new Xml();
            XmlDocument xmlDoc = new XmlDocument();
            


            try
            {
                rutaVariable = xml.obtieneValorVariable(nombreVariable);
                if (rutaVariable != null)
                {
                    valorWebService = ConfigurationManager.AppSettings["nuevaRutaWebService"].ToString();
                    rutaInstalación = ConfigurationManager.AppSettings["rutaInstalacion"].ToString();

                    xml.setRutaXml(rutaVariable+rutaInstalación);
                    xmlDoc.Load(xml.getRutaXml());


                }
                else {
                    Console.WriteLine("Variable no tiene valor");
                }
                
            }
            catch (Exception e) {
                Console.Clear();
                Console.WriteLine("Error en la aplicación Contactese con casa central "+e.Message);

            }




          //if (xml.existeVariable
        }
    }
}
