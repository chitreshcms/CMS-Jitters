﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CMSTweetDBEntities111 : DbContext
    {
        public CMSTweetDBEntities111()
            : base("name=CMSTweetDBEntities111")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HashTag> HashTags { get; set; }
        public virtual DbSet<Tweet> Tweets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserFollower> UserFollowers { get; set; }
        public virtual DbSet<UserReaction> UserReactions { get; set; }
    }
}
