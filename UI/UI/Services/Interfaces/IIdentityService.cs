using Shared.Dtos;
using UI.Models;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn(SigninInput signinInput);

        Task<TokenResponse> GetAccessTokenByRefreshToken();

        Task RevokeRefreshToken();
    }
}