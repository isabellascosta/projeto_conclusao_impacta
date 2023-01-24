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
    public partial class Tela_projeto : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        string strSQl;
        public Tela_projeto()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtFase.Clear();
            txtID.Clear();
            txtCpfFuncionario.Clear();
            txtStatus.Text = string.Empty;
            txtIdCliente.Clear();
            txtIdFuncionario.Clear();
            txtCpfCliente.Clear();
            btnAdicionar.Enabled = true;
            btnHabilitaBusca.Text = "Habilitar Busca";
            txtID.ReadOnly = true;
            btnAlterar.Enabled = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int valorcliente;
            int valorfuncionario;
            Projeto projeto = new Projeto
                (
                    0,
                    txtDescricao.Text,
                    txtFase.Text,
                    valorcliente = Convert.ToInt32(txtIdCliente.Text),
                    txtStatus.Text,
                    valorfuncionario = Convert.ToInt32(txtIdFuncionario.Text)

                );

            projeto.Inserir();
            txtID.Text = projeto.IdProjeto.ToString();
            MessageBox.Show("Projeto inserido com sucesso!");
            LimparCampos();
        }

  


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if(txtCpfCliente.Text.Length == 11)
            {
                //Captura o cpf digitado  na tela
                string Cpf = txtCpfCliente.Text;

                //Fazer a consulta no banco de dados

                conexao = new MySqlConnection("server=127.0.0.1;database=habitare;user id=root;password=");

                strSQl = $"SELECT *  FROM cliente WHERE CPF_CLIENTE = '{Cpf}'";
                comando = new MySqlCommand(strSQl, conexao);
                da = new MySqlDataAdapter(strSQl, conexao);
                
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    txtIdCliente.Text = dt.Rows[0]["id_cliente"].ToString();
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado", "Erro ao consultar cliente");
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if (txtCpfFuncionario.Text.Length == 11 )
            {
                //Captura o cpf digitado  na tela
                string Cpf = txtCpfFuncionario.Text;

                //Fazer a consulta no banco de dados

                conexao = new MySqlConnection("server=127.0.0.1;database=habitare;user id=root;password=");

                strSQl = $"SELECT *  FROM funcionario WHERE Cpf_Funcionario = '{Cpf}'";
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
                    MessageBox.Show("Funcionário não cadastrado", "Erro ao consultar funcionario");
                }

            }
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = (decimal)Cliente.ObterQuantidadeRegistros();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Projeto projeto = new Projeto();
            var lista = projeto.ListarProjeto();
            lista.ForEach(a =>
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdProjeto;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnDescricao.Index].Value = a.Descricao;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnFase.Index].Value = a.Fase;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdCliente.Index].Value = a.IdCliente;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnStatus.Index].Value = a.Status;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdFuncionario.Index].Value = a.IdFuncionario;

            });
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Projeto projeto = new Projeto();
            var lista = projeto.ListarProjeto(0, (int)numericUpDown1.Value);
            lista.ForEach(a =>
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdProjeto;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnDescricao.Index].Value = a.Descricao;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnFase.Index].Value = a.Fase;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdCliente.Index].Value = a.IdCliente;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnStatus.Index].Value = a.Status;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdFuncionario.Index].Value = a.IdFuncionario;

            });
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
                    string idcliente;
                    string idfuncionario;
                    Projeto projeto = new Projeto();
                    projeto.ConsultarPorId(int.Parse(txtID.Text));
                    txtDescricao.Text = projeto.Descricao;
                    txtFase.Text = projeto.Fase;
                    idcliente = Convert.ToString(projeto.IdCliente);
                    txtIdCliente.Text = idcliente;
                    txtStatus.Text = projeto.Status;
                    idfuncionario = Convert.ToString(projeto.IdFuncionario);
                    txtIdFuncionario.Text = idfuncionario;

                }

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            projeto.IdProjeto = int.Parse(txtID.Text);
            projeto.Descricao = txtDescricao.Text;
            projeto.Fase = txtFase.Text;
            projeto.IdCliente = int.Parse(txtIdCliente.Text);
            projeto.Status = txtStatus.Text;
            projeto.IdFuncionario = int.Parse(txtIdFuncionario.Text);
            projeto.Alterar(projeto);
            MessageBox.Show("Cadastro de projeto alterado com sucesso!");
            LimparCampos();

            
        }
    }
}
