namespace concept_architecture
{
    partial class Tela_orcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label val_orcLabel;
            System.Windows.Forms.Label formp_orcLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.ComboBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExibir = new System.Windows.Forms.Button();
            this.CpfCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.txtCpfFuncionario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnHabilitaBusca = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            val_orcLabel = new System.Windows.Forms.Label();
            formp_orcLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(54, 259);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 18);
            label2.TabIndex = 19;
            label2.Text = "Valor da Planta";
            // 
            // val_orcLabel
            // 
            val_orcLabel.AutoSize = true;
            val_orcLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            val_orcLabel.Location = new System.Drawing.Point(54, 333);
            val_orcLabel.Name = "val_orcLabel";
            val_orcLabel.Size = new System.Drawing.Size(66, 18);
            val_orcLabel.TabIndex = 17;
            val_orcLabel.Text = "ValorTotal";
            // 
            // formp_orcLabel
            // 
            formp_orcLabel.AutoSize = true;
            formp_orcLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formp_orcLabel.Location = new System.Drawing.Point(54, 226);
            formp_orcLabel.Name = "formp_orcLabel";
            formp_orcLabel.Size = new System.Drawing.Size(132, 18);
            formp_orcLabel.TabIndex = 18;
            formp_orcLabel.Text = "Forma de pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(59, 125);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 18);
            label1.TabIndex = 25;
            label1.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(54, 159);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 18);
            label5.TabIndex = 105;
            label5.Text = "CPF Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(54, 297);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(104, 18);
            label6.TabIndex = 107;
            label6.Text = "Valor do Projeto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(54, 190);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 18);
            label7.TabIndex = 110;
            label7.Text = "CPF Arquiteto";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(185, 332);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(293, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPlanta
            // 
            this.txtPlanta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlanta.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanta.Location = new System.Drawing.Point(185, 257);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.Size = new System.Drawing.Size(293, 20);
            this.txtPlanta.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(185, 125);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(89, 20);
            this.txtID.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Location = new System.Drawing.Point(661, 217);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 79);
            this.btnAlterar.TabIndex = 74;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(562, 217);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 79);
            this.btnAdicionar.TabIndex = 72;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 35);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cadastro de orçamento";
            // 
            // txtPagamento
            // 
            this.txtPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPagamento.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.FormattingEnabled = true;
            this.txtPagamento.Items.AddRange(new object[] {
            "À vista",
            "Parcelas no carne"});
            this.txtPagamento.Location = new System.Drawing.Point(185, 217);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(293, 27);
            this.txtPagamento.TabIndex = 3;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnIdCliente,
            this.clnIdFuncionario,
            this.clnFormaPagamento,
            this.clnValorPlanta,
            this.clnValorProjeto,
            this.clnTotal});
            this.dgvLista.GridColor = System.Drawing.Color.Gray;
            this.dgvLista.Location = new System.Drawing.Point(38, 451);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.Size = new System.Drawing.Size(698, 148);
            this.dgvLista.TabIndex = 102;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            // 
            // clnIdCliente
            // 
            this.clnIdCliente.Frozen = true;
            this.clnIdCliente.HeaderText = "ID Cliente";
            this.clnIdCliente.Name = "clnIdCliente";
            this.clnIdCliente.ReadOnly = true;
            // 
            // clnIdFuncionario
            // 
            this.clnIdFuncionario.Frozen = true;
            this.clnIdFuncionario.HeaderText = "ID Funcionario";
            this.clnIdFuncionario.Name = "clnIdFuncionario";
            this.clnIdFuncionario.ReadOnly = true;
            // 
            // clnFormaPagamento
            // 
            this.clnFormaPagamento.Frozen = true;
            this.clnFormaPagamento.HeaderText = "Forma Pagamento";
            this.clnFormaPagamento.Name = "clnFormaPagamento";
            this.clnFormaPagamento.ReadOnly = true;
            // 
            // clnValorPlanta
            // 
            this.clnValorPlanta.Frozen = true;
            this.clnValorPlanta.HeaderText = "Valor Planta";
            this.clnValorPlanta.Name = "clnValorPlanta";
            this.clnValorPlanta.ReadOnly = true;
            // 
            // clnValorProjeto
            // 
            this.clnValorProjeto.Frozen = true;
            this.clnValorProjeto.HeaderText = "Valor Projeto";
            this.clnValorProjeto.Name = "clnValorProjeto";
            this.clnValorProjeto.ReadOnly = true;
            // 
            // clnTotal
            // 
            this.clnTotal.Frozen = true;
            this.clnTotal.HeaderText = "Total";
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Transparent;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.Black;
            this.btnExibir.Location = new System.Drawing.Point(658, 376);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(78, 40);
            this.btnExibir.TabIndex = 101;
            this.btnExibir.Text = "exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // CpfCliente
            // 
            this.CpfCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CpfCliente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfCliente.Location = new System.Drawing.Point(185, 157);
            this.CpfCliente.Name = "CpfCliente";
            this.CpfCliente.Size = new System.Drawing.Size(197, 20);
            this.CpfCliente.TabIndex = 1;
            this.CpfCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(388, 157);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(90, 20);
            this.txtIdCliente.TabIndex = 104;
            // 
            // txtProjeto
            // 
            this.txtProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjeto.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjeto.Location = new System.Drawing.Point(185, 297);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(293, 20);
            this.txtProjeto.TabIndex = 5;
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFuncionario.Enabled = false;
            this.txtIdFuncionario.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFuncionario.Location = new System.Drawing.Point(388, 188);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(90, 20);
            this.txtIdFuncionario.TabIndex = 109;
            // 
            // txtCpfFuncionario
            // 
            this.txtCpfFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpfFuncionario.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfFuncionario.Location = new System.Drawing.Point(185, 188);
            this.txtCpfFuncionario.Name = "txtCpfFuncionario";
            this.txtCpfFuncionario.Size = new System.Drawing.Size(197, 20);
            this.txtCpfFuncionario.TabIndex = 2;
            this.txtCpfFuncionario.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 98;
            this.button1.Text = "busca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(90, 410);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 16);
            this.numericUpDown1.TabIndex = 97;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // btnHabilitaBusca
            // 
            this.btnHabilitaBusca.BackColor = System.Drawing.SystemColors.Control;
            this.btnHabilitaBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitaBusca.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitaBusca.Location = new System.Drawing.Point(280, 122);
            this.btnHabilitaBusca.Name = "btnHabilitaBusca";
            this.btnHabilitaBusca.Size = new System.Drawing.Size(103, 29);
            this.btnHabilitaBusca.TabIndex = 97;
            this.btnHabilitaBusca.Text = "Habilitar Busca";
            this.btnHabilitaBusca.UseVisualStyleBackColor = false;
            this.btnHabilitaBusca.Click += new System.EventHandler(this.btnHabilitaBusca_Click);
            // 
            // Tela_orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.btnHabilitaBusca);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdFuncionario);
            this.Controls.Add(this.txtCpfFuncionario);
            this.Controls.Add(this.txtProjeto);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.CpfCliente);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPlanta);
            this.Controls.Add(label2);
            this.Controls.Add(val_orcLabel);
            this.Controls.Add(formp_orcLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_orcamento";
            this.Text = "tela_orcam";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPlanta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtPagamento;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox CpfCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.TextBox txtCpfFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnHabilitaBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdFuncionario;
    }
}