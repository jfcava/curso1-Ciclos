using System;

namespace guia5Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite UN número y luego 
            // calcule y emita un cartel aclaratorio
            // si el mismo es primo o no es primo.
            
            
            int n, cont = 0;
 
            Console.WriteLine("Ingrese un nro:");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                if(n % i == 0)
                    cont++;
            }

            if(cont == 2)
                Console.WriteLine("El numero es primo");
            else
                Console.WriteLine("El numero no es primo");
            


        }
    }
}
