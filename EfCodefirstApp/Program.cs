using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodefirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriContext musteriContext = new MusteriContext();
            il il = new il();
            il.Sehir = "Adana";
            il.PlakaKodu = "01";
            il.TelefonKodu = "312";

            musteriContext.iller.Add(il);
            musteriContext.SaveChanges();
        }
    }
}
