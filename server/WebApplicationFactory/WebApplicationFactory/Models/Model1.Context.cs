﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationFactory.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FactoryDBEntities : DbContext
    {
        public FactoryDBEntities()
            : base("name=FactoryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EmployeeShift> EmployeeShift { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
    }
}