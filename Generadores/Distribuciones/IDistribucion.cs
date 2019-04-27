using System.Collections.Generic;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public interface IDistribucion
    {
        void AsignarGenerador(IGeneradorNumerosAleatorios generador);
        float Generar();
        List<float> Generar(int cantidad);
        List<float> FrecuenciasEsperadas(List<Intervalo> intervalos);
        int CantidadParametros();
    }
}
