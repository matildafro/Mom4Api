using Mom4Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Mom4Api.Data {

public class AlbumContext : DbContext {
    public AlbumContext(DbContextOptions<AlbumContext> options) :base(options) {

    }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Comment> Comments { get; set; }
}

}