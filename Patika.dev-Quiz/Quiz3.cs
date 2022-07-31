using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            int num =0;
            checkpoint:
            
            try
            {
                Console.WriteLine("Pozitif bir sayı giriniz");
                num= Convert.ToInt32(Console.ReadLine());
                if(num<0){
                    Console.WriteLine("Sayi 0 dan büyük olmalıdır\n");
                    goto checkpoint;
                }
            }
            
            catch (System.Exception ex)
            {
                Console.WriteLine("Hata raporudur\n"+ex);
                
                goto checkpoint;
            }

            string[] words = new string[num];
            Console.WriteLine(num+" adet kelime giriniz\n");
            for(int i=0;i<num;i++){
                checkpoint2:
                string temp= Console.ReadLine();
                
                if(string.IsNullOrEmpty(temp)){
                    Console.WriteLine("null karakter girilemez!\n");
                    goto checkpoint2;
                }
                words[i] = temp;

            }

            for(int i=num-1;i>=0;i--){
                Console.WriteLine(words[i]);
            }


            Console.ReadKey();
            

        
        }
    }
}