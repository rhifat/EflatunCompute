using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EflatunCompute.Entity
{
    public class OdemeKaydi
    {
        public int Id { get; set; }
        [ForeignKey("Personel")]
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
        public string AdiSoyadi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public string OdemeAyi { get; set; }
        [Column(TypeName = "money")]
        public decimal? SaatUcretMiktari { get; set; }
        public decimal? CalisilanSaat { get; set; }
        public decimal? SozlesmeliSaatler { get; set; }
        [Column(TypeName = "money")]
        public decimal? MesaiAsimMiktari { get; set; }
        [Column(TypeName = "money")]
        public decimal? SozlesmeliKazancTutari { get; set; }
        [Column(TypeName = "money")]
        public decimal? MesaiAsimKazancTutari { get; set; }
        [Column(TypeName = "money")]
        public decimal AylikMaasi { get; set; }
        [Column(TypeName = "money")]
        public Nullable<decimal> SeferHarcirahMiktari { get; set; }
        public Nullable<decimal> AtilanSefer { get; set; }
        [Column(TypeName ="money")]
        public decimal ToplamKazanclar { get; set; }      

    }
}
