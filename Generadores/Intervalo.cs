using System;

namespace NumerosAleatorios
{
    public class Intervalo
    {
        public float Inicio { get; set; }
        public float Fin { get; set; }

        public Intervalo(float inicio, float fin)
        {
            if (fin <= inicio)
                throw new NotSupportedException("El fin del intervalo debe ser superior al inicio");

            Inicio = inicio;
            Fin = fin;
        }
    }
}
