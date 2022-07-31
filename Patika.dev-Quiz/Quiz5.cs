using System;
using System.Collections;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            int num =0;
            int x=0;
            int[] temp = new int[20];
            while(x<20)
            {
                try
                {
                    checkpoint:
                    num=int.Parse(Console.ReadLine()); 
                    if(num<0)
                    {
                        Console.WriteLine("Pozitif sayı olmalıdır");
                        goto checkpoint;
                    }   
                }
                catch (System.Exception)
                {
                    
                    throw new Exception("Numerik sayı giriniz");
                }
                temp[x]=num;
                x++;
            }
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();           
            
            
            for(int i=0;i<temp.Length;i++)
            {
                int count =0;
                for (int j =1; j <temp.Length+1; j++)
                {
                    if(temp[i]==1 || temp[i]==0)
                        continue;
                    else
                    {
                        if(temp[i]%j==0)
                            count++;
                    }
                }
                if(count==2)
                {
                    prime.Add(temp[i]);
                }
                else
                    notPrime.Add(temp[i]);
            }

            prime.Sort();
            notPrime.Sort();
            Console.WriteLine("prime numbers");
            double a=0;
            double b=0;
            foreach (int item in prime)
            {
                a+=item;
                Console.WriteLine(item);
            }
            Console.WriteLine("Not prime");
            foreach (int item in notPrime)
            {
                b+=item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"{prime.Count} adet asal sayı vardır. Ve ortalaması: {a/prime.Count}");
            Console.WriteLine($"{notPrime.Count} adet asal sayı vardır. Ve ortalaması: {(b/notPrime.Count)}");

        }
    }
}