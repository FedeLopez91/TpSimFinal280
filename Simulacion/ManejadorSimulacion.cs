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

                //CALCULO VARIABLES
                var randomVariables = new double[functionZ.variables.Length];
                var posicionVector = 1;
                for (int i = 0; i < randomVariables.Length; i++)
                {
                    double rndvariable = random.Generar();
                    randomVariables[i] = Math.Round((double)rndvariable, 4);
                    vector[posicionVector] = rndvariable.ToString();
                    posicionVector++;
                    vector[posicionVector] = randomVariables[i].ToString();
                    posicionVector++;
                }

                ////CALCULO RESTRICIONES
                var restriccionesresult = new List<string>();
                for (int i = 0; i < restricciones.Length; i++)
                {
                    double restriccionTotal = 0;
                    for (int h = 0; h < restricciones[i].variables.Length; h++)
                    {
                        restriccionTotal += randomVariables[h] * restricciones[i].variables[h];
                    }
                    vector[posicionVector] = Math.Round((decimal)restriccionTotal, 4).ToString();
                    posicionVector++;
                    var restriccValid = GetValidacionRestriccion(restriccionTotal, restricciones[i]);
                    restriccionesresult.Add(restriccValid);
                    vector[posicionVector] = restriccValid;
                    posicionVector++;
                }

                //FUNCTION Z
                var isValid = restriccionesresult.FirstOrDefault(x => x == "NO");
                if (isValid == null)
                {
                    double funcionZResult = 0;
                    for (int i = 0; i < randomVariables.Length; i++)
                    {
                        funcionZResult += (randomVariables[i]*functionZ.variables[i]);
                    }

                    funcionZResult += functionZ.c;
                    vector[posicionVector] = Math.Round((decimal)funcionZResult, 4).ToString();
                    posicionVector++;

                    if (string.IsNullOrEmpty(vector[posicionVector]) || double.Parse(vector[posicionVector]) <= funcionZResult)
                    {
                        vector[posicionVector] = Math.Round((decimal)funcionZResult, 4).ToString();
                        posicionVector++;
                        for (int i = 0; i < randomVariables.Length; i++)
                        {
                            vector[posicionVector] = randomVariables[i].ToString();
                            posicionVector++;
                        }

                    }
                }
                else
                {
                    vector[posicionVector] = "";
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
