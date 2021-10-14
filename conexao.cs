using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundBra
{
    class conexao
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=infoelectra;Uid=root;Pwd=;SslMode=none;");

        public void conectar()
        {
            conn.Open();
           
        }

        public void desconectar()
        {
            conn.Close();
        }
       
            
             


}
    }

