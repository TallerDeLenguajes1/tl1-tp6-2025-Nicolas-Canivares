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


//Ejercicio02 Calculadora

int opcion = 0;
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
        Console.WriteLine("El resultado es: " + resultado);
    }

} while (opcion != 5);