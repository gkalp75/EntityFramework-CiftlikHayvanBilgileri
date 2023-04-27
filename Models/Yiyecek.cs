using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakımıDb.Models
{
    internal class Yiyecek
    {
        public Yiyecek()
        {
            Hayvanlar = new List<Hayvan>();
        }
        public int YiyecekID { get; set; }
        public string YiyecekAdi { get; set; }

        public string YiyecekIcerigi { get; set; }

        public decimal Kalori { get; set; }

        public ICollection<Hayvan> Hayvanlar { get; set; }

    }
}
