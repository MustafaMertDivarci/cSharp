using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Klavyeden girilen cümle içerisindeki sesli harfleri bir string içerisinde saklayan ve 
            //  stringin elemanlarını sıralayan programı yazınız.

            string word = Console.ReadLine();
            string[] vowel = new string[]{"a","e","ı","i","o","ö","u","ü"};
            
            string newVowels = "";


            for(int i = 0 ; i<vowel.Length;i++)
            {
                if(word.Contains(vowel[i]))
                {
                    newVowels+=vowel[i];
                    newVowels+=" ";
                }
                
            }
            Console.WriteLine(newVowels);


        }
    }
}