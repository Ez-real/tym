using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tym
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("tym");
            string[] str = { "a", "b", "c", "d", "e", "f" };
            for (int i = 0; i < str.Length / 2; i++)
            {
                string temp = str[i];
                str[i] = str[str.Length - 1 - i];
                str[str.Length - 1 - i] = temp;
            }
        }
    }
}
