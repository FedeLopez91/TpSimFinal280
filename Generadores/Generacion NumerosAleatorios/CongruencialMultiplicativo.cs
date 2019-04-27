using System;

namespace NumerosAleatorios.NumerosAleatorios
{
    public class CongruencialMultiplicativo : IGeneradorNumerosAleatorios
    {
        public float Semilla { get; protected set; }
        public float A { get; protected set; }
        public float M { get; protected set; }

        public CongruencialMultiplicativo(float semilla, float a, float m)
        {
            Semilla = semilla;
            A = a;
            M = m;
        }

        public float Generar()
        {
            var aleatorio = (A * Semilla) % M;

            Semilla = aleatorio;

            return aleatorio / M;
        }

        public int Generar(int cifras)
        {
            var aleatorio = Generar();

            return (int)(aleatorio * Math.Pow(10, cifras));
        }
    }
}
