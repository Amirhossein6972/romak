using Microsoft.Extensions.Configuration;
using Romak.Core;
using Romak.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romak.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _config;

        public UserService(IUnitOfWork uow, ITokenService tokenService, IConfiguration config)
        {
            _uow = uow;
            _tokenService = tokenService;
            _config = config;
        }

        public async Task<string> Login(string username, string password)
        {
            var user = _uow.userRepository.GetUser(username, password);

            if (user != null)
            {

                var userDto = new Core.DTO.UserDTO.UserLogged
                {
                    UserName = user.Name,
                    Role = user.Role.Name
                };

                var result = _tokenService.BuildToken(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), userDto);

                return result;
            }

            return null;
        }
    }
}
