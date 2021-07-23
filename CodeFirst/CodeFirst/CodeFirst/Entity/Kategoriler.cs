using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Kategoriler
    {
        [Key]
        public int İD { get; set; }
        public int Kategoriadı { get; set; }
    }
}
