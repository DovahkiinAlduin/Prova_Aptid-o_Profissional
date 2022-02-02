using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arqueologia.BD
{
    class Conexao
    {
        private MySqlConnection con = new MySqlConnection();
        private string sqlconexao;
        
        public Conexao()
        {
            con.ConnectionString = @"server=127.0.0.1;user id=root;@Kukasnina21@@;database=arqueologia";
        }

        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
