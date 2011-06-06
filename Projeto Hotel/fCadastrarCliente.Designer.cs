namespace Projeto_Hotel
{
    partial class fCadastrarCliente
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.msbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbRg = new System.Windows.Forms.Label();
            this.msbRg = new System.Windows.Forms.MaskedTextBox();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.msbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbProfissao = new System.Windows.Forms.Label();
            this.tbProfissao = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbEnereco = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.pnDadosPessoais = new System.Windows.Forms.Panel();
            this.pnEndereco = new System.Windows.Forms.Panel();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.msbTelefoneObrigatorio = new System.Windows.Forms.MaskedTextBox();
            this.msbTelefoneOpcional = new System.Windows.Forms.MaskedTextBox();
            this.lbTeleoneOpcional = new System.Windows.Forms.Label();
            this.tpContato = new System.Windows.Forms.TabPage();
            this.pnContato = new System.Windows.Forms.Panel();
            this.tcContato = new System.Windows.Forms.TabControl();
            this.tcEndereco = new System.Windows.Forms.TabControl();
            this.tpEndereco = new System.Windows.Forms.TabPage();
            this.tcDadosPessoais = new System.Windows.Forms.TabControl();
            this.tpDadosPessoais = new System.Windows.Forms.TabPage();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.pnDadosPessoais.SuspendLayout();
            this.pnEndereco.SuspendLayout();
            this.tpContato.SuspendLayout();
            this.pnContato.SuspendLayout();
            this.tcContato.SuspendLayout();
            this.tcEndereco.SuspendLayout();
            this.tpEndereco.SuspendLayout();
            this.tcDadosPessoais.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(3, 10);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(3, 26);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(316, 20);
            this.tbNome.TabIndex = 1;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(322, 10);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(30, 13);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF:";
            // 
            // msbCpf
            // 
            this.msbCpf.Location = new System.Drawing.Point(325, 26);
            this.msbCpf.Mask = "000,000,000-00";
            this.msbCpf.Name = "msbCpf";
            this.msbCpf.Size = new System.Drawing.Size(93, 20);
            this.msbCpf.TabIndex = 3;
            this.msbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(421, 10);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(26, 13);
            this.lbRg.TabIndex = 4;
            this.lbRg.Text = "RG:";
            // 
            // msbRg
            // 
            this.msbRg.Location = new System.Drawing.Point(424, 26);
            this.msbRg.Mask = "99,000,000-a";
            this.msbRg.Name = "msbRg";
            this.msbRg.Size = new System.Drawing.Size(93, 20);
            this.msbRg.TabIndex = 5;
            this.msbRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(520, 10);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbDataNascimento.TabIndex = 6;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // msbDataNascimento
            // 
            this.msbDataNascimento.Location = new System.Drawing.Point(523, 26);
            this.msbDataNascimento.Mask = "00/00/0000";
            this.msbDataNascimento.Name = "msbDataNascimento";
            this.msbDataNascimento.Size = new System.Drawing.Size(104, 20);
            this.msbDataNascimento.TabIndex = 7;
            this.msbDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msbDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lbProfissao
            // 
            this.lbProfissao.AutoSize = true;
            this.lbProfissao.Location = new System.Drawing.Point(179, 49);
            this.lbProfissao.Name = "lbProfissao";
            this.lbProfissao.Size = new System.Drawing.Size(53, 13);
            this.lbProfissao.TabIndex = 9;
            this.lbProfissao.Text = "Profissão:";
            // 
            // tbProfissao
            // 
            this.tbProfissao.Location = new System.Drawing.Point(182, 65);
            this.tbProfissao.Name = "tbProfissao";
            this.tbProfissao.Size = new System.Drawing.Size(445, 20);
            this.tbProfissao.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(221, 9);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(221, 25);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(316, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(3, 49);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lbEstadoCivil.TabIndex = 13;
            this.lbEstadoCivil.Text = "Estado Civil:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Divorsiado(a)",
            "Solteiro(a)",
            "União Estável",
            "Viuvo(a)",
            ""});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(3, 65);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(167, 21);
            this.cmbEstadoCivil.TabIndex = 14;
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.AutoSize = true;
            this.lbLogradouro.Location = new System.Drawing.Point(3, 8);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lbLogradouro.TabIndex = 15;
            this.lbLogradouro.Text = "Logradouro:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Avenida",
            "Rodovia",
            "Rua",
            "Travessa",
            "Viela"});
            this.comboBox1.Location = new System.Drawing.Point(3, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // lbEnereco
            // 
            this.lbEnereco.AutoSize = true;
            this.lbEnereco.Location = new System.Drawing.Point(102, 9);
            this.lbEnereco.Name = "lbEnereco";
            this.lbEnereco.Size = new System.Drawing.Size(56, 13);
            this.lbEnereco.TabIndex = 17;
            this.lbEnereco.Text = "Endereço:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(105, 25);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(217, 20);
            this.tbEndereco.TabIndex = 18;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(395, 9);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(74, 13);
            this.lbComplemento.TabIndex = 19;
            this.lbComplemento.Text = "Complemento:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(398, 25);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(125, 20);
            this.tbComplemento.TabIndex = 20;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(325, 9);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(47, 13);
            this.lbNumero.TabIndex = 21;
            this.lbNumero.Text = "Número:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(328, 25);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(64, 20);
            this.tbNumero.TabIndex = 22;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(526, 8);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(37, 13);
            this.lbBairro.TabIndex = 23;
            this.lbBairro.Text = "Bairro:";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(529, 25);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(271, 20);
            this.tbBairro.TabIndex = 24;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(3, 49);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(31, 13);
            this.lbCep.TabIndex = 25;
            this.lbCep.Text = "CEP:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 65);
            this.maskedTextBox1.Mask = "00,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBox1.TabIndex = 26;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(102, 50);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(43, 13);
            this.lbEstado.TabIndex = 27;
            this.lbEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(105, 66);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(217, 21);
            this.cmbEstado.TabIndex = 28;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(325, 50);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(43, 13);
            this.lbCidade.TabIndex = 29;
            this.lbCidade.Text = "Cidade:";
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(328, 66);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(195, 21);
            this.cmbCidade.TabIndex = 30;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(85, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Location = new System.Drawing.Point(633, 26);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(167, 42);
            this.gbSexo.TabIndex = 8;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // pnDadosPessoais
            // 
            this.pnDadosPessoais.Controls.Add(this.gbSexo);
            this.pnDadosPessoais.Controls.Add(this.msbDataNascimento);
            this.pnDadosPessoais.Controls.Add(this.lbDataNascimento);
            this.pnDadosPessoais.Controls.Add(this.msbRg);
            this.pnDadosPessoais.Controls.Add(this.lbRg);
            this.pnDadosPessoais.Controls.Add(this.msbCpf);
            this.pnDadosPessoais.Controls.Add(this.lbCpf);
            this.pnDadosPessoais.Controls.Add(this.tbNome);
            this.pnDadosPessoais.Controls.Add(this.lbNome);
            this.pnDadosPessoais.Controls.Add(this.lbEstadoCivil);
            this.pnDadosPessoais.Controls.Add(this.lbProfissao);
            this.pnDadosPessoais.Controls.Add(this.tbProfissao);
            this.pnDadosPessoais.Controls.Add(this.cmbEstadoCivil);
            this.pnDadosPessoais.Location = new System.Drawing.Point(6, 6);
            this.pnDadosPessoais.Name = "pnDadosPessoais";
            this.pnDadosPessoais.Size = new System.Drawing.Size(804, 94);
            this.pnDadosPessoais.TabIndex = 31;
            // 
            // pnEndereco
            // 
            this.pnEndereco.Controls.Add(this.tbPais);
            this.pnEndereco.Controls.Add(this.lbPais);
            this.pnEndereco.Controls.Add(this.tbNumero);
            this.pnEndereco.Controls.Add(this.lbNumero);
            this.pnEndereco.Controls.Add(this.cmbCidade);
            this.pnEndereco.Controls.Add(this.tbComplemento);
            this.pnEndereco.Controls.Add(this.lbCidade);
            this.pnEndereco.Controls.Add(this.lbComplemento);
            this.pnEndereco.Controls.Add(this.cmbEstado);
            this.pnEndereco.Controls.Add(this.tbEndereco);
            this.pnEndereco.Controls.Add(this.lbEstado);
            this.pnEndereco.Controls.Add(this.lbEnereco);
            this.pnEndereco.Controls.Add(this.maskedTextBox1);
            this.pnEndereco.Controls.Add(this.comboBox1);
            this.pnEndereco.Controls.Add(this.lbCep);
            this.pnEndereco.Controls.Add(this.lbLogradouro);
            this.pnEndereco.Controls.Add(this.tbBairro);
            this.pnEndereco.Controls.Add(this.lbBairro);
            this.pnEndereco.Location = new System.Drawing.Point(6, 6);
            this.pnEndereco.Name = "pnEndereco";
            this.pnEndereco.Size = new System.Drawing.Size(803, 98);
            this.pnEndereco.TabIndex = 32;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(532, 67);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(268, 20);
            this.tbPais.TabIndex = 32;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(529, 50);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(32, 13);
            this.lbPais.TabIndex = 31;
            this.lbPais.Text = "País:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(3, 9);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(106, 13);
            this.lbTelefone.TabIndex = 13;
            this.lbTelefone.Text = "Telefone Obrigatório:";
            // 
            // msbTelefoneObrigatorio
            // 
            this.msbTelefoneObrigatorio.Location = new System.Drawing.Point(3, 25);
            this.msbTelefoneObrigatorio.Mask = "(00) 0000-0000";
            this.msbTelefoneObrigatorio.Name = "msbTelefoneObrigatorio";
            this.msbTelefoneObrigatorio.Size = new System.Drawing.Size(106, 20);
            this.msbTelefoneObrigatorio.TabIndex = 14;
            // 
            // msbTelefoneOpcional
            // 
            this.msbTelefoneOpcional.Location = new System.Drawing.Point(115, 25);
            this.msbTelefoneOpcional.Mask = "(00) 0000-0000";
            this.msbTelefoneOpcional.Name = "msbTelefoneOpcional";
            this.msbTelefoneOpcional.Size = new System.Drawing.Size(100, 20);
            this.msbTelefoneOpcional.TabIndex = 16;
            // 
            // lbTeleoneOpcional
            // 
            this.lbTeleoneOpcional.AutoSize = true;
            this.lbTeleoneOpcional.Location = new System.Drawing.Point(115, 9);
            this.lbTeleoneOpcional.Name = "lbTeleoneOpcional";
            this.lbTeleoneOpcional.Size = new System.Drawing.Size(97, 13);
            this.lbTeleoneOpcional.TabIndex = 15;
            this.lbTeleoneOpcional.Text = "Telefone Opcional:";
            // 
            // tpContato
            // 
            this.tpContato.Controls.Add(this.pnContato);
            this.tpContato.Location = new System.Drawing.Point(4, 22);
            this.tpContato.Name = "tpContato";
            this.tpContato.Padding = new System.Windows.Forms.Padding(3);
            this.tpContato.Size = new System.Drawing.Size(813, 67);
            this.tpContato.TabIndex = 0;
            this.tpContato.Text = "Contato";
            this.tpContato.UseVisualStyleBackColor = true;
            // 
            // pnContato
            // 
            this.pnContato.Controls.Add(this.msbTelefoneOpcional);
            this.pnContato.Controls.Add(this.lbTelefone);
            this.pnContato.Controls.Add(this.lbEmail);
            this.pnContato.Controls.Add(this.lbTeleoneOpcional);
            this.pnContato.Controls.Add(this.msbTelefoneObrigatorio);
            this.pnContato.Controls.Add(this.tbEmail);
            this.pnContato.Location = new System.Drawing.Point(6, 6);
            this.pnContato.Name = "pnContato";
            this.pnContato.Size = new System.Drawing.Size(804, 56);
            this.pnContato.TabIndex = 33;
            // 
            // tcContato
            // 
            this.tcContato.Controls.Add(this.tpContato);
            this.tcContato.Location = new System.Drawing.Point(12, 292);
            this.tcContato.Name = "tcContato";
            this.tcContato.SelectedIndex = 0;
            this.tcContato.Size = new System.Drawing.Size(821, 93);
            this.tcContato.TabIndex = 34;
            // 
            // tcEndereco
            // 
            this.tcEndereco.Controls.Add(this.tpEndereco);
            this.tcEndereco.Location = new System.Drawing.Point(12, 150);
            this.tcEndereco.Name = "tcEndereco";
            this.tcEndereco.SelectedIndex = 0;
            this.tcEndereco.Size = new System.Drawing.Size(821, 136);
            this.tcEndereco.TabIndex = 35;
            // 
            // tpEndereco
            // 
            this.tpEndereco.Controls.Add(this.pnEndereco);
            this.tpEndereco.Location = new System.Drawing.Point(4, 22);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tpEndereco.Size = new System.Drawing.Size(813, 110);
            this.tpEndereco.TabIndex = 0;
            this.tpEndereco.Text = "Endereço";
            this.tpEndereco.UseVisualStyleBackColor = true;
            // 
            // tcDadosPessoais
            // 
            this.tcDadosPessoais.Controls.Add(this.tpDadosPessoais);
            this.tcDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.tcDadosPessoais.Name = "tcDadosPessoais";
            this.tcDadosPessoais.SelectedIndex = 0;
            this.tcDadosPessoais.Size = new System.Drawing.Size(821, 132);
            this.tcDadosPessoais.TabIndex = 36;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.Controls.Add(this.pnDadosPessoais);
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosPessoais.Size = new System.Drawing.Size(813, 106);
            this.tpDadosPessoais.TabIndex = 0;
            this.tpDadosPessoais.Text = "Dados Pessoais";
            this.tpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(714, 391);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(119, 29);
            this.btConfirmar.TabIndex = 37;
            this.btConfirmar.Text = "&Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(589, 391);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(119, 29);
            this.btCancelar.TabIndex = 38;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // fCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 432);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.tcDadosPessoais);
            this.Controls.Add(this.tcEndereco);
            this.Controls.Add(this.tcContato);
            this.Name = "fCadastrarCliente";
            this.Text = "Cadastro de Clientes";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.pnDadosPessoais.ResumeLayout(false);
            this.pnDadosPessoais.PerformLayout();
            this.pnEndereco.ResumeLayout(false);
            this.pnEndereco.PerformLayout();
            this.tpContato.ResumeLayout(false);
            this.pnContato.ResumeLayout(false);
            this.pnContato.PerformLayout();
            this.tcContato.ResumeLayout(false);
            this.tcEndereco.ResumeLayout(false);
            this.tpEndereco.ResumeLayout(false);
            this.tcDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.MaskedTextBox msbCpf;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.MaskedTextBox msbRg;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.MaskedTextBox msbDataNascimento;
        private System.Windows.Forms.Label lbProfissao;
        private System.Windows.Forms.TextBox tbProfissao;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label lbLogradouro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbEnereco;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.Panel pnDadosPessoais;
        private System.Windows.Forms.Panel pnEndereco;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.MaskedTextBox msbTelefoneObrigatorio;
        private System.Windows.Forms.MaskedTextBox msbTelefoneOpcional;
        private System.Windows.Forms.Label lbTeleoneOpcional;
        private System.Windows.Forms.TabPage tpContato;
        private System.Windows.Forms.TabControl tcContato;
        private System.Windows.Forms.TabControl tcEndereco;
        private System.Windows.Forms.TabPage tpEndereco;
        private System.Windows.Forms.Panel pnContato;
        private System.Windows.Forms.TabControl tcDadosPessoais;
        private System.Windows.Forms.TabPage tpDadosPessoais;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
    }
}