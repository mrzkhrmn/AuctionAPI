using AuctionApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionApp.Data.Context;
public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options)
    {

    }



    public DbSet<User> Users { get; set; }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Bid> Bids { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auction>()
            .HasOne(a => a.WinnerUser)
            .WithMany()
            .HasForeignKey(a => a.WinnerUserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
