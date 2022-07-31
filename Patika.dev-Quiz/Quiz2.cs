using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 1
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.  2
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. 3
            
            //1
            int m=0;
            int n=0;
            etiket:
            try
            {
            
            Console.WriteLine("Pozitif iki sayı giriniz");
            n= Convert.ToInt32(Console.ReadLine());
            m= Convert.ToInt32(Console.ReadLine());
                
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine("Format doğru değil: "+ex.Message);
                goto etiket;
            }
            
            //2
            if (n>0 && m>0)
            {
                int[] arr = new int[n];

                Console.WriteLine(n+" adet pozitif sayı giriniz");

                for(int i =0;i<n;i++){
                    Console.WriteLine(i+". indexi giriniz");
                    int temp = Convert.ToInt32(Console.ReadLine());

                    if(temp<1){
                        Console.WriteLine("Pozitif sayı giriniz");
                        i--;
                    }
                    arr[i]= temp;
                 
                }
                // 3
                Console.WriteLine("bölünebilenler");
                foreach (int item in arr)
                {
                    if (item%m==0)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else{
                Console.WriteLine("Pozitif sayı giriniz.");
                goto etiket;
            }

            Console.ReadKey();


        }
    }
}