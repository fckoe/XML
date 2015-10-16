using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cambiaAtributo
{
    class Xml
    {
        string variableName;
        string variableValue;

        /*
         * CONSTRUCTOR 
         */
        public Xml()
        {
        }


        /*
         *  GETTER AND SETTER
         */
        public void setVariableName(string variableName)
        {
            this.variableName = variableName;
        }

        public void setVariableValue(string variableValue)
        {
            this.variableValue = variableValue;
        }

        public string getVariableName()
        {
            return this.variableName;
        }

        public string getVariableValue()
        {
            return this.variableValue;
        }
    }
}
