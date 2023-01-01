using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Doktor
            {
                Name = "Ali",
                lastName = "Arıkan",
                major = "Nöroloji",
                hiredDate = "12,10,1989",
                Id = 000141,
                title = "Prof.Dr"
            };
            p1.getInfo();
            Console.ReadKey();  
        }
    }
}
