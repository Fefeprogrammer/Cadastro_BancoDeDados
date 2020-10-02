using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_BancoDeDados.Classes
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Método Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-EBULI8S\SQLEXPRESS;Initial Catalog=myDataBase;Integrated Security=True";  
        }

        //Método para conectar
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Método para desconectar
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
