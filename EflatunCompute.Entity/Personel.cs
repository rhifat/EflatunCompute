using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EflatunCompute.Entity
{
    public class Personel
    {
        public int Id { get; set; }
        [Required]
        public string PersonelNo { get; set; }
        [Required, MaxLength(50)]
        public string Adi { get; set; }
        [Required, MaxLength(50)]
        public string Soyadi { get; set; }
        public string AdiSoyadi { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Tayin { get; set; }
        public string Telefon { get; set; }
        [Required, MaxLength(150)]
        public string Adres { get; set; }
        [Required, MaxLength(50)]
        public string YasadigiSehir { get; set; }
        public IsUnvani IsUnvani { get; set; }
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string TCNo { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
        public IEnumerable<OdemeKaydi> OdemeKaydis { get; set; }


    }
}
