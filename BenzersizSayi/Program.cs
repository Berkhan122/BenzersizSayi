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

            for (int i = 0; i < sayiadet; i++)
            {
                rndarray[i] = rnd.Next(10, 100);
            }

            
        }
    }
}
