using AuctionApp.Core.Entities;
using AuctionApp.Data.Context;
using AuctionApp.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuctionDbContext _context;

        public IGenericRepository<User> Users {  get; }

        public IGenericRepository<Product> Products { get; }

        public IGenericRepository<Auction> Auctions { get; }

        public IGenericRepository<Bid> Bids { get; }

        public UnitOfWork(AuctionDbContext context)
        {
            _context = context;
            Users = new GenericRepository<User>(context);
            Products = new GenericRepository<Product>(context);
            Auctions = new GenericRepository<Auction>(context);
            Bids = new GenericRepository<Bid>(context);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
