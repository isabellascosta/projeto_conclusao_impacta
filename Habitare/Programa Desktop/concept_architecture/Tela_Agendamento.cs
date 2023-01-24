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
    public partial class Tela_Agendamento : Form
    {

        public Tela_Agendamento()
        {
            InitializeComponent();
        }


        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtAssunto.Clear();
            txtMensagem.Clear();
            txtID.Clear();
            btnAdicionar.Enabled = true;
            btnHabilitaBusca.Text = "Habilitar Busca";
            txtID.ReadOnly = true;
            btnAlterar.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento
                (
                    0, 
                    txtNome.Text,
                    txtTelefone.Text,
                    txtEmail.Text,
                    txtAssunto.Text,
                    txtMensagem.Text

                );
            agendamento.Inserir();
            txtID.Text = agendamento.IdAgendamento.ToString();
            MessageBox.Show("Agendamento inserido com sucesso!");
            LimparCampos();

        }

        private void exibir_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Agendamento agendamento = new Agendamento();
            var lista = agendamento.ListarAgendamentos();
            lista.ForEach(a => {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdAgendamento;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEmail.Index].Value = a.Email;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnAssunto.Index].Value = a.Assunto;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnMensagem.Index].Value = a.Mensagem;
            });
            
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = (decimal)Agendamento.ObterQuantidadeRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Agendamento agendamento = new Agendamento();
            var lista = agendamento.ListarAgendamentos(0, (int)numericUpDown1.Value);
            lista.ForEach(a => {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdAgendamento;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEmail.Index].Value = a.Email;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnAssunto.Index].Value = a.Assunto;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnMensagem.Index].Value = a.Mensagem;
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
                    Agendamento agendamento = new Agendamento();
                    agendamento.ConsultarPorId(int.Parse(txtID.Text));
                    txtNome.Text = agendamento.Nome;
                    txtTelefone.Text = agendamento.Telefone;
                    txtEmail.Text = agendamento.Email;
                    txtAssunto.Text = agendamento.Assunto;
                    txtMensagem.Text = agendamento.Mensagem;
                }
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.IdAgendamento = int.Parse(txtID.Text);
            agendamento.Nome = txtNome.Text;
            agendamento.Telefone = txtTelefone.Text;
            agendamento.Email = txtEmail.Text;
            agendamento.Assunto = txtAssunto.Text;
            agendamento.Mensagem = txtMensagem.Text;
            agendamento.Alterar(agendamento);

            MessageBox.Show("Agendamento alterado com sucesso!");
            LimparCampos();
        }

    }
}
