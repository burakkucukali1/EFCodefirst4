using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFromExistingDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Categories cat = new Categories();
            cat.CategoryName = "111";
            cat.Description = "222";
            Model1 db = new Model1();
            db.Categories.Add(cat);
           int scope= db.SaveChanges();

            Console.WriteLine($"eklenen kayit:{scope}");
            Console.ReadLine();
            
        }
    }
}
