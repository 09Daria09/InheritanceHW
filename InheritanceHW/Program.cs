using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Plus(20, 3);
            product.Print();

            Console.WriteLine();
            Device[] device = new Device[4];

            device[0] = new Kettle();
            device[1] = new Microwave();
            device[2] = new Automobile();
            device[3] = new Steamer();

            for (int i = 0; i < device.Length; i++)
            {
                Console.WriteLine(device[i].Show());
                Console.WriteLine(device[i].Desc());
                Console.WriteLine(device[i].Saund());
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            }

            Console.WriteLine();
            Musical_instrument[] musicals = new Musical_instrument[4];

            musicals[0] = new Violin();
            musicals[1] = new Trombone();
            musicals[2] = new Ukulele();
            musicals[3] = new Cello();

            for (int i = 0; i < musicals.Length; i++)
            {
                Console.WriteLine(musicals[i].Show());
                Console.WriteLine(musicals[i].Desc());
                Console.WriteLine(musicals[i].Saund());
                Console.WriteLine(musicals[i].Histpry());
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            }

            Console.WriteLine();

        }
    }
}
