using Models;
using NumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Simulacion
{
    public class ManejadorSimulacion
    {

        public DataTable Simular(string tipoFuncion, int cantIteraciones, int mostrarDesde, int cantAMostrar, Restricciones[] restricciones, FunctionZ functionZ, GestorEstadistico numerosAleatorios)
        {
            DataTable tabla = new DataTable();
            var mostrarHasta = mostrarDesde + cantAMostrar;

            //NRO ITERACION
            tabla.Columns.Add("#");
            //VARIABLES
            for (int i = 1; i <= functionZ.variables.Length; i++)
            {
                tabla.Columns.Add("RND X"+i);
                tabla.Columns.Add("X"+i);
            }
            var randomVariables = new double[functionZ.variables.Length];
            //RESTRICCIONES
            for (int i = 1; i <= restricciones.Length; i++)
            {
                tabla.Columns.Add("R" + i);
                tabla.Columns.Add("VÁLIDO R" + i);
            }
            //FUNCION Z
            tabla.Columns.Add("Z");
            //FUNCION Z OPTIMA
            tabla.Columns.Add("Z OPT");
            //VARIABLES OPTIMAS
            for (int i = 1; i <= functionZ.variables.Length; i++)
            {
                tabla.Columns.Add("X" + i+ " OPT");
            }

            var random = numerosAleatorios.Distribucion;

            String[] vector = new String[tabla.Columns.Count];

            for (int j = 1; j <= cantIteraciones; j++)

            {
                //NUMERO ITERACION
                vector[0] = j.ToString();

                //VARIABLES
                var posicionVector = 1;
                for (int i = 0; i < randomVariables.Length; i++)
                {
                    double rndvariable = random.Generar();
                    randomVariables[i] = rndvariable;
                    vector[posicionVector] = rndvariable.ToString();
                    posicionVector++;
                    vector[posicionVector] = Math.Round((decimal)rndvariable, 4).ToString();
                    posicionVector++;
                }

                ////RESTRICIONES
                var restriccionesresult = new List<string>();
                for (int i = 0; i < restricciones.Length; i++)
                {
                    double restriccionTotal = 0;
                    for (int h = 0; h < restricciones[i].variables.Length; h++)
                    {
                        restriccionTotal += randomVariables[h] * restricciones[i].variables[h];
                    }
                    vector[posicionVector] = restriccionTotal.ToString();
                    posicionVector++;
                }
                //double restriccion1 = double.Parse(vector[2]) * restricciones[0].variables[0] + (double.Parse(vector[4]) * restricciones[0].variables[1]);
                //vector[5] = restriccion1.ToString();
                //var restriccValid1 = GetValidacionRestriccion(restriccion1, restricciones[0]);
                //restriccionesresult.Add(restriccValid1);
                //vector[6] = restriccValid1;

                //double restriccion2 = double.Parse(vector[2]) * restricciones[1].variables[0] + (double.Parse(vector[4]) * restricciones[1].variables[1]);
                //vector[7] = restriccion2.ToString();
                //var restriccValid2 = GetValidacionRestriccion(restriccion2, restricciones[1]);
                //restriccionesresult.Add(restriccValid2);
                //vector[8] = restriccValid2;

                //double restriccion3 = (double.Parse(vector[2]) * restricciones[2].variables[0]) + double.Parse(vector[4]) * restricciones[2].variables[1];
                //vector[9] = restriccion3.ToString();
                //var restriccValid3 = GetValidacionRestriccion(restriccion3, restricciones[2]);
                //restriccionesresult.Add(restriccValid3);
                //vector[10] = restriccValid3;

                //FUNCTION Z
                var isValid = restriccionesresult.Where(x => x == "NO").FirstOrDefault();
                if (isValid== null)
                {
                    double funcionZResult = (double.Parse(vector[2]) * functionZ.variables[0]) + (double.Parse(vector[4]) * functionZ.variables[1]) + functionZ.c;
                    vector[11] = funcionZResult.ToString();
                    if (string.IsNullOrEmpty(vector[12]) || double.Parse(vector[12]) <= funcionZResult)
                    {
                        vector[12] = funcionZResult.ToString();
                        vector[13] = vector[4];
                        vector[14] = vector[2];

                    }
                }

                if (j >= mostrarDesde && j <= mostrarHasta)
                    tabla.LoadDataRow(vector, true);
            }

            tabla.LoadDataRow(vector, true);

            return tabla;
        }

        private string GetValidacionRestriccion(double restriccionValor, Restricciones restriccion)
        {
            var signo = restriccion.sign;
            string resp = "NO";

            switch (signo)
            {
                case "=":
                    if (restriccionValor == restriccion.b)
                    {
                        resp = "SI";
                    }
                    break;
                case "<":
                    if (restriccionValor < restriccion.b)
                    {
                        resp = "SI";
                    }
                    break;
                case "<=":
                    if (restriccionValor <= restriccion.b)
                    {
                        resp = "SI";
                    }
                    break;
                case ">":
                    if (restriccionValor > restriccion.b)
                    {
                        resp = "SI";
                    }
                    break;
                case ">=":
                    if (restriccionValor >= restriccion.b)
                    {
                        resp = "SI";
                    }
                    break;
                default:
                    break;
            }
            return resp;
        }

    }
}
