using System.Data.Entity;

namespace MvcMusicStore.Models
{
    //Represents Entity Framework database context
    //Handle CRUD operations   

    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}