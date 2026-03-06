using AuctionApp.Business.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Business.Helpers
{
    public static class ResponseHelper
    {
        public static GlobalResponse<T> Success<T>(T data, string message = "Başarılı!")
        {
            return new GlobalResponse<T>
            {
                Data = data,
                IsSuccess = true,
                Message = message
            };
        }

        public static GlobalResponse<T> Fail<T>(T data, string message = "Başarısız")
        {
            return new GlobalResponse<T>
            {
                Data = data,
                IsSuccess = false,
                Message = message
            };
        }
    }
}
