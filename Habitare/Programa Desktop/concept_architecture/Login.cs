using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using concept_architecture.Classes;

namespace concept_architecture
{
    public partial class Login : Form
    {
        Thread nt;
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var cmd = Conexao.Abrir();
            cmd.CommandText = "SELECT * FROM login WHERE usuario_login='" + txtUsuario.Text + "' AND senha_login='" + txtSenha.Text + "'";
            MySqlDataAdapter dp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Close();
                nt = new Thread(NovoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido");
            }
        }
        private void NovoForm()
        {
            Application.Run(new Menu());
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
