using AuctionApp.Business.DTOs;
using AuctionApp.Business.Helpers;
using AuctionApp.Business.Interfaces;
using AuctionApp.Business.Responses;
using AuctionApp.Core.Entities;
using AuctionApp.Core.Enums;
using AuctionApp.Data.Repositories.Interfaces;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Business.Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork;

        public async Task<GlobalResponse<UserResponseDTO>> LoginAsync(UserLoginDTO loginDTO)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(loginDTO.Password);

            var user = new User
            {
                Email = loginDTO.Email,
                PasswordHash = hashedPassword,
                Role =  UserRoles.User
            };
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.SaveAsync();

            var response = new UserResponseDTO
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Role = user.Role
            };

            return ResponseHelper.Success(response, "Kullanıcı oluşturuldu!");
        }

        public Task<GlobalResponse<UserResponseDTO>> RegisterAsync(UserRegisterDTO registerDTO)
        {
            throw new NotImplementedException();
        }
    }
}
