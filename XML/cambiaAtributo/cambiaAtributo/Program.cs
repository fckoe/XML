using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using cambiaAtributo;

namespace cambiaAtributo
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombreVariable = ConfigurationManager.AppSettings["variableEntorno"].ToString();
            Console.WriteLine(nombreVariable);
            Console.ReadLine();
            Xml xml = new Xml();

            try
            {
            }
            catch (Exception e) {
                Console.Clear();
                Console.WriteLine("Error en la aplicación Contactese con casa central");

            }




          //if (xml.existeVariable
        }
    }
}
