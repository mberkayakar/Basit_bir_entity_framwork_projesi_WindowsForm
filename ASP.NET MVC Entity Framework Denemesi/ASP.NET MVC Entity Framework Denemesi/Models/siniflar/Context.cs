using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASP.NET_MVC_Entity_Framework_Denemesi.Models.siniflar
{
    public  class Context:DbContext
    {
        public DbSet<Yetenekler> Yeteneklers { get; set; }



    }
}