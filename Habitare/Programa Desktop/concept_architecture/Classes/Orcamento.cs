using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace concept_architecture.Classes
{
    public class Orcamento
    {
        //metodo construtor
        public Orcamento(int idorcamento = 0,
            string formapagamento = null, 
            string valorplanta = null,
            string valorprojeto = null,
            string total = null,
            int idcliente = 0,
            int idfuncionario = 0)
        {
            IdOrcamento = idorcamento;
            FormaPagamento = formapagamento;
            ValorPlanta = valorplanta;
            ValorProjeto = valorprojeto;
            Total = total;
            IdCliente = idcliente;
            IdFuncionario = idfuncionario;
        }

        public int IdOrcamento { get; set; }
        public string FormaPagamento { get; set; }
        public string ValorPlanta { get; set; }
        public string ValorProjeto { get; set; }
        public string Total { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }

        public void Inserir()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insere_orcamento";
            cmd.Parameters.AddWithValue("_id", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_formapagamento", FormaPagamento).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_valorplanta", ValorPlanta).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_valorprojeto", ValorProjeto).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_total", Total).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_clienteid", IdCliente).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_funcionarioid", IdFuncionario).Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            IdOrcamento = Convert.ToInt32(cmd.Parameters["_id"].Value);

        }

        public List<Orcamento> ListarOrcamento(int inicio = 0, int limite = 0)
        {
            List<Orcamento> lista = new List<Orcamento>();
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            if (limite > 0)
                cmd.CommandText = "select * from orcamento limit " + inicio + "," + limite;
            else
                cmd.CommandText = "select * from orcamento";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Orcamento(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    Convert.ToInt32(dr.GetValue(5)),
                    Convert.ToInt32(dr.GetValue(6))

                    ));
            }
            return lista;
        }
        public void ConsultarPorId(int idorcamento)
        {
            var cmd = Conexao.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from orcamento where id_orcamento = " + idorcamento;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IdOrcamento = dr.GetInt32(0);
                FormaPagamento = dr.GetString(1);
                ValorPlanta = dr.GetString(2);
                ValorProjeto = dr.GetString(3);
                Total = dr.GetString(4);
                IdCliente = dr.GetInt32(5);
                IdFuncionario = dr.GetInt32(6);

            }
        }

        public static int ObterQuantidadeRegistros()
        {
            var cmd = Conexao.Abrir();
            cmd.CommandText = "select count(*) from orcamento";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(Orcamento orcamento)
        {
            try
            {
                var cmd = Conexao.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_orcamento";
                cmd.Parameters.AddWithValue("_id", IdOrcamento).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_formapagamento", FormaPagamento).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_valorplanta", ValorPlanta).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_valorprojeto", ValorProjeto).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_total", Total).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("_clienteid", IdCliente).Direction = ParameterDirection.Input;
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
