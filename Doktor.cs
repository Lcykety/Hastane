using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class Doktor : Personel
    {
        public string  major { get; set; }
        public string title { get; set; }

        public override void getInfo()
        {
            
            Console.WriteLine("ad: {0} \n soyad:{1}\n Hastane kimlik numarası : {2}\n İşe alım tarihi: {3} \n Bölüm : {4} \n Unvan: {5}", Name, lastName, Id, hiredDate, major,title );
           
        }
       
    }
}
