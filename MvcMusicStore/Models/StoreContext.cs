using System;
using System.Collections.Generic;
using System.Data.Entity;//This is for Entity Framework
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class StoreContext : DbContext //This is for Entity Framework
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}