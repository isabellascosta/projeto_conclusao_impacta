using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace concept_architecture.Classes
{
    public class Cliente
    {
        //metodo construtor
        public Cliente(int idcliente = 0,
            string nome = null,
            string email = null,
            string telefone = null, 
            string cpf = null, 
            string rg = null, 
            string cep = null, 
            string estado = null, 
            string endereco = null, 
            string numeroCasa = null,
            int idagendamento = 0
            
          
            
            )
            
        {
            IdCliente = idcliente;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
            Cep = cep;
            Estado = estado;
            Endereco = endereco;
            NumeroCasa = numeroCasa;
            IdAgendamento = idagendamento;
        }

        //propriedades
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Endereco { get; set; }
        public string NumeroCasa { get; set; }
        public int IdAgendamento { get; set; }

        public void Inserir()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insere_cliente";
            cmd.Parameters.AddWithValue("_id", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_nome", Nome).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_email", Email).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_telefone", Telefone).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_cpf", Cpf).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_rg", Rg).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_cep", Cep).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_estado", Estado ).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_endereco", Endereco).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_numerocasa", NumeroCasa).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_agendamentoid", IdAgendamento).Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            IdCliente = Convert.ToInt32(cmd.Parameters["_id"].Value);


        }
        public List<Cliente> ListarCliente(int inicio = 0, int limite = 0)
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            if (limite > 0)
                cmd.CommandText = "select * from cliente limit " + inicio + "," + limite;
            else
                cmd.CommandText = "select * from cliente";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9),
                    Convert.ToInt32(dr.GetValue(10))

                    ));
            }
            return lista;
        }
        public void ConsultarPorId(int idcliente)
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cliente where id_cliente = " + idcliente;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               IdCliente = dr.GetInt32(0);
               Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Telefone = dr.GetString(3);
                Cpf = dr.GetString(4);
                Rg = dr.GetString(5);
                Cep = dr.GetString(6);
                Estado = dr.GetString(7);
                Endereco = dr.GetString(8);
                NumeroCasa = dr.GetString(9);
               IdAgendamento = dr.GetInt32(10);

            }
        }
        public static int ObterQuantidadeRegistros()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandText = "select count(*) from cliente";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(Cliente cliente)
        {
            try
            {
                var cmd = Conexao.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_cliente";
                cmd.Parameters.AddWithValue("_id", IdCliente).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_nome", Nome).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_email", Email).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_telefone", Telefone).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_cpf", Cpf).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_rg", Rg).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_cep", Cep).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_estado", Estado).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_endereco", Endereco).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_numerocasa", NumeroCasa).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_agendamentoid", IdAgendamento).Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
