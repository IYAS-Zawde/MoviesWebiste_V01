﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesWebiste_V01
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MoviesWebsiteDBEntities : DbContext
    {
        public MoviesWebsiteDBEntities()
            : base("name=MoviesWebsiteDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<actor> actors { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<channel> channels { get; set; }
        public virtual DbSet<creteria> creterias { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<director> directors { get; set; }
        public virtual DbSet<education_level> education_level { get; set; }
        public virtual DbSet<format> formats { get; set; }
        public virtual DbSet<frequently> frequentlies { get; set; }
        public virtual DbSet<home_owner> home_owner { get; set; }
        public virtual DbSet<hoppy> hoppies { get; set; }
        public virtual DbSet<internet_connection> internet_connection { get; set; }
        public virtual DbSet<marital_status> marital_status { get; set; }
        public virtual DbSet<movie> movies { get; set; }
        public virtual DbSet<movie_selector> movie_selector { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<rating> ratings { get; set; }
        public virtual DbSet<technology> technologies { get; set; }
        public virtual DbSet<tv_signal> tv_signal { get; set; }
        public virtual DbSet<order_movie> order_movie { get; set; }
    }
}