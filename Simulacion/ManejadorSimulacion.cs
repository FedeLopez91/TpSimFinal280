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
            tabla.Columns.Add("RND X1");
            tabla.Columns.Add("X1");
            tabla.Columns.Add("RND X2");
            tabla.Columns.Add("X2");
            //RESTRICCIONES
            tabla.Columns.Add("R1");
            tabla.Columns.Add("VÁLIDO R1");
            tabla.Columns.Add("R2");
            tabla.Columns.Add("VÁLIDO R2");
            tabla.Columns.Add("R3");
            tabla.Columns.Add("VÁLIDO R3");
            //FUNCION Z
            tabla.Columns.Add("Z");
            //FUNCION Z OPTIMA
            tabla.Columns.Add("Z OPT");
            //VARIABLES OPTIMAS
            tabla.Columns.Add("X1 OPT");
            tabla.Columns.Add("X2 OPT");

            var random = numerosAleatorios.Distribucion;

            String[] vector = new String[15];

            for (int j = 1; j <= cantIteraciones; j++)

            {
                //        Campos en común------------------------------ -
                vector[0] = j.ToString();

                double rndvariable = random.Generar();
                if (rndvariable < 0) continue;
                //VARIABLES
                vector[1] = rndvariable.ToString();
                vector[2] = Math.Round((decimal)rndvariable, 4).ToString();

                double rndvariable2 = random.Generar();
                if (rndvariable < 0) continue;

                vector[3] = rndvariable2.ToString();
                vector[4] = Math.Round((decimal)rndvariable2, 4).ToString();

                var restriccionesresult = new List<string>();
                //RESTRICIONES
                double restriccion1 = double.Parse(vector[2]) * restricciones[0].variables[0] + (double.Parse(vector[4]) * restricciones[0].variables[1]);
                vector[5] = restriccion1.ToString();
                var restriccValid1 = GetValidacionRestriccion(restriccion1, restricciones[0]);
                restriccionesresult.Add(restriccValid1);
                vector[6] = restriccValid1;

                double restriccion2 = double.Parse(vector[2]) * restricciones[1].variables[0] + (double.Parse(vector[4]) * restricciones[1].variables[1]);
                vector[7] = restriccion2.ToString();
                var restriccValid2 = GetValidacionRestriccion(restriccion2, restricciones[1]);
                restriccionesresult.Add(restriccValid2);
                vector[8] = restriccValid2;

                double restriccion3 = (double.Parse(vector[2]) * restricciones[2].variables[0]) + double.Parse(vector[4]) * restricciones[2].variables[1];
                vector[9] = restriccion3.ToString();
                var restriccValid3 = GetValidacionRestriccion(restriccion3, restricciones[2]);
                restriccionesresult.Add(restriccValid3);
                vector[10] = restriccValid3;

                //FUNCTION Z
                var isValid = restriccionesresult.Where(x => x == "NO").FirstOrDefault();
                if (isValid != null)
                {
                    double funcionZResult = (double.Parse(vector[2]) * functionZ.variables[0]) + (double.Parse(vector[4]) * functionZ.variables[1]) + functionZ.c;
                    vector[11] = funcionZResult.ToString();
                    if (string.IsNullOrEmpty(vector[11]) || double.Parse(vector[11]) < funcionZResult)
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

    //public DataTable Simular(int CantSemanas, int filasMostrar, int mostrarDesde, Distribuciones cantautos, Distribuciones tipoAuto, Distribuciones ComisionesAL, Distribuciones ComisionesAM, ref double promtotal, ref string textpromparcial)
    //{
    //    DataTable tabla = new DataTable(); //Tabla que será devuelta
    //    tabla.Columns.Add("Semana Numero:");
    //    tabla.Columns.Add("RND Cant Autos");
    //    tabla.Columns.Add("Cantidad Autos");
    //    tabla.Columns.Add("RND Tipo Auto");
    //    tabla.Columns.Add("Tipo Auto");
    //    tabla.Columns.Add("RND Comision");
    //    tabla.Columns.Add("Comision");
    //    tabla.Columns.Add("Comision Total");
    //    tabla.Columns.Add("Comision Acumulada");
    //    tabla.Columns.Add("Vendedor");

    //    var mostrarHasta = mostrarDesde + filasMostrar;
    //    Random r = new Random();
    //    double acumtotalvendedor = 0;
    //    double acum = 0;
    //    textpromparcial += "Promedio por Semana:\n";
    //    for (int i = 0; i < 4; i++) //Un bucle por vendedor
    //    {

    //        String[] vector = new String[10];
    //        long vendedor = i + 1;
    //        double promparcial = 0;


    //        for (int j = 1; j <= CantSemanas; j++)//bucle por semana

    //        {
    //            //        Campos en común------------------------------ -
    //            vector[0] = j.ToString();

    //            double rndCantAuto = cantautos.GenerarRnd(r);
    //            vector[1] = rndCantAuto.ToString();
    //            vector[2] = cantautos.ObtenerValorAsociado(rndCantAuto).ToString();
    //            String rndComisionTexto = "";
    //            String rndtipoAutoTexto = "";
    //            String tipoAutoTexto = "";
    //            String comisionTexto = "";
    //            double ComisionTotal = 0;
    //            for (int k = 0; k < int.Parse(vector[2]); k++)
    //            {
    //                double rndtipoAuto = tipoAuto.GenerarRnd(r);
    //                int tipoaut = (int)tipoAuto.ObtenerValorAsociado(rndtipoAuto);

    //                double rndcomision = Math.Truncate(r.NextDouble() * 100);
    //                double comision = buscarcomision(tipoaut, rndcomision, ComisionesAL, ComisionesAM);

    //                rndtipoAutoTexto += rndtipoAuto.ToString() + Environment.NewLine;
    //                tipoAutoTexto += buscarTipo(tipoaut) + Environment.NewLine;
    //                rndComisionTexto += (rndtipoAuto.Equals("1") ? " " : rndcomision.ToString())  + Environment.NewLine;
    //                comisionTexto += comision + Environment.NewLine;

    //                ComisionTotal = ComisionTotal + comision;
    //            }

    //            vector[3] = rndtipoAutoTexto.ToString();
    //            vector[4] = tipoAutoTexto;
    //            vector[5] = rndComisionTexto;
    //            vector[6] = comisionTexto;
    //            vector[7] = ComisionTotal.ToString();
    //            vector[8] = string.IsNullOrEmpty(vector[8]) ? vector[7] : (double.Parse(vector[8]) + double.Parse(vector[7])).ToString();
    //            vector[9] = vendedor.ToString();

    //            if (j >= mostrarDesde && j <= mostrarHasta)
    //                tabla.LoadDataRow(vector, true);
    //        }

    //        tabla.LoadDataRow(vector, true);



    //        promparcial = double.Parse(vector[8]) / CantSemanas;//acumulado/cantsemanas


    //        acumtotalvendedor += double.Parse(vector[8]);//suma los acumulados
    //        textpromparcial += "     Vendedor N°" + (i+1) + ": " + promparcial + "\n";
    //        acum += promparcial;
    //    }
    //    promtotal = acum / 4;
    //    return tabla;
    //}
}
