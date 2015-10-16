using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cambiaAtributo
{
    class VariableEntorno
    {
        string variableName;
        string variableValue;

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
