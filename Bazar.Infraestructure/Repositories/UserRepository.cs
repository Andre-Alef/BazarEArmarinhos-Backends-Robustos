using Bazar.Domain.Contracts.Repositories;
using Bazar.Infraestructure.Data;
using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bazar.Infraestructure.Repositories
{
   public class UserRepository : IUserRepository
    {
        

        private AppDataContext _Context;

        public UserRepository(AppDataContext context)
        {
            this._Context = context;
        }



        public List<UsuariosDTO>  Get(string login)
        {
            return _Context.Usuarios.ToList();
        }

        public List<UsuariosDTO> GetLogin(string login, string password)
        {
            return _Context.Usuarios.Where(x => x.Login.Equals(login)).ToList();
        }

        public UsuariosDTO Get(int id)
        {
            return _Context.Usuarios.Where(x => x.IdUsuario == id).FirstOrDefault();
        }

        public void Create(UsuariosDTO user)
        {
            _Context.Usuarios.Add(user);
            _Context.SaveChanges();
        }

        public void Update(UsuariosDTO user)
        {

            _Context.Entry<UsuariosDTO>(user).State = System.Data.Entity.EntityState.Modified;
     
            _Context.SaveChanges();

            
           
        }

        public void Delete(UsuariosDTO user)
        {

            _Context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
         //   _Context.Usuarios.Remove(user);
            _Context.SaveChanges();

        }

        public void Dispose()
        {
            _Context.Dispose();
        }

     
    }
}
