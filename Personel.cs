using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class Personel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string lastName { get; set; }
        public string hiredDate { get; set; } 

        public virtual void getInfo( )
        {
            Console.WriteLine(" Ad: {0} \n Soyad:{1}\n Hastane kimlik numarası : {2}\n İşe alım tarihi: {3}", Name, lastName, Id, hiredDate);

        }
    }
}
