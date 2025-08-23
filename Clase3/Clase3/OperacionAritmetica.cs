using System;

namespace Clase3_ProgramacionObjetos
{
    class OperacionAritmetica
    {
        // Propiedades
        // Sintaxis: modificadorAcceso tipoDato Nombre { get; set; }
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        // Método que imprime la suma directamente
        public void ImprimirSuma()
        {
            int resultadoSuma = Sumar(Numero1, Numero2);
            Console.WriteLine("La suma es: " + resultadoSuma);
        }

        // Método que retorna la suma
        public int Sumar(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
    }
}
