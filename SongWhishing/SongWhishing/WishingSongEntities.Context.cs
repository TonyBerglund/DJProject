﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SongWishing
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class WishingSongEntities : DbContext
    {
        public WishingSongEntities()
            : base("name=WishingSongEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<DeletedRequest> DeletedRequests { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<SongsRequest> SongsRequests { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
