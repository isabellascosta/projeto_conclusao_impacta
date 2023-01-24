namespace concept_architecture
{
    partial class Tela_funcionarios
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
            System.Windows.Forms.Label id_funcLabel;
            System.Windows.Forms.Label nome_funcLabel;
            System.Windows.Forms.Label rg_funcLabel;
            System.Windows.Forms.Label cpf_funcLabel;
            System.Windows.Forms.Label tel_funcLabel;
            System.Windows.Forms.Label label1;
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exibir = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnHabilitaBusca = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            id_funcLabel = new System.Windows.Forms.Label();
            nome_funcLabel = new System.Windows.Forms.Label();
            rg_funcLabel = new System.Windows.Forms.Label();
            cpf_funcLabel = new System.Windows.Forms.Label();
            tel_funcLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_funcLabel
            // 
            id_funcLabel.AutoSize = true;
            id_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_funcLabel.Location = new System.Drawing.Point(98, 129);
            id_funcLabel.Name = "id_funcLabel";
            id_funcLabel.Size = new System.Drawing.Size(17, 18);
            id_funcLabel.TabIndex = 47;
            id_funcLabel.Text = "ID";
            // 
            // nome_funcLabel
            // 
            nome_funcLabel.AutoSize = true;
            nome_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_funcLabel.Location = new System.Drawing.Point(98, 167);
            nome_funcLabel.Name = "nome_funcLabel";
            nome_funcLabel.Size = new System.Drawing.Size(36, 18);
            nome_funcLabel.TabIndex = 49;
            nome_funcLabel.Text = "Nome";
            // 
            // rg_funcLabel
            // 
            rg_funcLabel.AutoSize = true;
            rg_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rg_funcLabel.Location = new System.Drawing.Point(98, 200);
            rg_funcLabel.Name = "rg_funcLabel";
            rg_funcLabel.Size = new System.Drawing.Size(22, 18);
            rg_funcLabel.TabIndex = 53;
            rg_funcLabel.Text = "RG";
            // 
            // cpf_funcLabel
            // 
            cpf_funcLabel.AutoSize = true;
            cpf_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpf_funcLabel.Location = new System.Drawing.Point(98, 233);
            cpf_funcLabel.Name = "cpf_funcLabel";
            cpf_funcLabel.Size = new System.Drawing.Size(27, 18);
            cpf_funcLabel.TabIndex = 54;
            cpf_funcLabel.Text = "CPF";
            // 
            // tel_funcLabel
            // 
            tel_funcLabel.AutoSize = true;
            tel_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tel_funcLabel.Location = new System.Drawing.Point(98, 264);
            tel_funcLabel.Name = "tel_funcLabel";
            tel_funcLabel.Size = new System.Drawing.Size(49, 18);
            tel_funcLabel.TabIndex = 55;
            tel_funcLabel.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(98, 291);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 18);
            label1.TabIndex = 82;
            label1.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 35);
            this.label3.TabIndex = 67;
            this.label3.Text = "Cadastro de funcionários";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(158, 231);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(328, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRg.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(158, 198);
            this.txtRg.Mask = "000000000";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(328, 20);
            this.txtRg.TabIndex = 3;
            this.txtRg.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(158, 127);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(143, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(158, 165);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Location = new System.Drawing.Point(599, 189);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 74);
            this.btnAlterar.TabIndex = 70;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(507, 191);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 74);
            this.btnAdicionar.TabIndex = 68;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.clnNome,
            this.clnRg,
            this.clnCpf,
            this.clnTelefone,
            this.clnStatus});
            this.dgvLista.GridColor = System.Drawing.Color.Gray;
            this.dgvLista.Location = new System.Drawing.Point(72, 441);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(590, 153);
            this.dgvLista.TabIndex = 73;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            // 
            // clnRg
            // 
            this.clnRg.Frozen = true;
            this.clnRg.HeaderText = "RG";
            this.clnRg.Name = "clnRg";
            this.clnRg.ReadOnly = true;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            // 
            // clnTelefone
            // 
            this.clnTelefone.Frozen = true;
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            this.clnTelefone.ReadOnly = true;
            // 
            // clnStatus
            // 
            this.clnStatus.Frozen = true;
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // exibir
            // 
            this.exibir.BackColor = System.Drawing.Color.Transparent;
            this.exibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibir.ForeColor = System.Drawing.Color.Black;
            this.exibir.Location = new System.Drawing.Point(584, 376);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(78, 39);
            this.exibir.TabIndex = 80;
            this.exibir.Text = "exibir";
            this.exibir.UseVisualStyleBackColor = false;
            this.exibir.Click += new System.EventHandler(this.exibir_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txtStatus.Location = new System.Drawing.Point(158, 292);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(328, 21);
            this.txtStatus.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 30);
            this.button1.TabIndex = 83;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(91, 395);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 16);
            this.numericUpDown1.TabIndex = 84;
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
            this.btnHabilitaBusca.Location = new System.Drawing.Point(324, 122);
            this.btnHabilitaBusca.Name = "btnHabilitaBusca";
            this.btnHabilitaBusca.Size = new System.Drawing.Size(100, 31);
            this.btnHabilitaBusca.TabIndex = 85;
            this.btnHabilitaBusca.Tag = "";
            this.btnHabilitaBusca.Text = "Habilitar Busca";
            this.btnHabilitaBusca.UseVisualStyleBackColor = true;
            this.btnHabilitaBusca.Click += new System.EventHandler(this.btnHabilitaBusca_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(158, 262);
            this.txtTelefone.Mask = "00000000000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(328, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // Tela_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnHabilitaBusca);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(id_funcLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(nome_funcLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(rg_funcLabel);
            this.Controls.Add(cpf_funcLabel);
            this.Controls.Add(tel_funcLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_funcionarios";
            this.Text = "tela_func";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button exibir;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnHabilitaBusca;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}