using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodefirstApp
{
    [Table("Musteriler")]
   public  class Musteri
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required(AllowEmptyStrings =false,ErrorMessage = "Ad Alani boş geçemezsiniz")]
        public string Ad { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Soyad Alani boş geçemezsiniz")]
        [MaxLength(30)]
        public string Soyad { get; set; }

        public string Unvan { get; set; }


    }
}
