
using Bazar.Business.Services;
using Bazar.Domain.Contracts.Repositories;
using Bazar.Domain.Contracts.Services;
using Bazar.Infraestructure.Data;
using Bazar.Infraestructure.Repositories;
using Bazar.Models;
using Unity;
using Unity.Lifetime;
namespace Bazar.StartUp
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());

            container.RegisterType<IClientesRepository, ClientesRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IClientesService, ClientesService>(new HierarchicalLifetimeManager());

            container.RegisterType<IProductRepository, ProdutosRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProdutosService, ProdutosService>(new HierarchicalLifetimeManager());

            container.RegisterType<IFornecedoresRepository, FornecedoresRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IFornecedoresService, FornecedoresService>(new HierarchicalLifetimeManager());

            container.RegisterType<IFuncionariosRepository, FuncionariosRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IFuncionariosService, FuncionariosService>(new HierarchicalLifetimeManager());



            container.RegisterType<UsuariosDTO, UsuariosDTO>(new HierarchicalLifetimeManager());
            container.RegisterType<ClientesDTO, ClientesDTO>(new HierarchicalLifetimeManager());
            container.RegisterType<ProdutosDTO, ProdutosDTO>(new HierarchicalLifetimeManager());
            container.RegisterType<FornecedoresDTO, FornecedoresDTO>(new HierarchicalLifetimeManager());
            container.RegisterType<FuncionariosDTO, FuncionariosDTO>(new HierarchicalLifetimeManager());



        }


    }
}
