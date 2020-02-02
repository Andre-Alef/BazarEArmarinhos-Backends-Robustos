 using Bazar.Models;
using System.Data.Entity.ModelConfiguration;

namespace Bazar.Infraestructure.Data.Map
{
    public class UserMap : EntityTypeConfiguration<UsuariosDTO>
    {
        public UserMap()
        {
            ToTable("Usuarios");
        }
    }

    public class ProdutosMap : EntityTypeConfiguration<ProdutosDTO>
    {
        public ProdutosMap()
        {
            ToTable("TableProdutos");
        }

    }

    public class FuncionariosMap : EntityTypeConfiguration<FuncionariosDTO>
    {
        public FuncionariosMap()
        {
            ToTable("TableFuncionarios");
        }

    }

    public class FornecedoresMap : EntityTypeConfiguration<FornecedoresDTO>
    {
        public FornecedoresMap()
        {
            ToTable("TableFornecedores");
        }

    }

    public class ClientesMap : EntityTypeConfiguration<ClientesDTO>
    {
        public ClientesMap()
        {
            ToTable("TableClientes");
        }

    }
}




