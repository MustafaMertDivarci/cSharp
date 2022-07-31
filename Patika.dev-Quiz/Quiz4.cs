using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle yazınız");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(" ");

            Console.WriteLine("Kelime sayısı: "+words.Length);
            int sum = 0; 

            foreach (string item in words)
            {
                sum+=item.Length;
            }
            Console.WriteLine("Toplam harf sayısı: "+sum);
            Console.ReadKey();
        }
    }
}