using HayvanBakımıDb.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakımıDb.Models
{
    [Table("Hayvanlar")]
    internal class Hayvan
    {
        public Hayvan()
        {
            Yiyecekler = new List<Yiyecek>();
        }

        [Key]
        public int HayID {get ; set;}
        [MaxLength(50)]
        public string Ad { get; set;}
        public Cinsiyet Cinsiyet { get; set;}
        public bool SahibiVarMi { get; set;}
        public DateTime DogumTarihi { get; set;}

        [Column("Kilo")]
        public double Agirlik { get; set;}
        public string Tur { get; set;}
        public string Cins { get; set;}

        [NotMapped]
        public int Yas { get; set; }

        //public int Yas { get 
        //    { 
        //        return DateTime.Now.Year - DogumTarihi.Year; 
        //    } 
        //}
        public ICollection<Yiyecek> Yiyecekler { get; set;}
        public int SahipId { get; set;}
        public Sahip Sahip { get; set;}

        [ForeignKey("Bakici")]
        public int BakId { get; set;}
        //[ForeignKey("BakID")] ///bu da kullanılabilir.
        public Bakici Bakici { get; set;}
    }
}
