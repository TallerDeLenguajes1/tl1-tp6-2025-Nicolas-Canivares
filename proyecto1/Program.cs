﻿// See https://aka.ms/new-console-template for more information
//Ejercicio1 Invertir Numero
using System.ComponentModel;

Console.WriteLine("Ingrese un numero: ");
var numeroIngresado = Console.ReadLine();
int numero;
bool esNumero = int.TryParse(numeroIngresado, out numero);
int resto, numeroInvertido = 0;

if (esNumero)
{
    Console.WriteLine("Numero Ingresado: " + numero);
    while (numero > 0)
    {
        resto = numero % 10;
        numeroInvertido = (numeroInvertido * 10) + resto;
        numero /= 10;
    }
    
    Console.WriteLine("Numero invertido: " + numeroInvertido);
}
else
{
    Console.WriteLine("NO INGRESO UN NUMERO");
}


//Ejercicio02 Calculadora Version 2

int opcion = 0;
do
{
    Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1. Valor Absoluto");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Raiz Cuadarada");
    Console.WriteLine("4. Seno");
    Console.WriteLine("5. Coseno");
    Console.WriteLine("6. Parte Entera");
    Console.WriteLine("7. Salir");
    Console.WriteLine("Ingrese una opcion: ");
    var operacion = Console.ReadLine();
    double numero1 = 0, resultado = 0;
    //int numero1 = 0, numero2 = 0, resultado = 0;
    bool operacionElegida = int.TryParse(operacion, out opcion);
    if (opcion >= 1 && opcion < 6)
    {
        Console.WriteLine("Ingrese el numero");
        double.TryParse(Console.ReadLine(), out numero1);
        //numero1 = Console.Read();
        //Console.WriteLine("Ingrese el segundo numero");
        //int.TryParse(Console.ReadLine(), out numero2);
        //numero2 = Console.Read();
    }


    switch (opcion)
    {
        case 1:
            //Valor absoluto
            resultado = Math.Abs(numero1);
            break;
        case 2:
            //Cuadrado
            resultado = Math.Pow(numero1,2);
            break;
        case 3:
            //Raiz Cuadrada
            resultado = Math.Sqrt(numero1);
            break;
        case 4:
            //Seno
            resultado = Math.Sin(numero1);
            break;
        case 5:
            //Coseno
            resultado = Math.Cos(numero1);
            break;
        case 6:
            //Parte Entera
            resultado = Math.Truncate(numero1);
            break;
        case 7:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("No ingresó una opción valida");
            break;
    }

    if (opcion >= 1 && opcion < 6)
    {
        Console.WriteLine("El resultado es: " + resultado);
    }

} while (opcion != 7);
//Ejercicio02 Calculadora Version 1

do
{
    Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Ingrese un numero: ");
    var operacion = Console.ReadLine();
    int numero1 = 0, numero2 = 0, resultado = 0;
    bool operacionElegida = int.TryParse(operacion, out opcion);
    if (opcion >= 1 && opcion < 5)
    {
        Console.WriteLine("Ingrese el primer numero");
        int.TryParse(Console.ReadLine(), out numero1);
        //numero1 = Console.Read();
        Console.WriteLine("Ingrese el segundo numero");
        int.TryParse(Console.ReadLine(), out numero2);
        //numero2 = Console.Read();
    }


    switch (opcion)
    {
        case 1:
            //Suma
            resultado = numero1 + numero2;
            break;
        case 2:
            //Resta
            resultado = numero1 - numero2;
            break;
        case 3:
            //Multiplicacion
            resultado = numero1 * numero2;
            break;
        case 4:
            //Division
            resultado = numero1 / numero2;
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("No ingresó una opción valida");
            break;
    }

    if (numero1 != 0 || numero2 != 0)
    {
        Console.WriteLine("El resultado de " + numero1.ToString() + " y " + numero2.ToString() + " es: " + resultado.ToString());
    }

} while (opcion != 5);

// Ejercicio 4

// Conversor de tipo ToString()
// Comparador de cadenas Compare(), CompareTo() == y !=
// Mayusculas: ToUpper ,  Minusculas: ToLower()
// Acceso a los caracteres indivuales: SubString(), Replace(), Split(), Trim()
// Búsqueda y manipulación de una cadena: IndexOf() LastIndexOf, StartsWith y
// EndsWith. Split()

Console.WriteLine("Ingrese una cadena: ");
string cadenaIngresada = Console.ReadLine();

if (cadenaIngresada != null)
{
    int longitudCadena = cadenaIngresada.Length;
    Console.WriteLine("Longitud de la cadena: " + longitudCadena);
}

Console.WriteLine("Ingrese otra cadena: ");
string cadenaIngresada2 = Console.ReadLine();

if (cadenaIngresada != null && cadenaIngresada2 != null)
{
    string concatenacion = string.Concat(cadenaIngresada, cadenaIngresada2);
    Console.WriteLine("Concatenacion " + concatenacion);
}

if (cadenaIngresada != null)
{
    if (cadenaIngresada.Length >= 5)
    {
        string subcadena = cadenaIngresada.Substring(0, 5);
        Console.WriteLine("Subcadena: " + subcadena);
    }
}

foreach (char letra in cadenaIngresada)
{
    Console.WriteLine(letra);
}

// Buscar la ocurrencia de una palabra determinada en la cadena ingresada

Console.WriteLine("Ingrese una palabra a buscar en la cadena1: ");
string palabraABuscar = Console.ReadLine();

if (cadenaIngresada != null && palabraABuscar != null)
{
    int posicion = cadenaIngresada.IndexOf(palabraABuscar);
    if (posicion != -1)
    {
        Console.WriteLine("La palabra ingresada se encuentra en la posicion: " + posicion + " de la cadena ingresada");
    }
}

// Convierta la cadena a mayúsculas y luego a minúsculas.

if (cadenaIngresada != null)
{
    string cadenaIngresadaMayusculas = cadenaIngresada.ToUpper();
    Console.WriteLine("Cadena ingresada en mayusculas: " + cadenaIngresadaMayusculas);
    string cadenaIngresadaMinusculas = cadenaIngresada.ToLower();
    Console.WriteLine("Cadena ingresada en minusculas: " + cadenaIngresadaMinusculas);

}

