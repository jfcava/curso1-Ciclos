using System;

namespace guia5Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 5 edades y luego 
            // calcule el promedio de edad de aquellas personas mayores a 18 años.
            
            
            int edad; 
            float mayores = 0, sumaEdad = 0;
            
            for (int i = 0; i < 5; i++){
                
                Console.WriteLine("Ingrese una edad:");
                edad = int.Parse(Console.ReadLine());
                
                if(edad > 18){
                    mayores++;
                    sumaEdad += edad;
                }
            }

            Console.WriteLine("El promedio de edad de los mayores de 18 es: " + (sumaEdad/mayores));

        }
    }
}
