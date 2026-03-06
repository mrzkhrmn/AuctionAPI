using AuctionApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Auction> Auctions { get; }
        IGenericRepository<Bid> Bids { get; }
        Task<int> SaveAsync();
    }
}
