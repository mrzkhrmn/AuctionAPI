namespace AuctionApp.Core.Entities;
public class Auction : BaseEntity
{
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; }

    public List<Bid> Bids { get; set; } = new List<Bid>();
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public User WinnerUser { get; set; }
    public Guid WinnerUserId { get; set; }
}
