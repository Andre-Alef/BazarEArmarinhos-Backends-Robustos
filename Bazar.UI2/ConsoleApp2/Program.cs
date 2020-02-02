using Bazar.Infraestructure.Repositories;
using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new UsuariosDTO("AndrE123");
            user.SetPassword("Andrealef", "Andrealef");

            user.Validate();

            Console.WriteLine(user.IdUsuario);

            using (IUserRepository userRep = new UserRepository())
            {
                userRep.Create(user);
            }

            Console.WriteLine(user.IdUsuario);

            Console.ReadKey();




        }
    }
}
