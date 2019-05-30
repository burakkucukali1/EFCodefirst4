using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodefirstApp
{
    [Table("Adresler",Schema ="CRM")]
    public class Adresler
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Adres1 { get; set; }

        [StringLength(100)]
        public string Adres2 { get; set; }

        [StringLength(15)]
        public string il { get; set; }

        [StringLength(15)]
        public string ilce { get; set; }
        [StringLength(10)]
        public string PostaKodu { get; set; }

        public int refMusteriId { get; set; }

        [ForeignKey("refMusteriId")]
        public Musteri Musteri { get; set; }



    }
}
