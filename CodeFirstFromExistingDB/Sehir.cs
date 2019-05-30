namespace CodeFirstFromExistingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sehir")]
    public partial class Sehir
    {
        public int SehirId { get; set; }

        [StringLength(50)]
        public string SehirAdi { get; set; }

        [StringLength(50)]
        public string PlakaKodu { get; set; }
    }
}
