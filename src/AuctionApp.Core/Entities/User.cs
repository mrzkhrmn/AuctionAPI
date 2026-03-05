using AuctionApp.Core.Enums;

namespace AuctionApp.Core.Entities;
public class User : BaseEntity
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public UserRoles Role { get; set; }

    public List<Bid> Bids { get; set; } = new List<Bid>();
}
