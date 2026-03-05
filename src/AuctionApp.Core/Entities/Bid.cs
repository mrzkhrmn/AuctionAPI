namespace AuctionApp.Core.Entities;
public class Bid : BaseEntity
{
    public Auction Auction { get; set; }
    public int AuctionId { get; set; }
    public DateTime BidTime { get; set; }
    public User User { get; set; }
    public Guid UserId { get; set; }
    public int Amount { get; set; }
}
