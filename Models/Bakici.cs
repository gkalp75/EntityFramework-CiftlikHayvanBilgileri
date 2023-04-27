using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakımıDb.Models
{
    internal class Bakici
    {
        public Bakici()
        {
            Hayvanlar = new List<Hayvan>();
        }
        public int BakiciId { get; set; }
        public string Ad { get; set; }

        public ICollection<Hayvan> Hayvanlar { get; set; }
    }
}
