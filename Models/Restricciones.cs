using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Restricciones
    {
        public double[] variables;
        public double b;
        public string sign;

        public Restricciones() { }

        public Restricciones(double[] variables, double b, string sign)
        {
            if (sign == "<=" || sign == "<" || sign == "="  || sign == ">"  || sign == ">=")
            {
                this.variables = variables;
                this.b = b;
                this.sign = sign == null ? "=" : sign ;

            }
            else
            {

                throw new ArgumentException("No se Seleccionado ningún signo");

            }
        }
    }
}
