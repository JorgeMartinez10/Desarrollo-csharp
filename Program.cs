
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// //Programacion estructurada
// //ejemplo manejo de variables

// //sintaxis de variables
// //tipoDatosAlmacenar nombreVariable = valor;
// //tipos de datos primitivos
// int edad = 30;
// Console.WriteLine($"Edad: {edad}"); //entero
// char inicial = 'J';
// Console.WriteLine($"inicial: {inicial}"); //caracter
// string nombre = "JUAN";
// Console.WriteLine($"nombre: {nombre}"); //cadena de texto
// //tipos de datos fecha
// DateTime fechaNacimiento = new DateTime(1993, 5, 15); //fecha y hora
// DateOnly fechaSolo = new DateOnly(2022, 10, 15); //solo fecha
// //booleano
// bool esEstudiante = true;
// Console.WriteLine($"esEstudiante: {esEstudiante}"); //verdarero o falso
// //tipos de datos numericos
// double altura = 1.85;
// Console.WriteLine($"altura: {altura}"); //en metros
// decimal salario = 10000.00M;
// Console.WriteLine($"Nombre: {nombre}, Inicial: {inicial}, Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}"); //en formato decimal para mayor precisión
// double peso = 70.2;
// Console.WriteLine($"peso: {peso}"); //en kilogramos
// //tipos de datos complejos

// //operaciones de variables
// int suma = edad + 5;//suma
// Console.WriteLine($"Suma de Edad + 5: {suma}");

// //sumar dos enteros
// int numero1 = 10;
// int numero2 = 20;
// int resultadoSuma = numero1 + numero2;
// Console.WriteLine($"Resultado de la suma de {numero1} y {numero2}: {resultadoSuma}");

// //ejemplo sumar dos numeros
// Console.WriteLine("Numero Uno:");
// int numeroA = Convert.ToInt32(Console.ReadLine()); //Conert para parsear un dato (conversion de tipo)
// Console.Write("Numero Dos:");
// int numeroB = int.Parse(Console.ReadLine()); //Parse para convertir un sttring a int
// int resultadoSuma2 = numeroA + numeroB;
// Console.WriteLine($"Resultado de la suma: {resultadoSuma2}");



// //conversiones de tipos
// string edadComoString = edad.ToString();




//EJERCICIO 1 CALCULO DE IMC
// 1. Solicitar al usuario los siguientes datos: NombreCompleto, edad, estatura, peso
// 2. Calcular el indice de masa corporal usando formula

// EJERCICIO 2  CONVERSOR DE MONEDAS
// 1. Solicitar al usuario el nombre y cantidad de pesos colombianos
// 2. Calcular y mostrar el equivalente de esa cantidad en dolares, euros y libras esterlinas
// 3. Mostrar la conversion con formato 

//Hacer comentarios en el codigo para describir cada parte del codigo

// EJERCICIO 1 CALCULO DE IMC
// Console.WriteLine("Ingrese su nombre completo:");
// string nombreCompleto = Console.ReadLine();
// Console.WriteLine("Ingrese su edad:");
// int edad = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese su estatura:");
// double estatura = double.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese su peso:");
// double peso = double.Parse(Console.ReadLine());

// //  Calcular el indice de masa corporal (IMC)
// double estaturaMetros = estatura / 100; // convertir cm a metros
// double IMC = peso / (estaturaMetros * estaturaMetros); // IMC = peso / (estatura * estatura)
// Console.WriteLine($"Hola {nombreCompleto}, tu IMC es: {IMC:F2}");

// Console.WriteLine("Resumen");
// Console.WriteLine($"Nombre: {nombreCompleto}");
// Console.WriteLine($"Edad: {edad}");
// Console.WriteLine($"Estatura: {estatura}");
// Console.WriteLine($"Peso: {peso}");
// Console.WriteLine($"IMC: {IMC:F2}");

//EJERCICIO 2  CONVERSOR DE MONEDAS
// Console.WriteLine("Ingrese el nombre:");
// string nombre = Console.ReadLine();
// Console.WriteLine("Ingrese la cantidad en pesos colombianos:");
// double cantidad = double.Parse(Console.ReadLine());
// double dolares = cantidad / 4000; // 1 USD ≈ 4000 COP
// double euros = cantidad / 4300; // 1 EUR ≈ 4300 COP
// double libras = cantidad / 5000; // 1 GBP ≈ 5000 COP

// Console.WriteLine($"El nombre es: {nombre}");
// Console.WriteLine($"La cantidad en pesos colombianos es: {cantidad}");
// Console.WriteLine($"La cantidad en dolares es: {dolares:F2}");
// Console.WriteLine($"La cantidad en euros es: {euros:F2}");
// Console.WriteLine($"La cantidad en libras esterlinas es: {libras:F2}");



//Estructura de desicion de if simple

// int EDAD = 18; // Definimos una variable de tipo entero
// if (edad >= EDAD)
// {
//     Console.WriteLine("Eres mayor de edad");
// }

// //Estructura de desicion de if compuesta

// if (edad >= EDAD)
// {
//     Console.WriteLine("Eres mayor de edad");
// }
// else
// {
//     Console.WriteLine("Eres menor de edad");
// }

// //Estructura de desicion anidada

// if (edad >= EDAD)
// {
//     if ()
//     { }
//     else
//     { }
// }
// else
// {
//     if ()
//         if (estudiante)
//         { }

// }

// Console.Write("Ingrese su nombre: ");
//         string nombre = Console.ReadLine() ?? "";

//         Console.Write("Ingrese la cantidad en pesos colombianos (COP): ");
//         string inputCOP = Console.ReadLine();
//         double cantidadCOP;

//         if (!double.TryParse(inputCOP, out cantidadCOP) || cantidadCOP <= 0)
//         {
//             Console.WriteLine("Cantidad en COP no válida.");
//             return;
//         }

//         double tasaUSD = 3900.0;
//         double tasaEUR = 4200.0;
//         double tasaGBP = 5000.0;

//         double enUSD = cantidadCOP / tasaUSD;
//         double enEUR = cantidadCOP / tasaEUR;
//         double enGBP = cantidadCOP / tasaGBP;

//         Console.WriteLine($"\nHola {nombre}, aquí está la conversión de {cantidadCOP:C0} COP:");
//         Console.WriteLine($"Dólares (USD): {enUSD.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
//         Console.WriteLine($"Euros (EUR): {enEUR.ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR"))}");
//         Console.WriteLine($"Libras Esterlinas (GBP): {enGBP.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB"))}");


// Console.Write("Ingrese su nombre completo: ");
//         string nombre = Console.ReadLine() ?? "";

//         Console.Write("Ingrese su edad: ");
//         string inputEdad = Console.ReadLine();
//         int edad;
//         if (!int.TryParse(inputEdad, out edad))
//         {
//             Console.WriteLine("Edad no válida.");
//             return;
//         }

//         Console.Write("Ingrese su estatura en metros (ej: 1,75): ");
//         string inputEstatura = Console.ReadLine();
//         double estatura;
//         if (!double.TryParse(inputEstatura, out estatura) || estatura <= 0)
//         {
//             Console.WriteLine("Estatura no válida.");
//             return;
//         }

//         Console.Write("Ingrese su peso en kilogramos (ej: 70): ");
//         string inputPeso = Console.ReadLine();
//         double peso;
//         if (!double.TryParse(inputPeso, out peso) || peso <= 0)
//         {
//             Console.WriteLine("Peso no válido.");
//             return;
//         }

//         double imc = peso / (estatura * estatura);

//         Console.WriteLine($"\nResumen:");
//         Console.WriteLine($"Nombre: {nombre}");
//         Console.WriteLine($"Edad: {edad}");
//         Console.WriteLine($"Estatura: {estatura} m");
//         Console.WriteLine($"Peso: {peso} kg");
//         Console.WriteLine($"Su índice de masa corporal (IMC) es: {imc:F2}");
/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Saldo inicial
        decimal saldo = 500000m;

        Console.WriteLine("=== Cajero Automático ===");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Retirar dinero");
        Console.WriteLine("3. Salir");

        // Leer la opción del usuario
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                // Consultar saldo
                Console.WriteLine($"Su saldo actual es: {saldo:C}");
                break;

            case 2:
                // Retirar dinero
                Console.WriteLine("Ingrese el monto a retirar:");
                decimal monto = Convert.ToDecimal(Console.ReadLine());

                if (monto <= 0)
                {
                    Console.WriteLine("El monto debe ser mayor a 0.");
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
                else
                {
                    saldo -= monto;
                    Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: {saldo:C}");
                }
                break;

            case 3:
                // Salir
                Console.WriteLine("Gracias por usar el cajero. ¡Hasta luego!");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}*/

//ciclos
//ciclo for:
/*for (int i = 0; i <= 6; i+=2)
{
    Console.WriteLine("Edad: ");
    sbyte edad = sbyte.Parse(Console.ReadLine());
    Console.WriteLine("Edad es: " + edad);
}

//Ciclo while: Para cuando no se sabe cuantas veces se va a repetir un bloque de codigo
Console.WriteLine("Edad: ");
    sbyte edad = sbyte.Parse(Console.ReadLine());
    sbyte edad_parametro_centinela = 99;

    while (edad != edad_parametro_centinela);
    {
        //cuando va hacer lo que se encuentra dentro del bloque de codigo
        Console.WriteLine("puede ingresar");

        Console.WriteLine("Edad: ");
        edad = sbyte.Parse(Console.ReadLine());
    }*/

    // ciclo do while: Para cuando no se sabe cuantas veces se va a repetir un bloque de codigo,
    /*sbyte edad_parametro_centinela = 99;
    Console.WriteLine("Edad: ");
    sbyte edad = sbyte.Parse(Console.ReadLine());
    do
    {
        Console.WriteLine("Edad: ");
         sbyte edad = sbyte.Parse(Console.ReadLine());
    } while (edad != edad_parametro_centinela);*/
    
    //arrays - listas (string - numeros) - diccionarios
    //array
    /*string[] nombres = { "Ana", "Maria", "Jose", "Andres"};

    foreach (var nombre in nombres)
    {
        Console.WriteLine(nombre);
    }*/

    //lista
    /*list<string> nombres = new list<string>();

    //llenar la lista
    //nombres.Capacity; //caracteristicas, en programacion propiedad o atributo
    // nombres.Add(); //acciones, en programacion metodos o funciones 
    nombres.Add("Ana");
    nombres.Add("Maria");
    nombres.Add("Juan");
    nombres.Add("Jose");

    foreach (string nombre in nombres)
    {
       Console.WriteLine(nombre); 
    }*/

    //listas de numeros
    /*List<int> anios = new List<int>();

    anios.Add(2001);
    anios.Add(2011);
    anios.Add(2025);
    anios.Add(2031);

    foreach (int anios in anios)
    {
       Console.WriteLine(anios); 
    }*/

    //dicionario (sintaxis)
    /* Dictionary<tipo dato key value> nombre_diccionario = new Dictionary<tipo dto key, value>()
    {
      {"key", "value"},
      {"key", "value"},
      {"key", "value"},
    }; */

    /*Dictionary<int, string> lista_productos = new Dictionary<int, string>()
    {
        {1, "Cebolla"},
        {2, "Mango"},
        {3, "Mamoncillos"},
    };

    foreach (var producto in lista_productos)
    {
        Console.WriteLine($"{producto.Key}. {producto.Value}");
    }*/
