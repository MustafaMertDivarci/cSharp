using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Pozitif bir dizi uzunluğu giriniz");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            if(num1<0){
                Console.WriteLine("Pozitif bir sayı giriniz");
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                int[] dizi = new int[num1];

                for(int i=0; i<num1;i++){
                    Console.WriteLine("Dizinin "+i+". elemanını giriniz:  " );
                    dizi[i]=Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nDizinin çift elemanları.\n");
                foreach (int item in dizi)
                {
                    if (item%2==0)
                    {
                        Console.WriteLine(item);
                    }                   
                }

            }

            Console.ReadKey();

        }
    }
}