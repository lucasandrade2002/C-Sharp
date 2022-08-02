using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_BancoDeDados_SQLServer
{
    class Cadastrar{
        public string msg;
        Conexao con = new Conexao();
        SqlCommand command = new SqlCommand();
        public Cadastrar(string nome, string fone)
        {
            //SqlComandos
            command.CommandText = "insert into usuarios (nome, fone) values (@nome, @fone)";

            //Parâmetros
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@fone", fone);

            //Conectar com o banco
            try
            {
                command.Connection = con.Conectar();
                //Execute o comando
                command.ExecuteNonQuery();
                //Desconectar
                con.Desconectar();
                //Mostrar a mensagem de erro ou sucesso!
                this.msg = "Cadastrado com Sucesso!";

            }catch(Exception e){
                this.msg = "Houve algum erro durante a inserção no banco de dados!";
            }
        }
    }
}
