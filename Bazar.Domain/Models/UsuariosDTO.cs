using Bazar.Common.Resources;
using Bazar.Common.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bazar.Models
{
    public class UsuariosDTO
    {
        #region Ctor

        public UsuariosDTO() { }

        public UsuariosDTO(string login)
        {
         //   this.IdUsuario = IdUsuario;
            this.Login = login;
           
        }
        #endregion

        #region Properties

        public string Login { get; set; }
        public string Password { get; set; }
        [Key]
        public int IdUsuario { get; set; }

        #endregion

        #region Methods
        public void SetPassword(string password, string confirmPassword)
        {

            AssertionConcern.AssertArgumentNotNull(password, Errors.InvalidPassword);
            AssertionConcern.AssertArgumentNotNull(confirmPassword, Errors.InvalidPasswordConfirmation);
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, Errors.PasswordDoNotMatch);
            AssertionConcern.AssertArgumentLength(password, 6, 20, Errors.InvalidPassword);

            this.Password = PasswordAssertionConcern.Encrypt(password);
        }

        public string ResetPassword()
        {
            string password = Guid.NewGuid().ToString().Substring(0, 8);
            this.Password = PasswordAssertionConcern.Encrypt(password);

            return password;
        }

        public void ChangeLogin(string login)
        {

            this.Login = login;
        }

        public void Validate()
        {
            AssertionConcern.AssertArgumentLength(this.Login, 3, 60, Errors.InvalidUserName);


        }

        #endregion
    }
}
