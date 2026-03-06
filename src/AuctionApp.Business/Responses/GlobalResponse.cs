using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Business.Responses
{
    public class GlobalResponse<T>
    {
        public T Data { get; set; }
        public bool  IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
