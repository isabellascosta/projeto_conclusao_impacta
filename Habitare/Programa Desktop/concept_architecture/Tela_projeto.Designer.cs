namespace concept_architecture
{
    partial class Tela_projeto
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label desc_pedLabel;
            System.Windows.Forms.Label data_pedLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtFase = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.txtCpfFuncionario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnHabilitaBusca = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            desc_pedLabel = new System.Windows.Forms.Label();
            data_pedLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(234, 285);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 35);
            label3.TabIndex = 56;
            // 
            // desc_pedLabel
            // 
            desc_pedLabel.AutoSize = true;
            desc_pedLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desc_pedLabel.Location = new System.Drawing.Point(58, 133);
            desc_pedLabel.Name = "desc_pedLabel";
            desc_pedLabel.Size = new System.Drawing.Size(20, 18);
            desc_pedLabel.TabIndex = 48;
            desc_pedLabel.Text = "ID ";
            // 
            // data_pedLabel
            // 
            data_pedLabel.AutoSize = true;
            data_pedLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_pedLabel.Location = new System.Drawing.Point(53, 242);
            data_pedLabel.Name = "data_pedLabel";
            data_pedLabel.Size = new System.Drawing.Size(57, 18);
            data_pedLabel.TabIndex = 49;
            data_pedLabel.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(53, 318);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 18);
            label2.TabIndex = 84;
            label2.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(53, 284);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 18);
            label5.TabIndex = 86;
            label5.Text = "Fase";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(56, 169);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 18);
            label6.TabIndex = 91;
            label6.Text = "CPF do cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(56, 204);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 18);
            label4.TabIndex = 94;
            label4.Text = "Arquiteto";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(184, 131);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 35);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cadastro de Projetos";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(184, 242);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(293, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Location = new System.Drawing.Point(580, 199);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 74);
            this.btnAlterar.TabIndex = 78;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(499, 201);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 72);
            this.btnAdicionar.TabIndex = 76;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtFase
            // 
            this.txtFase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFase.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFase.Location = new System.Drawing.Point(184, 279);
            this.txtFase.Name = "txtFase";
            this.txtFase.Size = new System.Drawing.Size(293, 20);
            this.txtFase.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtStatus.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txtStatus.Location = new System.Drawing.Point(184, 314);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(293, 27);
            this.txtStatus.TabIndex = 5;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Transparent;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.Gray;
            this.btnExibir.Location = new System.Drawing.Point(621, 368);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(78, 39);
            this.btnExibir.TabIndex = 89;
            this.btnExibir.Text = "exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
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
            this.clnDescricao,
            this.clnFase,
            this.clnStatus});
            this.dgvLista.GridColor = System.Drawing.Color.Gray;
            this.dgvLista.Location = new System.Drawing.Point(85, 458);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.Size = new System.Drawing.Size(614, 133);
            this.dgvLista.TabIndex = 88;
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
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            // 
            // clnFase
            // 
            this.clnFase.Frozen = true;
            this.clnFase.HeaderText = "Fase";
            this.clnFase.Name = "clnFase";
            this.clnFase.ReadOnly = true;
            // 
            // clnStatus
            // 
            this.clnStatus.Frozen = true;
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpfCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpfCliente.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCliente.Location = new System.Drawing.Point(185, 169);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(192, 20);
            this.txtCpfCliente.TabIndex = 1;
            this.txtCpfCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(392, 169);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(85, 20);
            this.txtIdCliente.TabIndex = 92;
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdFuncionario.Enabled = false;
            this.txtIdFuncionario.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFuncionario.Location = new System.Drawing.Point(392, 204);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(85, 20);
            this.txtIdFuncionario.TabIndex = 95;
            // 
            // txtCpfFuncionario
            // 
            this.txtCpfFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpfFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpfFuncionario.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfFuncionario.Location = new System.Drawing.Point(185, 204);
            this.txtCpfFuncionario.Name = "txtCpfFuncionario";
            this.txtCpfFuncionario.Size = new System.Drawing.Size(192, 20);
            this.txtCpfFuncionario.TabIndex = 2;
            this.txtCpfFuncionario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 27);
            this.button1.TabIndex = 96;
            this.button1.Text = "busca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(94, 420);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 16);
            this.numericUpDown1.TabIndex = 89;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // btnHabilitaBusca
            // 
            this.btnHabilitaBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitaBusca.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitaBusca.Location = new System.Drawing.Point(334, 126);
            this.btnHabilitaBusca.Name = "btnHabilitaBusca";
            this.btnHabilitaBusca.Size = new System.Drawing.Size(117, 32);
            this.btnHabilitaBusca.TabIndex = 89;
            this.btnHabilitaBusca.Text = "Habilitar Busca";
            this.btnHabilitaBusca.UseVisualStyleBackColor = true;
            this.btnHabilitaBusca.Click += new System.EventHandler(this.btnHabilitaBusca_Click);
            // 
            // Tela_projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.btnHabilitaBusca);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdFuncionario);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtCpfFuncionario);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(label5);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtFase);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(desc_pedLabel);
            this.Controls.Add(data_pedLabel);
            this.Controls.Add(this.txtDescricao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_projeto";
            this.Text = "tela_pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtFase;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.TextBox txtCpfFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnHabilitaBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}