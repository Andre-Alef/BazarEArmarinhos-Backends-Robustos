using Bazar.Common.Resources;
using Bazar.Common.Validation;
using Bazar.Domain.Contracts.Repositories;
using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using System;
using System.Collections.Generic;

namespace Bazar.Business.Services
{
   
    public class UserService : IUserService
    {
       UserModel model = new UserModel();
        private IUserRepository _repository;
        
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public List<UsuariosDTO> Authenticate(UserModel model)
        {
           
            var user = _repository.GetLogin(model.Login, model.Password);

            return user;
        }

        public void ChangeInformation(UsuariosDTO user)
        {

          _repository.Update(user);
        }

        public void Delete(UsuariosDTO user)
        {
            //var user = Authenticate(model.Login,model.Password);

            //   user.SetPassword(newPassword, confirmNewPassword);
            //    user.Validate();

              _repository.Delete(user);
        }


        public List<UsuariosDTO> GetByLogin(UserModel model)
        {
            var user = _repository.Get(model.Login);
            if (user == null)
                throw new Exception(Errors.UserNotFound);

            return user;
        }

        public void Register(UserModel model)
        {
            //    var hasUser = GetByLogin(model);
           // if (hasUser != null)
             //   throw new Exception(Errors.DuplicateEmail);



           var user = new UsuariosDTO(model.Login);
            user.SetPassword(model.Password, model.ConfirmPassword);
            user.Validate();

            _repository.Create(user);

        }

        public string ResetPassword(UserModel model)
        {
            
            var user = GetByLogin(model);
            //var password = user.ResetPassword();
            //user.Validate();

            //_repository.Update(user);
            return "";// password;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
        
    }


}
