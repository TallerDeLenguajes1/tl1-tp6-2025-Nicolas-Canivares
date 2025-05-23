// See https://aka.ms/new-console-template for more information
//Ejercicio1 Invertir Numero
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