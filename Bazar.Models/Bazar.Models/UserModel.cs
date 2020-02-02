using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
   public class UserModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public int IdUsuario { get; set; }

    }
}
