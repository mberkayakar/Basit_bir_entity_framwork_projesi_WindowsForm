using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Urunler
    {
        [Key]
        public int İd { get; set; }
        public string Urunad { get; set; }
        public string urunmarka { get; set; }
        public string urunkategori { get; set; }
        public int stok { get; set; }
        public Kategoriler kategori  { get; set; }
    }
}
