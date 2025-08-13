/*
// ==========================
// EJERCICIO 1 - SUMA DE DOS NÚMEROS
// ==========================

using System; // Importa funcionalidades básicas de C#

class Ejercicio1 // Define la clase Ejercicio1
{
    static void Main(string[] args) // Método principal de la aplicación
    {
        Console.WriteLine("Ingrese el primer número:"); // Solicita el primer número
        int num1 = Convert.ToInt32(Console.ReadLine()); // Convierte el primer valor ingresado a entero

        Console.WriteLine("Ingrese el segundo número:"); // Solicita el segundo número
        int num2 = Convert.ToInt32(Console.ReadLine()); // Convierte el segundo valor ingresado a entero

        int suma = num1 + num2; // Suma ambos números
        Console.WriteLine($"La suma es: {suma}"); // Muestra el resultado
    }
}
*/

/*
// ==========================
// EJERCICIO 2 - PROMEDIO DE NOTAS
// ==========================

using System; // Importa funcionalidades básicas de C#

class Ejercicio2 // Define la clase Ejercicio2
{
    static void Main(string[] args) // Método principal
    {
        Console.WriteLine("Ingrese la primera nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine()); // Lee y convierte la primera nota

        Console.WriteLine("Ingrese la segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine()); // Lee y convierte la segunda nota

        Console.WriteLine("Ingrese la tercera nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine()); // Lee y convierte la tercera nota

        double promedio = (nota1 + nota2 + nota3) / 3; // Calcula el promedio
        Console.WriteLine($"El promedio es: {promedio}"); // Muestra el resultado
    }
}
*/

/*
// ==========================
// EJERCICIO 3 - NÚMERO PAR O IMPAR
// ==========================

using System; // Importa funcionalidades básicas

class Ejercicio3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine()); // Convierte a entero

        if (numero % 2 == 0) // Si el número es divisible entre 2
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}
*/

/*
// ==========================
// EJERCICIO 4 - TABLA DE MULTIPLICAR
// ==========================

using System;

class Ejercicio4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para ver su tabla de multiplicar:");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++) // Bucle de 1 a 10
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
*/

/*
// ==========================
// EJERCICIO 5 - CONVERSIÓN DE TEMPERATURA
// ==========================

using System;

class Ejercicio5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32; // Fórmula de conversión
        Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit}");
    }
}
*/

/*
// ==========================
// EJERCICIO 6 - INVENTARIO DE TIENDA
// ==========================

using System;

class InventarioTienda
{
    static void Main(string[] args)
    {
        string[] productos = { "Camisa", "Pantalón", "Zapatos", "Gorra" };
        int[] stock = { 10, 5, 8, 12 };

        Console.WriteLine("=== Inventario de Tienda ===");

        for (int i = 0; i < productos.Length; i++)
        {
            Console.WriteLine($"{productos[i]} - Stock: {stock[i]} unidades");
        }

        Console.WriteLine("\nIngrese el número del producto para vender (0 a 3): ");
        int indice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad a vender: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad <= stock[indice])
        {
            stock[indice] -= cantidad;
            Console.WriteLine($"Venta realizada. Nuevo stock de {productos[indice]}: {stock[indice]}");
        }
        else
        {
            Console.WriteLine("Stock insuficiente para realizar la venta.");
        }
    }
}
*/

/*
// ==========================
// EJERCICIO 7 - ENCUESTA DE SATISFACCIÓN
// ==========================

using System;

class EncuestaSatisfaccion
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Encuesta de Satisfacción ===");

        Console.WriteLine("En una escala de 1 a 5, ¿qué tan satisfecho está con el servicio recibido?");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Por favor, escriba un comentario sobre el servicio:");
        string comentario = Console.ReadLine();

        Console.WriteLine("\nGracias por su opinión.");
        Console.WriteLine($"Calificación otorgada: {calificacion}");
        Console.WriteLine($"Comentario: {comentario}");
    }
}*/

