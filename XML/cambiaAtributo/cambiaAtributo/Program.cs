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

            string nombreVariable = ConfigurationManager.AppSettings["Url"].ToString();

            Xml xml = new Xml();


            //if (xml.existeVariable
        }
    }
}
