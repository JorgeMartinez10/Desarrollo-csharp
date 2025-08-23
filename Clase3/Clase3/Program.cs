using System;

namespace Clase3_ProgramacionObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar la clase (crear un objeto de una clase)
            // Sintaxis: Clase elObjeto = new Clase();

            OperacionAritmetica op1 = new OperacionAritmetica();

            // Asignar valores a las propiedades
            op1.Numero1 = 5;
            op1.Numero2 = 10;

            // Usar el método de la clase
            op1.ImprimirSuma();
        }
    }
}
