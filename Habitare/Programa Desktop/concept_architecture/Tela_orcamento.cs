using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using concept_architecture.Classes;


namespace concept_architecture
{
    public partial class Tela_orcamento : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        string strSQl;
        public Tela_orcamento()
        {
            InitializeComponent();
        }

  
        private void Soma()
        {
            decimal valor1 = 0, valor2 = 0, resultado = 0;

            if (txtPlanta.Text != "" && txtProjeto.Text != "")
            {
                valor1 = decimal.Parse(txtPlanta.Text);
                valor2 = decimal.Parse(txtProjeto.Text);

                resultado = valor1 + valor2;
            }

            txtTotal.Text = resultado.ToString();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Soma();
   
        }
        private void LimparCampos()
        {
            txtID.Clear();
            txtPagamento.Text = string.Empty;
            txtPlanta.Clear();
            txtProjeto.Clear();
            txtTotal.Clear();
            txtIdCliente.Clear();
            txtCpfFuncionario.Clear();
            CpfCliente.Clear();
            txtIdFuncionario.Clear();
            btnAdicionar.Enabled = true;
            btnHabilitaBusca.Text = "Habilitar Busca";
            txtID.ReadOnly = true;
            btnAlterar.Enabled = false;

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Orcamento orcamento = new Orcamento();
            var lista = orcamento.ListarOrcamento();
            lista.ForEach(a =>
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdOrcamento;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnFormaPagamento.Index].Value = a.FormaPagamento;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnValorPlanta.Index].Value = a.ValorPlanta;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnValorProjeto.Index].Value = a.ValorProjeto;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTotal.Index].Value = a.Total;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdCliente.Index].Value = a.IdCliente;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdFuncionario.Index].Value = a.IdFuncionario;

            });
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if (CpfCliente.Text.Length == 11)
            {
                //Captura o cpf digitado  na tela
                string Cpf = CpfCliente.Text;

                //Fazer a consulta no banco de dados

                conexao = new MySqlConnection("server=127.0.0.1;database=habitare;user id=root;password=");

                strSQl = $"SELECT *  FROM cliente WHERE CPF_CLIENTE = '{Cpf}'";
                comando = new MySqlCommand(strSQl, conexao);
                da = new MySqlDataAdapter(strSQl, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txtIdCliente.Text = dt.Rows[0]["id_cliente"].ToString();
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado", "Erro ao consultar cliente");
                }
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if (txtCpfFuncionario.Text.Length == 11)
            {
                //Captura o cpf digitado  na tela
                string Cpf = txtCpfFuncionario.Text;

                //Fazer a consulta no banco de dados

                conexao = new MySqlConnection("server=127.0.0.1;database=habitare;user id=root;password=");

                strSQl = $"SELECT *  FROM funcionario WHERE CPF_FUNCIONARIO = '{Cpf}'";
                comando = new MySqlCommand(strSQl, conexao);
                da = new MySqlDataAdapter(strSQl, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txtIdFuncionario.Text = dt.Rows[0]["id_funcionario"].ToString();
                }
                else
                {
                    MessageBox.Show("Nome não cadastrado", "Erro ao consultar Funcionario");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Orcamento orcamento = new Orcamento();
            var lista = orcamento.ListarOrcamento(0, (int)numericUpDown1.Value);
            lista.ForEach(a =>
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdOrcamento;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnFormaPagamento.Index].Value = a.FormaPagamento;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnValorPlanta.Index].Value = a.ValorPlanta;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnValorProjeto.Index].Value = a.ValorProjeto;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTotal.Index].Value = a.Total;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdCliente.Index].Value = a.IdCliente;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdFuncionario.Index].Value = a.IdFuncionario;

            });
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = (decimal)Cliente.ObterQuantidadeRegistros();
        }

        private void btnHabilitaBusca_Click(object sender, EventArgs e)
        {
            if (btnHabilitaBusca.Text == "Habilitar Busca")
            {
                txtID.ReadOnly = false;
                txtID.Focus();
                btnAdicionar.Enabled = false;
                btnAlterar.Enabled = true;
                btnHabilitaBusca.Text = "Buscar";
            }
            else if (btnHabilitaBusca.Text == "Buscar")
            {
                if (txtID.Text != string.Empty)
                {
                    string clientevar;
                    string funcionariovar;
                    Orcamento orcamento = new Orcamento();
                    orcamento.ConsultarPorId(int.Parse(txtID.Text));
                    txtPagamento.Text = orcamento.FormaPagamento;
                    txtPlanta.Text = orcamento.ValorPlanta;
                    txtProjeto.Text = orcamento.ValorProjeto;
                    txtTotal.Text = orcamento.Total;
                    clientevar = Convert.ToString(orcamento.IdCliente);
                    txtIdCliente.Text = clientevar;
                    funcionariovar = Convert.ToString(orcamento.IdFuncionario);
                    txtIdFuncionario.Text = funcionariovar;

                }

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.IdOrcamento = int.Parse(txtID.Text);
            orcamento.FormaPagamento = txtPagamento.Text;
            orcamento.ValorPlanta = txtPlanta.Text;
            orcamento.ValorProjeto = txtProjeto.Text;
            orcamento.Total = txtTotal.Text;
            orcamento.IdCliente = int.Parse(txtIdCliente.Text);
            orcamento.IdFuncionario = int.Parse(txtIdFuncionario.Text);
            orcamento.Alterar(orcamento);
            MessageBox.Show("Cadastro de orcamentos alterado com sucesso!");
            LimparCampos();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            int valorcliente;
            int valorfuncionario;
            Orcamento orcamento = new Orcamento
                (
                    0,
                    txtPagamento.Text,
                    txtPlanta.Text,
                    txtProjeto.Text,
                    txtTotal.Text,
                    valorcliente = Convert.ToInt32(txtIdCliente.Text),
                    valorfuncionario = Convert.ToInt32(txtIdFuncionario.Text)

                );

            orcamento.Inserir();
            txtID.Text = orcamento.IdOrcamento.ToString();
            MessageBox.Show("Orcamento inserido com sucesso!");
            LimparCampos();
        }
    }
}
