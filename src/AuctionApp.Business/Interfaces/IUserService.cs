using AuctionApp.Business.DTOs;
using AuctionApp.Business.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Business.Interfaces
{
    public interface IUserService
    {
        Task<GlobalResponse<UserResponseDTO>> RegisterAsync(UserRegisterDTO registerDTO);
        Task<GlobalResponse<UserResponseDTO>> LoginAsync(UserLoginDTO loginDTO);

    }
}
