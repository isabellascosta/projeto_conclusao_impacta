using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace concept_architecture
{
    public partial class Menu : Form
    {
        

        public Menu()
        {
            InitializeComponent();
        }

        private void bttfuncionario_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Tela_projeto());
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel12_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Button8_Click(object sender, EventArgs e)
        {
           
        }

        private void Btncliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Tela_cliente());
        }
   


        
        private void Btnorcamentos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Tela_orcamento());

        }

        

        private void Btnfuncionarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Tela_funcionarios());
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Tela_sobre());
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmax.Visible = false;
            btnrest.Visible = true;


        }

        private void Btnrest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrest.Visible = false;
            btnmax.Visible = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnrest_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Pnl_barra_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void SendMessage(IntPtr handle, int v1, int v2, int v3)
        {
            
        }

        private void releaseCapture()
        {
            
        }

        private void Concept_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new inicio());
        }

        private void PnlButtonped_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormHija(new Tela_Agendamento());
        }

        private void PnlButtonOrc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlButtonfunc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Tela_cliente());
        }
    }
}
