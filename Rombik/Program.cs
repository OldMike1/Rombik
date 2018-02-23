using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            x = Math.Min(9, x);
            string z = "1";
            string kola;
            for (int i = 1; i <= x; i++)
            {
                Probel(x - i);
                if (i == 1)
                    z += "";
                else
                    z = i + z + i;
                Console.WriteLine(z);


            }
            kola = z;
            for (int i = 1; i < x; i++)
            {
                Probel(i);
                kola = kola.Remove(0, 1);
                kola = kola.Remove(kola.Length - 1, 1);
                Console.WriteLine(kola);
            }

        }

        static void Probel(int count)
        {
            string result = "";
            for (int g = 0; g < count; g++)
            {
                result += " ";
            }
            Console.Write(result);
        }
    }
}

