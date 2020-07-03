namespace Sispani.View.UC
{
    partial class ProductUC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDireita = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxEsquerda = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.txtInsertAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboInsertUnity = new System.Windows.Forms.ComboBox();
            this.txtInsertSell = new System.Windows.Forms.TextBox();
            this.txtInsertCost = new System.Windows.Forms.TextBox();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.txtInsertCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCusto = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.labelCodigoBarras = new System.Windows.Forms.Label();
            this.btnCancelInsert = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabPageAlteracao = new System.Windows.Forms.TabPage();
            this.txtAlterAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAlterUnity = new System.Windows.Forms.ComboBox();
            this.txtAlterSell = new System.Windows.Forms.TextBox();
            this.txtAlterCost = new System.Windows.Forms.TextBox();
            this.txtAlterName = new System.Windows.Forms.TextBox();
            this.txtAlterCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelAlter = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.tabPageExclusao = new System.Windows.Forms.TabPage();
            this.txtDeleteAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboDeleteUnity = new System.Windows.Forms.ComboBox();
            this.txtDeleteSell = new System.Windows.Forms.TextBox();
            this.txtDeleteCost = new System.Windows.Forms.TextBox();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.txtDeleteCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDireita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxEsquerda.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.tabPageAlteracao.SuspendLayout();
            this.tabPageExclusao.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDireita
            // 
            this.groupBoxDireita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDireita.Controls.Add(this.dataGridView);
            this.groupBoxDireita.Location = new System.Drawing.Point(439, 27);
            this.groupBoxDireita.Name = "groupBoxDireita";
            this.groupBoxDireita.Size = new System.Drawing.Size(717, 566);
            this.groupBoxDireita.TabIndex = 13;
            this.groupBoxDireita.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(705, 541);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBoxEsquerda
            // 
            this.groupBoxEsquerda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxEsquerda.Controls.Add(this.tabControl);
            this.groupBoxEsquerda.Location = new System.Drawing.Point(3, 27);
            this.groupBoxEsquerda.Name = "groupBoxEsquerda";
            this.groupBoxEsquerda.Size = new System.Drawing.Size(430, 566);
            this.groupBoxEsquerda.TabIndex = 12;
            this.groupBoxEsquerda.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl.Controls.Add(this.tabPageCadastro);
            this.tabControl.Controls.Add(this.tabPageAlteracao);
            this.tabControl.Controls.Add(this.tabPageExclusao);
            this.tabControl.Location = new System.Drawing.Point(6, 19);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(418, 541);
            this.tabControl.TabIndex = 30;
            this.tabControl.TabStop = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtInsertAmount);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.cboInsertUnity);
            this.tabPageCadastro.Controls.Add(this.txtInsertSell);
            this.tabPageCadastro.Controls.Add(this.txtInsertCost);
            this.tabPageCadastro.Controls.Add(this.txtInsertName);
            this.tabPageCadastro.Controls.Add(this.txtInsertCode);
            this.tabPageCadastro.Controls.Add(this.label7);
            this.tabPageCadastro.Controls.Add(this.labelCusto);
            this.tabPageCadastro.Controls.Add(this.labelNome);
            this.tabPageCadastro.Controls.Add(this.labelUnidade);
            this.tabPageCadastro.Controls.Add(this.labelCodigoBarras);
            this.tabPageCadastro.Controls.Add(this.btnCancelInsert);
            this.tabPageCadastro.Controls.Add(this.btnInsert);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(410, 515);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtInsertAmount
            // 
            this.txtInsertAmount.Location = new System.Drawing.Point(319, 41);
            this.txtInsertAmount.Name = "txtInsertAmount";
            this.txtInsertAmount.Size = new System.Drawing.Size(60, 20);
            this.txtInsertAmount.TabIndex = 2;
            this.txtInsertAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsertAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Qtd. *";
            // 
            // cboInsertUnity
            // 
            this.cboInsertUnity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboInsertUnity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboInsertUnity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsertUnity.FormattingEnabled = true;
            this.cboInsertUnity.Items.AddRange(new object[] {
            "UN",
            "KG",
            "LT"});
            this.cboInsertUnity.Location = new System.Drawing.Point(207, 40);
            this.cboInsertUnity.Name = "cboInsertUnity";
            this.cboInsertUnity.Size = new System.Drawing.Size(106, 21);
            this.cboInsertUnity.TabIndex = 1;
            // 
            // txtInsertSell
            // 
            this.txtInsertSell.Location = new System.Drawing.Point(207, 131);
            this.txtInsertSell.Name = "txtInsertSell";
            this.txtInsertSell.Size = new System.Drawing.Size(172, 20);
            this.txtInsertSell.TabIndex = 5;
            this.txtInsertSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsertSell_KeyPress);
            // 
            // txtInsertCost
            // 
            this.txtInsertCost.Location = new System.Drawing.Point(30, 131);
            this.txtInsertCost.Name = "txtInsertCost";
            this.txtInsertCost.Size = new System.Drawing.Size(171, 20);
            this.txtInsertCost.TabIndex = 4;
            this.txtInsertCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsertCost_KeyPress);
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(30, 86);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(349, 20);
            this.txtInsertName.TabIndex = 3;
            // 
            // txtInsertCode
            // 
            this.txtInsertCode.Location = new System.Drawing.Point(30, 41);
            this.txtInsertCode.Name = "txtInsertCode";
            this.txtInsertCode.Size = new System.Drawing.Size(171, 20);
            this.txtInsertCode.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Preço de venda *";
            // 
            // labelCusto
            // 
            this.labelCusto.AutoSize = true;
            this.labelCusto.Location = new System.Drawing.Point(27, 115);
            this.labelCusto.Name = "labelCusto";
            this.labelCusto.Size = new System.Drawing.Size(79, 13);
            this.labelCusto.TabIndex = 89;
            this.labelCusto.Text = "Preço de custo";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(27, 70);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 13);
            this.labelNome.TabIndex = 87;
            this.labelNome.Text = "Nome *";
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Location = new System.Drawing.Point(204, 24);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(54, 13);
            this.labelUnidade.TabIndex = 85;
            this.labelUnidade.Text = "Unidade *";
            // 
            // labelCodigoBarras
            // 
            this.labelCodigoBarras.AutoSize = true;
            this.labelCodigoBarras.Location = new System.Drawing.Point(27, 25);
            this.labelCodigoBarras.Name = "labelCodigoBarras";
            this.labelCodigoBarras.Size = new System.Drawing.Size(94, 13);
            this.labelCodigoBarras.TabIndex = 82;
            this.labelCodigoBarras.Text = "Código de barras *";
            // 
            // btnCancelInsert
            // 
            this.btnCancelInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCancelInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelInsert.FlatAppearance.BorderSize = 0;
            this.btnCancelInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelInsert.ForeColor = System.Drawing.Color.White;
            this.btnCancelInsert.Location = new System.Drawing.Point(223, 468);
            this.btnCancelInsert.Name = "btnCancelInsert";
            this.btnCancelInsert.Size = new System.Drawing.Size(75, 23);
            this.btnCancelInsert.TabIndex = 7;
            this.btnCancelInsert.Text = "Cancelar";
            this.btnCancelInsert.UseVisualStyleBackColor = false;
            this.btnCancelInsert.Click += new System.EventHandler(this.CancelInsert_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(304, 468);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Cadastrar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // tabPageAlteracao
            // 
            this.tabPageAlteracao.Controls.Add(this.txtAlterAmount);
            this.tabPageAlteracao.Controls.Add(this.label4);
            this.tabPageAlteracao.Controls.Add(this.cboAlterUnity);
            this.tabPageAlteracao.Controls.Add(this.txtAlterSell);
            this.tabPageAlteracao.Controls.Add(this.txtAlterCost);
            this.tabPageAlteracao.Controls.Add(this.txtAlterName);
            this.tabPageAlteracao.Controls.Add(this.txtAlterCode);
            this.tabPageAlteracao.Controls.Add(this.label2);
            this.tabPageAlteracao.Controls.Add(this.label5);
            this.tabPageAlteracao.Controls.Add(this.label6);
            this.tabPageAlteracao.Controls.Add(this.label8);
            this.tabPageAlteracao.Controls.Add(this.label9);
            this.tabPageAlteracao.Controls.Add(this.btnCancelAlter);
            this.tabPageAlteracao.Controls.Add(this.btnAlter);
            this.tabPageAlteracao.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlteracao.Name = "tabPageAlteracao";
            this.tabPageAlteracao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlteracao.Size = new System.Drawing.Size(410, 515);
            this.tabPageAlteracao.TabIndex = 1;
            this.tabPageAlteracao.Text = "Alteração";
            this.tabPageAlteracao.UseVisualStyleBackColor = true;
            // 
            // txtAlterAmount
            // 
            this.txtAlterAmount.Enabled = false;
            this.txtAlterAmount.Location = new System.Drawing.Point(319, 40);
            this.txtAlterAmount.Name = "txtAlterAmount";
            this.txtAlterAmount.Size = new System.Drawing.Size(60, 20);
            this.txtAlterAmount.TabIndex = 2;
            this.txtAlterAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlterAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Qtd. *";
            // 
            // cboAlterUnity
            // 
            this.cboAlterUnity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlterUnity.Enabled = false;
            this.cboAlterUnity.FormattingEnabled = true;
            this.cboAlterUnity.Location = new System.Drawing.Point(207, 40);
            this.cboAlterUnity.Name = "cboAlterUnity";
            this.cboAlterUnity.Size = new System.Drawing.Size(106, 21);
            this.cboAlterUnity.TabIndex = 1;
            // 
            // txtAlterSell
            // 
            this.txtAlterSell.Enabled = false;
            this.txtAlterSell.Location = new System.Drawing.Point(207, 131);
            this.txtAlterSell.Name = "txtAlterSell";
            this.txtAlterSell.Size = new System.Drawing.Size(172, 20);
            this.txtAlterSell.TabIndex = 5;
            this.txtAlterSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlterSell_KeyPress);
            // 
            // txtAlterCost
            // 
            this.txtAlterCost.Enabled = false;
            this.txtAlterCost.Location = new System.Drawing.Point(30, 131);
            this.txtAlterCost.Name = "txtAlterCost";
            this.txtAlterCost.Size = new System.Drawing.Size(171, 20);
            this.txtAlterCost.TabIndex = 4;
            this.txtAlterCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlterCost_KeyPress);
            // 
            // txtAlterName
            // 
            this.txtAlterName.Enabled = false;
            this.txtAlterName.Location = new System.Drawing.Point(30, 86);
            this.txtAlterName.Name = "txtAlterName";
            this.txtAlterName.Size = new System.Drawing.Size(349, 20);
            this.txtAlterName.TabIndex = 3;
            // 
            // txtAlterCode
            // 
            this.txtAlterCode.Location = new System.Drawing.Point(30, 41);
            this.txtAlterCode.Name = "txtAlterCode";
            this.txtAlterCode.Size = new System.Drawing.Size(171, 20);
            this.txtAlterCode.TabIndex = 0;
            this.txtAlterCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlterCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Preço de venda *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Preço de custo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Nome *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 107;
            this.label8.Text = "Unidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "Código de barras";
            // 
            // btnCancelAlter
            // 
            this.btnCancelAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAlter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCancelAlter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAlter.Enabled = false;
            this.btnCancelAlter.FlatAppearance.BorderSize = 0;
            this.btnCancelAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAlter.ForeColor = System.Drawing.Color.White;
            this.btnCancelAlter.Location = new System.Drawing.Point(223, 468);
            this.btnCancelAlter.Name = "btnCancelAlter";
            this.btnCancelAlter.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAlter.TabIndex = 7;
            this.btnCancelAlter.Text = "Cancelar";
            this.btnCancelAlter.UseVisualStyleBackColor = false;
            this.btnCancelAlter.Click += new System.EventHandler(this.CancelAlter_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnAlter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlter.Enabled = false;
            this.btnAlter.FlatAppearance.BorderSize = 0;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.ForeColor = System.Drawing.Color.White;
            this.btnAlter.Location = new System.Drawing.Point(304, 468);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 6;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.Alter_Click);
            // 
            // tabPageExclusao
            // 
            this.tabPageExclusao.Controls.Add(this.txtDeleteAmount);
            this.tabPageExclusao.Controls.Add(this.label12);
            this.tabPageExclusao.Controls.Add(this.cboDeleteUnity);
            this.tabPageExclusao.Controls.Add(this.txtDeleteSell);
            this.tabPageExclusao.Controls.Add(this.txtDeleteCost);
            this.tabPageExclusao.Controls.Add(this.txtDeleteName);
            this.tabPageExclusao.Controls.Add(this.txtDeleteCode);
            this.tabPageExclusao.Controls.Add(this.label11);
            this.tabPageExclusao.Controls.Add(this.label14);
            this.tabPageExclusao.Controls.Add(this.label15);
            this.tabPageExclusao.Controls.Add(this.label16);
            this.tabPageExclusao.Controls.Add(this.label17);
            this.tabPageExclusao.Controls.Add(this.btnCancelDelete);
            this.tabPageExclusao.Controls.Add(this.btnDelete);
            this.tabPageExclusao.Location = new System.Drawing.Point(4, 22);
            this.tabPageExclusao.Name = "tabPageExclusao";
            this.tabPageExclusao.Size = new System.Drawing.Size(410, 515);
            this.tabPageExclusao.TabIndex = 2;
            this.tabPageExclusao.Text = "Exclusão";
            this.tabPageExclusao.UseVisualStyleBackColor = true;
            // 
            // txtDeleteAmount
            // 
            this.txtDeleteAmount.Enabled = false;
            this.txtDeleteAmount.Location = new System.Drawing.Point(319, 41);
            this.txtDeleteAmount.Name = "txtDeleteAmount";
            this.txtDeleteAmount.Size = new System.Drawing.Size(60, 20);
            this.txtDeleteAmount.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Qtd.";
            // 
            // cboDeleteUnity
            // 
            this.cboDeleteUnity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeleteUnity.Enabled = false;
            this.cboDeleteUnity.FormattingEnabled = true;
            this.cboDeleteUnity.Location = new System.Drawing.Point(207, 40);
            this.cboDeleteUnity.Name = "cboDeleteUnity";
            this.cboDeleteUnity.Size = new System.Drawing.Size(106, 21);
            this.cboDeleteUnity.TabIndex = 1;
            // 
            // txtDeleteSell
            // 
            this.txtDeleteSell.Enabled = false;
            this.txtDeleteSell.Location = new System.Drawing.Point(207, 131);
            this.txtDeleteSell.Name = "txtDeleteSell";
            this.txtDeleteSell.Size = new System.Drawing.Size(172, 20);
            this.txtDeleteSell.TabIndex = 5;
            // 
            // txtDeleteCost
            // 
            this.txtDeleteCost.Enabled = false;
            this.txtDeleteCost.Location = new System.Drawing.Point(30, 131);
            this.txtDeleteCost.Name = "txtDeleteCost";
            this.txtDeleteCost.Size = new System.Drawing.Size(171, 20);
            this.txtDeleteCost.TabIndex = 4;
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.Enabled = false;
            this.txtDeleteName.Location = new System.Drawing.Point(30, 86);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(349, 20);
            this.txtDeleteName.TabIndex = 3;
            // 
            // txtDeleteCode
            // 
            this.txtDeleteCode.Location = new System.Drawing.Point(30, 41);
            this.txtDeleteCode.Name = "txtDeleteCode";
            this.txtDeleteCode.Size = new System.Drawing.Size(171, 20);
            this.txtDeleteCode.TabIndex = 0;
            this.txtDeleteCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteCode_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "Preço de venda";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 109;
            this.label14.Text = "Preço de custo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 108;
            this.label15.Text = "Nome";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(204, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 107;
            this.label16.Text = "Unidade";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 106;
            this.label17.Text = "Código de barras";
            // 
            // btnCancelDelete
            // 
            this.btnCancelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCancelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelDelete.Enabled = false;
            this.btnCancelDelete.FlatAppearance.BorderSize = 0;
            this.btnCancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDelete.ForeColor = System.Drawing.Color.White;
            this.btnCancelDelete.Location = new System.Drawing.Point(223, 468);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDelete.TabIndex = 7;
            this.btnCancelDelete.Text = "Cancelar";
            this.btnCancelDelete.UseVisualStyleBackColor = false;
            this.btnCancelDelete.Click += new System.EventHandler(this.CancelDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(304, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportCSV});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsmiExportCSV
            // 
            this.tsmiExportCSV.Name = "tsmiExportCSV";
            this.tsmiExportCSV.Size = new System.Drawing.Size(141, 22);
            this.tsmiExportCSV.Text = "Exportar CSV";
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxDireita);
            this.Controls.Add(this.groupBoxEsquerda);
            this.Controls.Add(this.menuStrip);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(1159, 596);
            this.Load += new System.EventHandler(this.ProductUC_Load);
            this.groupBoxDireita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxEsquerda.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.tabPageAlteracao.ResumeLayout(false);
            this.tabPageAlteracao.PerformLayout();
            this.tabPageExclusao.ResumeLayout(false);
            this.tabPageExclusao.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDireita;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxEsquerda;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.ComboBox cboInsertUnity;
        private System.Windows.Forms.TextBox txtInsertSell;
        private System.Windows.Forms.TextBox txtInsertCost;
        private System.Windows.Forms.TextBox txtInsertName;
        private System.Windows.Forms.TextBox txtInsertCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCusto;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelUnidade;
        private System.Windows.Forms.Label labelCodigoBarras;
        private System.Windows.Forms.Button btnCancelInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TabPage tabPageAlteracao;
        private System.Windows.Forms.Button btnCancelAlter;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.TabPage tabPageExclusao;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboAlterUnity;
        private System.Windows.Forms.TextBox txtAlterSell;
        private System.Windows.Forms.TextBox txtAlterCost;
        private System.Windows.Forms.TextBox txtAlterName;
        private System.Windows.Forms.TextBox txtAlterCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDeleteUnity;
        private System.Windows.Forms.TextBox txtDeleteSell;
        private System.Windows.Forms.TextBox txtDeleteCost;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.TextBox txtDeleteCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportCSV;
        private System.Windows.Forms.TextBox txtInsertAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlterAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeleteAmount;
        private System.Windows.Forms.Label label12;
    }
}
