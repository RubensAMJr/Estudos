using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2
{
    class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User=root;Password=;Server=localhost;Database=meuBanco";
            conexao.Open();

            return conexao;
        } 
    }
}
