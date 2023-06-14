using Projem.Models.Personel;
using Projem.Models.ProjeTakip;
using Projem.Models.Departman;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Projem.Models.DataContext
{
    public class ProjeTakipDBContext : DbContext
    {
        public ProjeTakipDBContext(): base("ProjeTakipDB")
        {

        }
        public DbSet<PersonelBilgileri> PersonelBilgileris { get; set; }
        public DbSet<PersonelProjeleri> PersonelProjeleris { get; set; }
        public DbSet<DepartmanBilgileri> DepartmanBilgileris { get; set; }
    }
}