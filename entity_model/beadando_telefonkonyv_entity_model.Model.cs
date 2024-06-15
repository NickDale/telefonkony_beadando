﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2024. 06. 15. 13:54:28
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using enTelefonkony;

namespace cnTelefonkony
{

    public partial class Model : DbContext
    {

        public Model() :
            base()
        {
            OnCreated();
        }

        public Model(DbContextOptions<Model> options) :
            base(options)
        {
            OnCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured ||
                (!optionsBuilder.Options.Extensions.OfType<RelationalOptionsExtension>().Any(ext => !string.IsNullOrEmpty(ext.ConnectionString) || ext.Connection != null) &&
                 !optionsBuilder.Options.Extensions.Any(ext => !(ext is RelationalOptionsExtension) && !(ext is CoreOptionsExtension))))
            {
            }
            CustomizeConfiguration(ref optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        partial void CustomizeConfiguration(ref DbContextOptionsBuilder optionsBuilder);

        public virtual DbSet<enSzemly> enSzemlies
        {
            get;
            set;
        }

        public virtual DbSet<enTelefonszam> enTelefonszams
        {
            get;
            set;
        }

        public virtual DbSet<enHelyseg> enHelysegs
        {
            get;
            set;
        }

        public virtual DbSet<enFelhasznalo> enFelhasznalos
        {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            this.enSzemlyMapping(modelBuilder);
            this.CustomizeenSzemlyMapping(modelBuilder);

            this.enTelefonszamMapping(modelBuilder);
            this.CustomizeenTelefonszamMapping(modelBuilder);

            this.enHelysegMapping(modelBuilder);
            this.CustomizeenHelysegMapping(modelBuilder);

            this.enFelhasznaloMapping(modelBuilder);
            this.CustomizeenFelhasznaloMapping(modelBuilder);

            RelationshipsMapping(modelBuilder);
            CustomizeMapping(ref modelBuilder);
        }

        #region enSzemly Mapping

        private void enSzemlyMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<enSzemly>().ToTable(@"Szemely");
            modelBuilder.Entity<enSzemly>().Property(x => x.id).HasColumnName(@"id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<enSzemly>().Property(x => x.vezeteknev).HasColumnName(@"vezeteknev").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<enSzemly>().Property(x => x.utonev).HasColumnName(@"utonev").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<enSzemly>().Property(x => x.lakcim).HasColumnName(@"lakcim").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<enSzemly>().Property(x => x.enHelysegid).HasColumnName(@"enHelysegid").ValueGeneratedNever();
            modelBuilder.Entity<enSzemly>().HasKey(@"id");
        }

        partial void CustomizeenSzemlyMapping(ModelBuilder modelBuilder);

        #endregion

        #region enTelefonszam Mapping

        private void enTelefonszamMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<enTelefonszam>().ToTable(@"telefonszam");
            modelBuilder.Entity<enTelefonszam>().Property(x => x.id).HasColumnName(@"id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<enTelefonszam>().Property(x => x.szam).HasColumnName(@"szam").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            modelBuilder.Entity<enTelefonszam>().Property(x => x.enSzemlyid).HasColumnName(@"enSzemlyid").ValueGeneratedNever();
            modelBuilder.Entity<enTelefonszam>().HasKey(@"id");
        }

        partial void CustomizeenTelefonszamMapping(ModelBuilder modelBuilder);

        #endregion

        #region enHelyseg Mapping

        private void enHelysegMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<enHelyseg>().ToTable(@"helyseg");
            modelBuilder.Entity<enHelyseg>().Property(x => x.id).HasColumnName(@"id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<enHelyseg>().Property(x => x.IRSZ).HasColumnName(@"IRSZ").IsRequired().ValueGeneratedNever().HasMaxLength(15);
            modelBuilder.Entity<enHelyseg>().Property(x => x.nev).HasColumnName(@"nev").IsRequired().ValueGeneratedNever().HasMaxLength(75);
            modelBuilder.Entity<enHelyseg>().HasKey(@"id");
        }

        partial void CustomizeenHelysegMapping(ModelBuilder modelBuilder);

        #endregion

        #region enFelhasznalo Mapping

        private void enFelhasznaloMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<enFelhasznalo>().ToTable(@"felhasznalo");
            modelBuilder.Entity<enFelhasznalo>().Property(x => x.id).HasColumnName(@"id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<enFelhasznalo>().Property(x => x.nev).HasColumnName(@"nev").IsRequired().ValueGeneratedNever().HasMaxLength(250);
            modelBuilder.Entity<enFelhasznalo>().Property(x => x.email).HasColumnName(@"email").ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<enFelhasznalo>().Property(x => x.password).HasColumnName(@"password").IsRequired().ValueGeneratedNever().HasMaxLength(300);
            modelBuilder.Entity<enFelhasznalo>().HasKey(@"id");
        }

        partial void CustomizeenFelhasznaloMapping(ModelBuilder modelBuilder);

        #endregion

        private void RelationshipsMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<enSzemly>().HasMany(x => x.enTelefonszamok).WithOne(op => op.enSzemly).HasForeignKey(@"enSzemlyid").IsRequired(true);
            modelBuilder.Entity<enSzemly>().HasOne(x => x.enHelyseg).WithMany(op => op.enSzemlyek).HasForeignKey(@"enHelysegid").IsRequired(true);

            modelBuilder.Entity<enTelefonszam>().HasOne(x => x.enSzemly).WithMany(op => op.enTelefonszamok).HasForeignKey(@"enSzemlyid").IsRequired(true);

            modelBuilder.Entity<enHelyseg>().HasMany(x => x.enSzemlyek).WithOne(op => op.enHelyseg).HasForeignKey(@"enHelysegid").IsRequired(true);
        }

        partial void CustomizeMapping(ref ModelBuilder modelBuilder);

        public bool HasChanges()
        {
            return ChangeTracker.Entries().Any(e => e.State == Microsoft.EntityFrameworkCore.EntityState.Added || e.State == Microsoft.EntityFrameworkCore.EntityState.Modified || e.State == Microsoft.EntityFrameworkCore.EntityState.Deleted);
        }

        partial void OnCreated();
    }
}