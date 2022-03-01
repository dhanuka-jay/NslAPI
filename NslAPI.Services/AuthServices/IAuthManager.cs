using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NslAPI.Services.DTOs;

namespace NslAPI.Services.AuthServices
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(UserLoginDTO userDTO);

        Task<string> CreateToken();
    }
}
