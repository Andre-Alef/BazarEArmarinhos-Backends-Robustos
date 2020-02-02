using Bazar.Models;
using System;
using System.Collections.Generic;

namespace Bazar.Domain.Contracts.Repositories
{
    public interface IUserRepository : IDisposable
    {
       List<UsuariosDTO> Get(string login);

        List<UsuariosDTO> GetLogin(string login, string password);

        UsuariosDTO Get(int Id);

        void Create(UsuariosDTO user);

        void  Update(UsuariosDTO user);

        void Delete(UsuariosDTO user);


    }
    
}
