using ToptancıOtomasyonMvc.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ToptancıOtomasyonMvc.DAL
{
    public class UrunContext : DbContext
    {
        public UrunContext() : base("cstr")
        {

        }
        //migrations göç- code dan veritabanına geçme
        public DbSet<Musteri> Musteriler { get; set; } // veritabanındaki belleklerin karşılığı

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().ToTable("MUSTERILER");
            modelBuilder.Entity<Musteri>().Property(m => m.AD).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().Property(m => m.SOYAD).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Musteri>().Property(m => m.Telefon).HasColumnType("varchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Musteri>().Property(m => m.Sifre).HasColumnType("varchar").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Musteri>().Property(m => m.TCKNo).HasColumnType("varchar").HasMaxLength(11).IsRequired();
        }
    }
}