using Bazar.Infraestructure.Data.Map;
using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Infraestructure.Data
{
   public class AppDataContext: DbContext

    {
        public AppDataContext()
          : base("AppConnectionString")
        {

            Configuration.LazyLoadingEnabled = false;
     //       Configuration.AutoDetectChangesEnabled = true;
            Configuration.ProxyCreationEnabled = false;

        }

        public DbSet<UsuariosDTO> Usuarios { get; set; }
        public DbSet<ProdutosDTO> Produtos { get; set; }
        public DbSet<FornecedoresDTO> Fornecedores { get; set; }
        public DbSet<FuncionariosDTO> Funcionarios { get; set; }
        public DbSet<ClientesDTO> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ProdutosMap());
            modelBuilder.Configurations.Add(new FornecedoresMap());
            modelBuilder.Configurations.Add(new FuncionariosMap());
            modelBuilder.Configurations.Add(new ClientesMap());
        }
    }
}

