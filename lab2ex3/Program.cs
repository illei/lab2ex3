using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int numar = 0;
            int suma = 0;
            int numaratorParitate = 0;

            for (int i = 0; i < counter; i++)
            {
                 numar = int.Parse(Console.ReadLine());
                if (numar % 2 == 0 )

                {
                    suma = suma + numar;
                    numaratorParitate++;
                }
            }
            Console.WriteLine("Media aritmetica a numerelor  pare : " + suma/numaratorParitate);
        }
    }
}
