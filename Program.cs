using System;

namespace tp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numero numero1 = new Numero(5);
            Numero numero2 = new Numero(2);

            // System.Console.WriteLine("Es mayor?", numero1.esMayor(numero2));
            if (numero1.esMenor(numero2))
            {
                System.Console.WriteLine("Es menor");
            }
        }
    }
}