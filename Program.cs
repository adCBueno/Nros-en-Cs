using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Tarea_5
{
    class Tarea5
    {

        static void Main(string[] args)
        {

            char opcion;

            Console.WriteLine("Introduce una opción");
            Console.WriteLine("1: De 10 datos mostrar el Min, Max y Prom");
            Console.WriteLine("2: Del 1 al 20, generar los primeros números resultante");
            Console.WriteLine("3: Tabla de multiplicar de n");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                
                case '1':

                    //En un array de 10 números enteros. Mostrar el dato mínimo, el dato máximo y promedio

                    int[] datos = new int[10];

                    int max = datos[0];
                    
                    int prom = 0;
                    double r;

                    Console.WriteLine("Ingrese 10 valores:");
                    for (int x = 0; x<10; x++)
                    {
                        
                        Console.WriteLine(x + 1);
                        datos[x] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Los números ingresados son:");

                    for (int l = 0; l < 10; l++)
                    {
                        Console.WriteLine(datos[l]);
                    }
                    int min = datos[0];
                    for (int j = 0; j < datos.Length; j++)
                    {
                        if (datos[j] < min)
                            min = datos[j];
                    }
                    for (int i = 0; i < datos.Length; i++)
                    {
                        if (datos[i] > max)
                            max = datos[i];
                    }                   
                    for (int k = 0; k < datos.Length; k++)
                    {
                        prom = prom + datos[k];                   
                    }

                    r = prom / datos.Length;
                    Console.WriteLine("");
                    Console.WriteLine("El número máximo es: " + max);
                    Console.WriteLine("El número mínimo es: " + min);
                    Console.WriteLine(r);
                    break;

                case '2':

                    //Introducir un número N (1-20) y generar un array con los primeros N números primos.

                    bool primo;
                    int n;
                    Console.WriteLine("Ingrese un número del 1 al 20");
                    n = int.Parse(Console.ReadLine());
                    string resultante = "";

                    for (int x=2; x<=n; x++)
                    {
                        primo = true;
                        for (int y = 2; y < x; y++)
                        {
                            if(x%y == 0)
                            {
                                primo = false;
                                break;
                            }
                        }

                        if (primo)
                        {
                            resultante += x + " ";
                        }
                    }
                  
                        Console.WriteLine(resultante);                    
                    
                    break;

                case '3':

                    //Introducir un número desde teclado y generar su tabla de multiplicar

                    int a;
                    int s;

                    String entrada;

                    Console.WriteLine("Ingresa el número del que quieras ver la tabla de multiplicar");
                    entrada = Console.ReadLine();
                    a = int.Parse(entrada);

                    for (int x = 1; x <= 10; x++)
                    {
                        s = a * x;
                        Console.WriteLine(a + " = " + x + " = " + s);
                    }
                    Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("Algo hiciste mal, intenta de nuevo");
                    break; 
            }
        }
    }
}
