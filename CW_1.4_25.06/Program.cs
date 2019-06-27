using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
namespace CW_1._4_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("С некоторого момента прошло 234 дня.");
            var day = 234;
            var week = day/7;
            Console.Write("Полных недель прошло за этот период: ");
            Console.WriteLine(week);
            Console.ReadKey();
        }
    }
}
