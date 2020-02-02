namespace Bazar.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
         "dbo.Usuarios",
         c => new
         {
             IdUsuario = c.Int(nullable: false, identity: true),
             Login = c.String(nullable: false, maxLength: 60),
             Password = c.String(maxLength: 32, fixedLength: true),
         })
         .PrimaryKey(t => t.IdUsuario);

            CreateTable(
        "dbo.TableProdutos",

        c => new
        {
            IdProduto = c.Int(nullable: false, identity: true),
            NomeProduto = c.String(nullable: false, maxLength: 128),
            TipoProduto = c.String(nullable: false, maxLength: 128),
            PrecoProduto = c.Double(),
            QuantidadeProduto = c.Int(),
            DescricaoProduto = c.String(),
        })
        .PrimaryKey(t => t.IdProduto);

            CreateTable(
                "dbo.TableFuncionarios",

                c => new
                {

                    NomeFuncionario = c.String(),
                    IdadeFuncionario = c.Int(),
                    RGFuncionario = c.String(),
                    CPFfuncionario = c.String(),
                    SexoFuncionario = c.String(),
                    EnderecoFuncionario = c.String(),
                    BairroFuncionario = c.String(),
                    TelefoneFuncionario = c.String(),
                    CelularFuncinario = c.String(),
                    FuncaoFuncionario = c.String(),
                    SalarioFuncionario = c.Double(),
                    IdFuncionario = c.Int(nullable: false, identity: true),

                })
        .PrimaryKey(t => t.IdFuncionario);


            CreateTable(

                "dbo.TableFornecedores",

                c => new
                {
                    Nomefornecedor = c.String(),
                    Cnpj = c.String(),
                    Produtoentregue = c.String(),
                    Telefonefornecedor = c.String(),
                    Telefonefornecedor2 = c.String(),
                    Precoprodutoforn = c.Double(),
                    QuantidadeprodutoF = c.Int(),
                    DataentregaF = c.String(),
                    Emailfornecedor = c.String(),
                    Representante = c.String(),
                    IdFornecedor = c.Int(nullable: false, identity: true),

                })
        .PrimaryKey(t => t.IdFornecedor);


            CreateTable(
                "dbo.TableClientes",

                c => new
                {
                    NomeCliente = c.String(),
                    TelefoneCliente = c.String(),
                    CelularCliente = c.String(),
                    EmailCliente = c.String(),
                    EnderecoCliente = c.String(),
                    BairroCliente = c.String(),
                    NumeroCliente = c.String(),
                    CPFCliente = c.String(),
                    IdCliente = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.IdCliente);

        }

    

    public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.TableProdutos");
            DropTable("dbo.TableFuncionarios");
            DropTable("dbo.TableFornecedores");
            DropTable("dbo.TableClientes");
        }








    }
}
    