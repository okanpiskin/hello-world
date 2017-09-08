using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kitap Sayfa :147

namespace DinamikDiziler //Dinamik dizilerde dizinin boyutu bir kez belirlendikten sonra artık değiştirilemez.Yani dizinin boyutunu dinamik
                        //olarak değiştirmemiz mümkün değildir.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dinamik dizinin boyutunu giriniz...");
            int val = Convert.ToInt32(Console.ReadLine());
            int[] dinamikDizi = new int[val];

            for (int i = 0; i < val; i++)
            {
                Console.WriteLine(dinamikDizi[i]);
                Console.ReadKey();
              
              //Test için eklenen yorum satırı
            }


        }
    }
}
