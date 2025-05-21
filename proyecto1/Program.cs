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
}

Console.WriteLine("Numero invertido: " + numeroInvertido);
