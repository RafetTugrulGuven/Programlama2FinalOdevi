using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MezunTakipMvc.Models
{
    public class Db : DbContext
    {
        public DbSet<Sehirler> Sehirler { get; set; }
        public DbSet<Ilceler> Ilceler { get; set; }
        public DbSet<Bolumler> Bolumler { get; set; }
        public DbSet<CalismaAlanlari> CalismaAlanlari { get; set; }
        public DbSet<DuyuruBasvuru> DuyuruBasvuru { get; set; }
        public DbSet<DuyuruKapsami> DuyuruKapsami { get; set; }
        public DbSet<Duyurular> Duyurular { get; set; }
        public DbSet<Fakulteler> Fakulteler { get; set; }
        public DbSet<OgrenimDurumlari> OgrenimDurumlari { get; set; }
        public DbSet<SirketAdres> SirketAdres { get; set; }
        public DbSet<Sirketler> Sirketler { get; set; }
        public DbSet<SirketTel> SirketTel { get; set; }
        public DbSet<SirketWeb> SirketWeb { get; set; }
        public DbSet<UyeAdres> UyeAdres { get; set; }
        public DbSet<UyeBolum> UyeBolum { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
        public DbSet<UyeMail> UyeMail { get; set; }
        public DbSet<UyeOgrenimDurumu> UyeOgrenimDurumu { get; set; }
        public DbSet<UyeSirket> UyeSirket { get; set; }
        public DbSet<UyeTel> UyeTel { get; set; }
        public DbSet<UyeCalismaAlani> UyeCalismaAlani { get; set; }


        public Db()
      : base("MezunTakipDb")
        {

        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {

            // builder.Entity<User>().HasRequired(bm => bm.Admin).WithMany().WillCascadeOnDelete(false);
            base.OnModelCreating(builder);

        }
    }
}