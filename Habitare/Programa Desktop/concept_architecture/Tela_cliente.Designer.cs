namespace concept_architecture
{
    partial class Tela_cliente
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label rg_clienLabel;
            System.Windows.Forms.Label cpf_clienLabel;
            System.Windows.Forms.Label cnpj_clienLabel;
            System.Windows.Forms.Label email_clienLabel;
            System.Windows.Forms.Label nom_clienLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label idAgendamento;
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.exibir = new System.Windows.Forms.Button();
            this.txtIdAgendamento = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHabilitaBusca = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            rg_clienLabel = new System.Windows.Forms.Label();
            cpf_clienLabel = new System.Windows.Forms.Label();
            cnpj_clienLabel = new System.Windows.Forms.Label();
            email_clienLabel = new System.Windows.Forms.Label();
            nom_clienLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            idAgendamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(74, 357);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 18);
            label6.TabIndex = 50;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(74, 328);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 18);
            label5.TabIndex = 47;
            label5.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(74, 302);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 18);
            label3.TabIndex = 45;
            label3.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(73, 276);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 18);
            label2.TabIndex = 43;
            label2.Text = "Telefone";
            // 
            // rg_clienLabel
            // 
            rg_clienLabel.AutoSize = true;
            rg_clienLabel.BackColor = System.Drawing.Color.Transparent;
            rg_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rg_clienLabel.Location = new System.Drawing.Point(74, 194);
            rg_clienLabel.Name = "rg_clienLabel";
            rg_clienLabel.Size = new System.Drawing.Size(22, 18);
            rg_clienLabel.TabIndex = 32;
            rg_clienLabel.Text = "RG";
            // 
            // cpf_clienLabel
            // 
            cpf_clienLabel.AutoSize = true;
            cpf_clienLabel.BackColor = System.Drawing.Color.Transparent;
            cpf_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpf_clienLabel.Location = new System.Drawing.Point(74, 248);
            cpf_clienLabel.Name = "cpf_clienLabel";
            cpf_clienLabel.Size = new System.Drawing.Size(30, 18);
            cpf_clienLabel.TabIndex = 34;
            cpf_clienLabel.Text = "CPF ";
            // 
            // cnpj_clienLabel
            // 
            cnpj_clienLabel.AutoSize = true;
            cnpj_clienLabel.BackColor = System.Drawing.Color.Transparent;
            cnpj_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cnpj_clienLabel.Location = new System.Drawing.Point(74, 385);
            cnpj_clienLabel.Name = "cnpj_clienLabel";
            cnpj_clienLabel.Size = new System.Drawing.Size(73, 18);
            cnpj_clienLabel.TabIndex = 36;
            cnpj_clienLabel.Text = "Número Casa";
            // 
            // email_clienLabel
            // 
            email_clienLabel.AutoSize = true;
            email_clienLabel.BackColor = System.Drawing.Color.Transparent;
            email_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_clienLabel.Location = new System.Drawing.Point(74, 222);
            email_clienLabel.Name = "email_clienLabel";
            email_clienLabel.Size = new System.Drawing.Size(40, 18);
            email_clienLabel.TabIndex = 38;
            email_clienLabel.Text = "E-mail";
            // 
            // nom_clienLabel
            // 
            nom_clienLabel.AutoSize = true;
            nom_clienLabel.BackColor = System.Drawing.Color.Transparent;
            nom_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_clienLabel.Location = new System.Drawing.Point(74, 167);
            nom_clienLabel.Name = "nom_clienLabel";
            nom_clienLabel.Size = new System.Drawing.Size(36, 18);
            nom_clienLabel.TabIndex = 40;
            nom_clienLabel.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(74, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(17, 18);
            label4.TabIndex = 57;
            label4.Text = "ID";
            // 
            // idAgendamento
            // 
            idAgendamento.AutoSize = true;
            idAgendamento.BackColor = System.Drawing.Color.Transparent;
            idAgendamento.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAgendamento.Location = new System.Drawing.Point(75, 144);
            idAgendamento.Name = "idAgendamento";
            idAgendamento.Size = new System.Drawing.Size(88, 18);
            idAgendamento.TabIndex = 84;
            idAgendamento.Text = "Agendamento ID";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Location = new System.Drawing.Point(669, 212);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 74);
            this.btnAlterar.TabIndex = 53;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(566, 209);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 74);
            this.btnAdicionar.TabIndex = 51;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(199, 328);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(293, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(199, 276);
            this.txtTelefone.Mask = "00000000000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(293, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.BackColor = System.Drawing.Color.White;
            this.txtNumeroCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCasa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroCasa.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(200, 385);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(293, 20);
            this.txtNumeroCasa.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(199, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNome.Location = new System.Drawing.Point(200, 171);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(293, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtID.Location = new System.Drawing.Point(201, 117);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(82, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.Color.White;
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRg.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(200, 196);
            this.txtRg.Mask = "000000000";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(293, 20);
            this.txtRg.TabIndex = 4;
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
            this.clnIdAgendamento,
            this.clnNome,
            this.clnRg,
            this.clnEmail,
            this.clnCpf,
            this.clnTelefone,
            this.clnCep,
            this.clnEndereco,
            this.clnEstado,
            this.clnNumeroCasa});
            this.dgvLista.GridColor = System.Drawing.Color.Gray;
            this.dgvLista.Location = new System.Drawing.Point(23, 465);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.Size = new System.Drawing.Size(721, 115);
            this.dgvLista.TabIndex = 59;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 30;
            // 
            // clnIdAgendamento
            // 
            this.clnIdAgendamento.Frozen = true;
            this.clnIdAgendamento.HeaderText = "ID Agendamento";
            this.clnIdAgendamento.Name = "clnIdAgendamento";
            this.clnIdAgendamento.ReadOnly = true;
            this.clnIdAgendamento.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 60;
            // 
            // clnRg
            // 
            this.clnRg.Frozen = true;
            this.clnRg.HeaderText = "RG";
            this.clnRg.Name = "clnRg";
            this.clnRg.ReadOnly = true;
            this.clnRg.Width = 60;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 100;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 60;
            // 
            // clnTelefone
            // 
            this.clnTelefone.Frozen = true;
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            this.clnTelefone.ReadOnly = true;
            this.clnTelefone.Width = 60;
            // 
            // clnCep
            // 
            this.clnCep.Frozen = true;
            this.clnCep.HeaderText = "CEP";
            this.clnCep.Name = "clnCep";
            this.clnCep.ReadOnly = true;
            this.clnCep.Width = 60;
            // 
            // clnEndereco
            // 
            this.clnEndereco.Frozen = true;
            this.clnEndereco.HeaderText = "Endereço";
            this.clnEndereco.Name = "clnEndereco";
            this.clnEndereco.ReadOnly = true;
            // 
            // clnEstado
            // 
            this.clnEstado.Frozen = true;
            this.clnEstado.HeaderText = "Estado";
            this.clnEstado.Name = "clnEstado";
            this.clnEstado.ReadOnly = true;
            this.clnEstado.Width = 80;
            // 
            // clnNumeroCasa
            // 
            this.clnNumeroCasa.Frozen = true;
            this.clnNumeroCasa.HeaderText = "Numero Casa";
            this.clnNumeroCasa.Name = "clnNumeroCasa";
            this.clnNumeroCasa.ReadOnly = true;
            this.clnNumeroCasa.Width = 60;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEstado.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.txtEstado.Location = new System.Drawing.Point(199, 353);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(293, 27);
            this.txtEstado.TabIndex = 10;
            // 
            // exibir
            // 
            this.exibir.BackColor = System.Drawing.Color.Transparent;
            this.exibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibir.ForeColor = System.Drawing.Color.Gray;
            this.exibir.Location = new System.Drawing.Point(666, 403);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(78, 39);
            this.exibir.TabIndex = 79;
            this.exibir.Text = "exibir";
            this.exibir.UseVisualStyleBackColor = false;
            this.exibir.Click += new System.EventHandler(this.exibir_Click);
            // 
            // txtIdAgendamento
            // 
            this.txtIdAgendamento.BackColor = System.Drawing.Color.White;
            this.txtIdAgendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdAgendamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdAgendamento.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAgendamento.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdAgendamento.Location = new System.Drawing.Point(200, 142);
            this.txtIdAgendamento.Name = "txtIdAgendamento";
            this.txtIdAgendamento.Size = new System.Drawing.Size(82, 20);
            this.txtIdAgendamento.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(199, 248);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(293, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.White;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCep.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(199, 300);
            this.txtCep.Mask = "00000000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(293, 20);
            this.txtCep.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.Location = new System.Drawing.Point(23, 430);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 16);
            this.numericUpDown2.TabIndex = 86;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 31);
            this.button1.TabIndex = 87;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHabilitaBusca
            // 
            this.btnHabilitaBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitaBusca.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitaBusca.Location = new System.Drawing.Point(300, 117);
            this.btnHabilitaBusca.Name = "btnHabilitaBusca";
            this.btnHabilitaBusca.Size = new System.Drawing.Size(120, 33);
            this.btnHabilitaBusca.TabIndex = 88;
            this.btnHabilitaBusca.Text = "Habilitar Busca";
            this.btnHabilitaBusca.UseVisualStyleBackColor = true;
            this.btnHabilitaBusca.Click += new System.EventHandler(this.btnHabilitaBusca_Click);
            // 
            // Tela_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.btnHabilitaBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(idAgendamento);
            this.Controls.Add(this.txtIdAgendamento);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(rg_clienLabel);
            this.Controls.Add(cpf_clienLabel);
            this.Controls.Add(cnpj_clienLabel);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(email_clienLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(nom_clienLabel);
            this.Controls.Add(this.txtNome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_cliente";
            this.Text = "tela_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Button exibir;
        private System.Windows.Forms.TextBox txtIdAgendamento;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroCasa;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHabilitaBusca;
    }
}