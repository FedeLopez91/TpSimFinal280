using System;

namespace NumerosAleatorios.NumerosAleatorios
{
    public class CongruencialMixto : IGeneradorNumerosAleatorios
    {
        public float Semilla { get; protected set; }
        public float A { get; protected set; }
        public float C { get; protected set; }
        public float M { get; protected set; }

        public CongruencialMixto(float semilla, float a, float c, float m)
        {
            Semilla = semilla;
            A = a;
            C = c;
            M = m;
        }

        public float Generar()
        {
            var aleatorio = (A * Semilla + C) % M;

            Semilla = aleatorio;

            return aleatorio / M;
        }

        public int Generar(int cifras)
        {
            var aleatorio = Generar();

            return (int) (aleatorio * Math.Pow(10, cifras));
        }
    }
}
