using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color_ghost
{
    class Chost
    {
        string[] colors = new string[] { "white", "yellow", "purple", "red" };

        public string color;

        public  Chost()
        {
            Random rnd = new Random();

            int index = rnd.Next(colors.Length);

            color = colors[index];
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Chost chost = new Chost();

            Console.WriteLine(chost.color);

            Console.ReadLine();
        }
    }
}
