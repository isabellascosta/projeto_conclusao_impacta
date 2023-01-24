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
using System.Runtime.InteropServices;
namespace concept_architecture
{
    public partial class Login_cliente : Form
    {
        Thread nt;
        public Login_cliente()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
          

            if (textBox1.Text == "ConceptA@gmail.com" && textBox2.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido");
            }
        }

        private static void novoForm()
        {
      
        }


    }
}
