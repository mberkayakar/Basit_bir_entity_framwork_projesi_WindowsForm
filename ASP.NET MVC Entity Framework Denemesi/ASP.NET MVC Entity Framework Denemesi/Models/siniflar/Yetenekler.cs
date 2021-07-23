using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Entity_Framework_Denemesi.Models.siniflar
{
    public class Yetenekler
    {
        [Key]
        public int id { get; set; }
        public string yetenek_ismi  { get; set; }
        public byte yetenek_yuzdesi { get; set; }  // 0 ile 128 arasında alır bizede 0 ile 100 arası kazım olacağı için bu yeterlidir
    }
}