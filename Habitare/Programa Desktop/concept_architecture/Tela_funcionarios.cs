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

    public partial class Tela_funcionarios : Form
    {

        public Tela_funcionarios()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtID.Clear();
            txtRg.Clear();
            txtStatus.Text = string.Empty;
            btnAdicionar.Enabled = true;
            btnHabilitaBusca.Text = "Habilitar Busca";
            txtID.ReadOnly = true;
            btnAlterar.Enabled = false;
          
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
                    Funcionario funcionario = new Funcionario
            (
                0,
                txtNome.Text,
                txtRg.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtStatus.Text

            );
                    funcionario.Inserir();
                    txtID.Text = funcionario.IdFuncionario.ToString();
                    MessageBox.Show("Funcionário inserido com sucesso!");
                    LimparCampos();
        }

        private void exibir_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Funcionario funcionario = new Funcionario();
            var lista = funcionario.ListarFuncionarios();
            lista.ForEach(a => {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdFuncionario;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnRg.Index].Value = a.Rg;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnCpf.Index].Value = a.Cpf;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnStatus.Index].Value = a.Status;
            });

        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = (decimal)Funcionario.ObterQuantidadeRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Funcionario funcionario = new Funcionario();
            var lista = funcionario.ListarFuncionarios(0, (int)numericUpDown1.Value);
            lista.ForEach(a => {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.IdFuncionario;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnRg.Index].Value = a.Rg;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnCpf.Index].Value = a.Cpf;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnStatus.Index].Value = a.Status;
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
            else if (btnHabilitaBusca.Text=="Buscar")
            {
                if (txtID.Text != string.Empty)
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ConsultarPorId(int.Parse(txtID.Text));
                    txtNome.Text = funcionario.Nome;
                    txtRg.Text = funcionario.Rg;
                    txtCpf.Text = funcionario.Cpf;
                    txtTelefone.Text = funcionario.Telefone;
                    txtStatus.Text = funcionario.Status;
                }
            }

            

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.IdFuncionario = int.Parse(txtID.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.Rg = txtRg.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Status = txtStatus.Text;
            funcionario.Alterar(funcionario);

            MessageBox.Show("Funcionario alterado com sucesso!");
            LimparCampos();
        }

    }

}
