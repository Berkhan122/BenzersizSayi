using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzersizSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Benzersiz Sayı Örneği
            Console.Write("Kaç Sayı Girilmesini İstiyorsunuz:");
            byte sayiadet = byte.Parse(Console.ReadLine());
            int[] rndarray = new int[sayiadet];
            Random rnd = new Random();
            //int rndsayi = rnd.Next(10, 100);
            for (int i = 0; i < rndarray.Length; i++)
            {
                int rndsayi = rnd.Next(10, 100);
                rndarray[i] = rndsayi;
                if (!rndarray.Contains(rndsayi))
                {
                    rndarray[i] = rndsayi;
                }
                
                //Uzun bir süre bunun üzerinde çalıştım ancak bir çözüm bulamadım.
                //for (int j = 1; j < rndarray.Length; j++)
                //{
                //    if (rndarray[i] == rndarray[j])
                //    {
                //        int newrnd = rnd.Next(10, 100);
                //        rndarray[i] = newrnd;
                //    }
                //}
                
                
            }
            Array.Sort(rndarray);
            for (int i = 0; i < rndarray.Length; i++)
            {
                Console.WriteLine($"--{rndarray[i]}");
            }
            Console.ReadKey();
        }
    }
}
