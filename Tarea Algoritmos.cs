using System;

namespace ConsoleApp1
{


    internal class Program



    {
        static void Main(string[] args)
        {
            int f = fr(0 ,0);


            Console.WriteLine("ingresa un numero de firmas maximas ");
            int nf_max = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el numero de firmas obtenidas");
            int nf = int.Parse(Console.ReadLine());
            Console.WriteLine("(Funcion) La suma es ");
            Console.WriteLine(f);










        }

       

        public static int fr(int nf, int nf_max)
        {
            int f = nf * 100 / nf_max;


            return f;


        }
    }
}