using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FunctionZ
    {
        public double[] variables;
        public double c;
        public bool isExtrMax;

        public FunctionZ(double[] variables, double c, bool isExtrMax)
        {
            this.variables = variables;
            this.c = c;
            this.isExtrMax = isExtrMax;
        }

        public FunctionZ(double[] variables, double c)
        {
            this.variables = variables;
            this.c = c;
        }
    }
}
