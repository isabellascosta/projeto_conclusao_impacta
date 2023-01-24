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
    public partial class Tela_cliente : Form
    {

        public Tela_cliente()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCep.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtID.Clear();
            txtEstado.Text = string.Empty;
            txtRg.Clear();
            txtIdAgendamento.Clear();
            txtNumeroCasa.Clear();
            btnAdicionar.Enabled = true;
            btnHabilitaBusca.Text = "Habilitar Busca";
            txtID.ReadOnly = true;
            btnAlterar.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor;
            Cliente cliente = new Cliente
                (
                    0,
                    txtNome.Text,
                    txtEmail.Text,
                    txtTelefone.Text,
                    txtCpf.Text,
                    txtRg.Text,
                    txtCep.Text,
                    txtEstado.Text,
                    txtEndereco.Text,
                    txtNumeroCasa.Text,
                    valor = Convert.ToInt32(txtIdAgendamento.Text)


                );
            cliente.Inserir();
            txtID.Text = cliente.IdCliente.ToString();
            MessageBox.Show("Cliente inserido com sucesso!");
            LimparCampos();

        }

        private void exibir_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Cliente cliente = new Cliente();
            var lista = cliente.ListarCliente();
            lista.ForEach(a =>
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdCliente;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnRg.Index].Value = a.Rg;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEmail.Index].Value = a.Email;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnCpf.Index].Value = a.Cpf;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnCep.Index].Value = a.Cep;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEndereco.Index].Value = a.Endereco;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEstado.Index].Value = a.Estado;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNumeroCasa.Index].Value = a.NumeroCasa;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdAgendamento.Index].Value = a.IdAgendamento;


            });

        }

        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = (decimal)Cliente.ObterQuantidadeRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Cliente cliente = new Cliente();
            var lista = cliente.ListarCliente(0, (int)numericUpDown2.Value);
            lista.ForEach(a =>
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdCliente;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnRg.Index].Value = a.Rg;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEmail.Index].Value = a.Email;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnCpf.Index].Value = a.Cpf;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnCep.Index].Value = a.Cep;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEndereco.Index].Value = a.Endereco;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEstado.Index].Value = a.Estado;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNumeroCasa.Index].Value = a.NumeroCasa;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnIdAgendamento.Index].Value = a.IdAgendamento;


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
                    string agendamento;
                    Cliente cliente = new Cliente();
                    cliente.ConsultarPorId(int.Parse(txtID.Text));
                    txtNome.Text = cliente.Nome;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;
                    txtCpf.Text = cliente.Cpf;
                    txtRg.Text = cliente.Rg;
                    txtCep.Text = cliente.Cep;
                    txtEstado.Text = cliente.Estado;
                    txtEndereco.Text = cliente.Endereco;
                    txtNumeroCasa.Text = cliente.NumeroCasa;
                    agendamento = Convert.ToString(cliente.IdAgendamento);
                    txtIdAgendamento.Text = agendamento;
                   
                }

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = int.Parse(txtID.Text);
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Rg = txtRg.Text;
            cliente.Cep = txtCep.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.NumeroCasa = txtNumeroCasa.Text;
            cliente.IdAgendamento = int.Parse(txtIdAgendamento.Text);
            cliente.Alterar(cliente);
            MessageBox.Show("Cadastro de cliente alterado com sucesso!");
            LimparCampos();
        }
    }
    }

