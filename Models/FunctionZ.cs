using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FunctionZ
    {
        public float[] variables;
        public float c;
        public bool isExtrMax;

        public FunctionZ(float[] variables, float c, bool isExtrMax)
        {
            this.variables = variables;
            this.c = c;
            this.isExtrMax = isExtrMax;
        }

        public FunctionZ(float[] variables, float c)
        {
            this.variables = variables;
            this.c = c;
        }
    }
}
