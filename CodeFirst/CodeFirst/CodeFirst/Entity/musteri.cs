using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class musteri
    {

        [Key]
        public int id{ get; set; }
        public string musteri_ad{ get; set; }
        public string musteri_unvan { get; set; }
        public string sehir { get; set; }
        public string musteri_soyad { get; set; }

    }
}
