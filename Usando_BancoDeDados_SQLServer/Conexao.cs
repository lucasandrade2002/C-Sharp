using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_BancoDeDados_SQLServer {
    public class Conexao {

        SqlConnection db = new SqlConnection(); //Instancia uma nova conexão;

        public Conexao(){ //Indica o endereço do banco de dados;
            db.ConnectionString = "Data Source=DESKTOP-B7SLILB;Initial Catalog=teste;Integrated Security=True";
        }

        public SqlConnection Conectar(){// Conecta-se com o banco

            if(db.State == System.Data.ConnectionState.Closed) {
                db.Open();
            }
            return db;
        }

        public void Desconectar(){//Desconecta-se com o banco se ele estiver Aberto;

            if(db.State == System.Data.ConnectionState.Open){
                db.Close();
            }
            return;
        }
    }
}
