using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace concept_architecture.Classes
{
    public class Projeto
    {
        public Projeto(int idProjeto = 0,
            string descricao = null,
            string fase = null,
            int idcliente = 0,
            string status = null,
            int idfuncionario = 0)
        {
            IdProjeto = idProjeto;
            Descricao = descricao;
            Fase = fase;
            IdCliente = idcliente;
            Status = status;
            IdFuncionario = idfuncionario;
        }

        public int IdProjeto { get; set; }
        public string Descricao  { get; set; }
        public string Fase { get; set; }
        public int IdCliente { get; set; }
        public string Status { get; set; }
        public int IdFuncionario { get; set; }


        public void Inserir()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insere_projeto";
            cmd.Parameters.AddWithValue("_id", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_descricao", Descricao).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_fase", Fase).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_clienteid", IdCliente).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_status", Status).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_funcionarioid", IdFuncionario).Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            IdProjeto = Convert.ToInt32(cmd.Parameters["_id"].Value);
        }
        public List<Projeto> ListarProjeto(int inicio = 0, int limite = 0)
        {
            List<Projeto> lista = new List<Projeto>();
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            if (limite > 0)
                cmd.CommandText = "select * from projeto limit " + inicio + "," + limite;
            else
                cmd.CommandText = "select * from projeto";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Projeto(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    Convert.ToInt32(dr.GetValue(3)),
                    dr.GetString(4),                  
                    Convert.ToInt32(dr.GetValue(5))

                    ));
            }
            return lista;
        }
        public void ConsultarPorId(int idprojeto)
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from projeto where id_projeto = " + idprojeto;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IdProjeto = dr.GetInt32(0);
                Descricao= dr.GetString(1);
                Fase= dr.GetString(2);
                IdCliente = dr.GetInt32(3);
                Status= dr.GetString(4);
                IdFuncionario = dr.GetInt32(5);

            }
        }
        public static int ObterQuantidadeRegistros()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandText = "select count(*) from Projeto";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(Projeto projeto)
        {
            try
            {
                var cmd = Conexao.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_projeto";
                cmd.Parameters.AddWithValue("_id", IdProjeto).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_descricao", Descricao).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_fase", Fase).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_clienteid", IdCliente).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_status", Status).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_funcionarioid", IdFuncionario).Direction = ParameterDirection.Input;   
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
