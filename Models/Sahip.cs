using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakımıDb.Models
{
    [Table("Owner")]
    internal class Sahip
    {
        public  Sahip()
        {
            Hayvanlar = new List<Hayvan>();
        }
        public int SahipID { get; set; }
        public string Ad { get; set; }

        public ICollection<Hayvan> Hayvanlar { get; set; }
    }
}
