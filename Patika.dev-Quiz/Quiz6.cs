using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Klavyeden girilen 10 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            //  her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran
            //  programı yazınız.(Array sınıfını kullanarak yazınız.)
            int[] numbs = new int[10];
            
            for(int i=0;i<10;i++)
                numbs[i] = int.Parse(Console.ReadLine());

            Array.Sort(numbs);
            double average1 = 0;
            double average2 = 0;

            for(int i=0;i<3;i++)
            {   
                average1 +=numbs[i]; 
                Console.WriteLine(numbs[i]);
            }
            
            Array.Reverse(numbs);

            for(int i=0;i<3;i++)
            {   
                average2 +=numbs[i]; 
                Console.WriteLine(numbs[i]);
            }

            Console.WriteLine("İlk 3 değerin ortalaması: "+(average1/3)+"\nSon 3 değerin ortalaması: "+(average2/3)+"\nOrtalamaların toplamı: "+(average1/3+average2/3));
        
        }

    }
}