

using Bazar.Models;
using System;
using System.Collections.Generic;

namespace Bazar.Domain.Contracts.Services
{
    public interface IUserService : IDisposable
    {
        
      //  UserModel model = new UserModel();
        List<UsuariosDTO> Authenticate(UserModel model);

        List<UsuariosDTO> GetByLogin(UserModel model);

        void Register(UserModel model);

        void ChangeInformation(UsuariosDTO user);

        void Delete(UsuariosDTO user);

        string ResetPassword(UserModel model);


    }
}
