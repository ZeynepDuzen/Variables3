using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir dikdörtgenin çevresini ve alanını hesaplayın
            int kisaKenar, uzunKenar, cevre, alan;
            kisaKenar = 3;
            uzunKenar = 5;
            cevre = 2*(kisaKenar + uzunKenar);
            alan = kisaKenar * uzunKenar;

            Console.WriteLine("Çevre : " + cevre);
            Console.Write("Alan : " + alan);

            Console.Read();

        }
    }
}
