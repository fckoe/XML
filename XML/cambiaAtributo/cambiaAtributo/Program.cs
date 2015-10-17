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
            string rutaInstalacion = null;
            string rutaNodo = null;
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
                    rutaInstalacion = ConfigurationManager.AppSettings["rutaInstalacion"].ToString();
                    rutaNodo = ConfigurationManager.AppSettings["rutaNodoWebService"].ToString();

                    xml.setRutaXml(rutaVariable + rutaInstalacion);
                    xml.setNombreAtributo(ConfigurationManager.AppSettings["nombreAtributo"].ToString());
                    xmlDoc.Load(xml.getRutaXml());

                    
                    XmlNode node = xmlDoc.SelectSingleNode(rutaNodo);
                    node.Attributes[xml.getNombreAtributo()].Value = valorWebService;
                    xmlDoc.Save(xml.getRutaXml());
                    Console.ReadLine();
   
                    


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
