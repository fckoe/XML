using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cambiaAtributo
{
   public  class VariableEntorno
    {


        public Boolean existeVariable( string variableName) {
            if (Environment.GetEnvironmentVariable(variableName) == null)
            {
                return false;
            }
            else {
                return true;
            }
        }

        public string obtieneValorVariable( string variableName) {

            if (existeVariable(variableName))
            {
                return Environment.GetEnvironmentVariable(variableName);
            }
            else {
                return "Variable no esta definida";
            }

        }

    }
}
