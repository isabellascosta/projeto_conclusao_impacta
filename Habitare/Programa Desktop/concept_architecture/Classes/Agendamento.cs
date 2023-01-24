using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace concept_architecture.Classes
{
    public class Agendamento
    {   //Metodo contrutor
        public Agendamento(int idagendamento = 0,
            string nome = null,
            string telefone = null,
            string email = null,
            string assunto = null, 
            string mensagem = null)
        {
            IdAgendamento = idagendamento;
            Nome = nome;
            Telefone = telefone;
            Email = email;          
            Assunto = assunto;
            Mensagem = mensagem;
        }

        public int IdAgendamento { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }

        public void Inserir()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insere_agendamento";
            cmd.Parameters.AddWithValue("_id", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_nome", Nome).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_telefone", Telefone).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_email", Email).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_assunto", Assunto).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_Mensagem", Mensagem).Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            IdAgendamento = Convert.ToInt32(cmd.Parameters["_id"].Value);

        }
        public List<Agendamento> ListarAgendamentos(int inicio = 0, int limite = 0)
        {
            List<Agendamento> lista = new List<Agendamento>();
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            if (limite > 0)
                cmd.CommandText = "select * from agendamento limit "+ inicio + "," + limite;
            else
                cmd.CommandText = "select * from agendamento";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Agendamento(
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
        public void ConsultarPorId(int id_agendamento)
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from agendamento where id_agendamento = " + id_agendamento;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IdAgendamento = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Telefone = dr.GetString(2);
                Email = dr.GetString(3);
                Assunto = dr.GetString(4);
                Mensagem = dr.GetString(5);
            }
        }
        public static int ObterQuantidadeRegistros()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandText = "select count(*) from agendamento";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void Alterar(Agendamento agendamento)
        {
            try
            {
                var cmd = Conexao.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_agendamento";
                cmd.Parameters.AddWithValue("_id", IdAgendamento).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_nome", Nome).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_telefone", Telefone).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_email", Email).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_assunto", Assunto).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_Mensagem", Mensagem).Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw;
            }

        }
    }

}
