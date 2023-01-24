using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace concept_architecture.Classes
{
    class Funcionario
    {
        public Funcionario(int idfuncionario=0,
            string nome=null,
            string rg=null, 
            string cpf=null, 
            string telefone=null, 
            string status= null)
        {
            IdFuncionario = idfuncionario;
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Telefone = telefone;
            Status = status;
        }


        //Propriedades
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Status  { get; set; }

        public void Inserir()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insere_funcionario";
            cmd.Parameters.AddWithValue("_id", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_nome", Nome).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_rg", Rg).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_cpf", Cpf).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_telefone", Telefone).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_status", Status).Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            IdFuncionario= Convert.ToInt32(cmd.Parameters["_id"].Value);

        }

        public List<Funcionario> ListarFuncionarios(int inicio = 0, int limite = 0)
        {
            List<Funcionario> lista = new List<Funcionario>();
            var cmd = Conexao.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            if (limite > 0)
                cmd.CommandText = "select * from funcionario limit " + inicio + "," + limite;
            else
                cmd.CommandText = "select * from funcionario";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Funcionario(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5)
                    ));
            }
            return lista;
        }
         public void ConsultarPorId(int id_funcionario)
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from  funcionario where id_funcionario = " +id_funcionario;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IdFuncionario = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Rg = dr.GetString(2);
                Cpf = dr.GetString(3);
                Telefone = dr.GetString(4);
                Status = dr.GetString(5);

            }
        }
        
        public static int ObterQuantidadeRegistros()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandText = "select count(*) from funcionario";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void Alterar(Funcionario funcionario)
        {
            
            var cmd = Conexao.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update funcionario set nome_funcionario='"+funcionario.Nome+"',rg_funcionario='"+funcionario.Rg+"',cpf_funcionario='"+funcionario.Cpf+"',telefone_funcionario='"+funcionario.Telefone+"',status_funcionario='"+funcionario.Status+"' where id_funcionario = "+funcionario.IdFuncionario;
            cmd.ExecuteNonQuery();

           
        }

    }
}
