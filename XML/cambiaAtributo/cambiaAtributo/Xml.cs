using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using cambiaAtributo;

namespace cambiaAtributo 
{
    class Xml : VariableEntorno
    {

        string rutaXml;
        string nombreAtributo;
        

        /*
         * CONSTRUCTOR 
         */
        public Xml()
        {
            this.rutaXml = "";
            this.nombreAtributo = "";
        }


        /*
         * GETTER AND SETTER
         */
        public string getRutaXml() {
            return this.rutaXml;
        }
        public string getNombreAtributo() {
            return this.nombreAtributo;
        }

   

        public void setRutaXml(string rutaXml) {
            this.rutaXml = rutaXml;
        }

        public void setNombreAtributo(string nombreAtributo) {
            this.nombreAtributo = nombreAtributo;
        }

    


        /*
         * FUNCTIONS AND METHODS
         */
        



   
    }
}
