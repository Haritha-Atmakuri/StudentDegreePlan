﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Credit> Credits {get; set;}
        public DbSet<Student> Students { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<DegreeCredit> DegreeCredits {get; set;}
       
       
        public DbSet<StudentTerm> StudentTerms { get; set; }
      
        
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Credit>().ToTable("Credit");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");

            modelBuilder.Entity<Slot>().ToTable("Slot");

            modelBuilder.Entity<DegreeCredit>().ToTable("DegreeCredit");
                    
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerm");
           // modelBuilder.Entity<Developer>().ToTable("Develper");
        }
    }
}