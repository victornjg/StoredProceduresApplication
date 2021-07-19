﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoredProceduresApplication.Models.DB
{
    public partial class StoredProceduresDatabaseContext : DbContext
    {
        public StoredProceduresDatabaseContext()
        {
        }

        public StoredProceduresDatabaseContext(DbContextOptions<StoredProceduresDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointments> Appointments { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=StoredProceduresDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
//        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Appointments>(entity =>
        //    {
        //        entity.Property(e => e.Date)
        //            .IsRequired()
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DoctorName)
        //            .IsRequired()
        //            .IsUnicode(false);

        //        entity.Property(e => e.EndTime)
        //            .IsRequired()
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.PatientName)
        //            .IsRequired()
        //            .IsUnicode(false);

        //        entity.Property(e => e.StartTime)
        //            .IsRequired()
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
