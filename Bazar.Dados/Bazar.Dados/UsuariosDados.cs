using System;

using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Bazar.Models;
using Bazar.StartUp;
using Unity;
using Bazar.Domain.Contracts.Services;

namespace Bazar.Dados
{
    public class UsuariosDados
    {
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        Bazar.Dados.conexao cn = new Dados.conexao();
        UserModel model = new UserModel();

        
    }
} 