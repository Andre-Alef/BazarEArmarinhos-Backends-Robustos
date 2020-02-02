using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Bazar.Dados
{


   public class conexao
    {
        private DataTable data;
        private SqlDataAdapter da;
        private SqlCommandBuilder cb;
        

        public string conn = "Data Source=ALEF-PC;Initial Catalog=msdb;Integrated Security=True";
        // public String conn = "Data Source=DELL-PC;Initial Catalog=msdb;Integrated Security=True";
        // public String conn = "Server=127.0.0.1;Port=3307;Database=tcc;Uid=root;Pwd=usbw;";


        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(da);
            da.Fill(data);

            return data;

        }

    }

    
}
