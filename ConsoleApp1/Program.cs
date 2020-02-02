using Bazar.Domain.Contracts.Repositories;
using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new UsuariosDTO("AndreAlef");

            user.SetPassword("2345667899", "2345667899");
            user.Validate();

            Console.WriteLine()

            using (IUserRepository userRep = new UserRepository())
            {
                userRep.Create(user);
            }


        }
    }
}
