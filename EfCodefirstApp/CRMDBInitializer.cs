using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodefirstApp
{
  public  class CRMDBInitializer : DropCreateDatabaseAlways<MusteriContext>
    {
        protected override void Seed(MusteriContext context)
        {
          
            IList<il> iller = new List<il>();
            il il = new il();
            il.PlakaKodu = "01";
            il.Sehir = "Adana";
            il.TelefonKodu = "01";
            iller.Add(il);


            il il2 = new il();
            il2.PlakaKodu = "02";
            il2.Sehir = "Adiyaman";
            il2.TelefonKodu = "02";
            iller.Add(il2);

            iller.Add(new il { PlakaKodu = "03",
                                Sehir = "Amasya",
                                TelefonKodu = "04" });
            iller.Add(new il {  PlakaKodu = "04",
                                Sehir = "Ankara",
                                TelefonKodu = "04" });

            context.iller.AddRange(iller);
            base.Seed(context);
        }
    }
}
