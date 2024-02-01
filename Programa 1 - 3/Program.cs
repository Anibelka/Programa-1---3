using System;
using System.Net.NetworkInformation;

class SumayProducto
{
    static void Main(string[] args)
    {
        decimal numero1 = Numero("Ingrese el primer número: ");
        decimal numero2 = Numero("Ingrese el segundo número: ");

        if (numero1 > numero2)
        {
            decimal suma = numero1 + numero2;
            decimal diferencia = numero1 - numero2;

            Console.WriteLine("\n" + "El primer número es mayor.");
            Console.WriteLine("\n" + "La suma es: " + suma);
            Console.WriteLine("La diferencia es: " + diferencia);
        }
        else
        {
            decimal producto = numero1 * numero2;
            decimal division = numero1 / numero2;

            Console.WriteLine("\n" + "El primer número es menor o igual.");
            Console.WriteLine("\n" + "El producto es: " + producto);
            Console.WriteLine("La división es: " + division);
        }
    }

    static decimal Numero(string mensaje)
    {
        decimal num;
        bool esValido;

        do
        {
            Console.WriteLine(mensaje);
            esValido = decimal.TryParse(Console.ReadLine(), out num);

            if (!esValido)
            {
                Console.WriteLine("\n" + "El valor ingresado no es válido." + "\n" + "Por favor, ingrese un número." + "\n");
            }
        } while (!esValido);

        return num;
    }
}