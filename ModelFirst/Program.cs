using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1Container db = new Model1Container();
          var sorgu =   db.ils.Select(x => x.PlakaKodu == "01");

            string str = "";
        }
    }
}
