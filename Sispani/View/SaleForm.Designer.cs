namespace Sispani.View
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCifraoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelQuantidadeItens = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labelCodigoBarras = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.lblCustomerCPF = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProduct
            // 
            this.picProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProduct.BackColor = System.Drawing.Color.Transparent;
            this.picProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProduct.BackgroundImage")));
            this.picProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProduct.Location = new System.Drawing.Point(42, 12);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(300, 300);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 9;
            this.picProduct.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblCifraoTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.lblItemAmount);
            this.groupBox1.Controls.Add(this.labelDesconto);
            this.groupBox1.Controls.Add(this.labelSubtotal);
            this.groupBox1.Controls.Add(this.labelQuantidadeItens);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 642);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblCifraoTotal
            // 
            this.lblCifraoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCifraoTotal.AutoSize = true;
            this.lblCifraoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifraoTotal.Location = new System.Drawing.Point(655, 576);
            this.lblCifraoTotal.Name = "lblCifraoTotal";
            this.lblCifraoTotal.Size = new System.Drawing.Size(71, 46);
            this.lblCifraoTotal.TabIndex = 24;
            this.lblCifraoTotal.Text = "R$";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "R$";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "itens";
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(837, 499);
            this.dgvProducts.TabIndex = 20;
            this.dgvProducts.TabStop = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(205, 597);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(54, 25);
            this.lblDiscount.TabIndex = 19;
            this.lblDiscount.Text = "0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(732, 576);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(97, 46);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0,00";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(761, 552);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(60, 25);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(205, 572);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 25);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "0,00";
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAmount.Location = new System.Drawing.Point(160, 547);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(24, 25);
            this.lblItemAmount.TabIndex = 12;
            this.lblItemAmount.Text = "0";
            // 
            // labelDesconto
            // 
            this.labelDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesconto.Location = new System.Drawing.Point(45, 597);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(109, 25);
            this.labelDesconto.TabIndex = 11;
            this.labelDesconto.Text = "Desconto:";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(57, 572);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(97, 25);
            this.labelSubtotal.TabIndex = 10;
            this.labelSubtotal.Text = "Subtotal:";
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuantidadeItens
            // 
            this.labelQuantidadeItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelQuantidadeItens.AutoSize = true;
            this.labelQuantidadeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeItens.Location = new System.Drawing.Point(25, 547);
            this.labelQuantidadeItens.Name = "labelQuantidadeItens";
            this.labelQuantidadeItens.Size = new System.Drawing.Size(129, 25);
            this.labelQuantidadeItens.TabIndex = 9;
            this.labelQuantidadeItens.Text = "Quantidade:";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnAddCustomer);
            this.groupBox3.Controls.Add(this.btnDiscount);
            this.groupBox3.Controls.Add(this.btnFinalize);
            this.groupBox3.Controls.Add(this.btnCancelItem);
            this.groupBox3.Controls.Add(this.btnCancelSale);
            this.groupBox3.Controls.Add(this.txtCode);
            this.groupBox3.Controls.Add(this.labelCodigoBarras);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.labelQuantidade);
            this.groupBox3.Location = new System.Drawing.Point(867, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 246);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar Item";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(258, 137);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(120, 30);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Adicionar Cliente";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(132, 137);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(120, 30);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Desconto Item";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.BtnDiscount_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalize.FlatAppearance.BorderSize = 0;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.ForeColor = System.Drawing.Color.White;
            this.btnFinalize.Location = new System.Drawing.Point(195, 101);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(183, 30);
            this.btnFinalize.TabIndex = 3;
            this.btnFinalize.Text = "Finalizar Venda";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.BtnFinalize_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCancelItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelItem.FlatAppearance.BorderSize = 0;
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.ForeColor = System.Drawing.Color.White;
            this.btnCancelItem.Location = new System.Drawing.Point(6, 137);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(120, 30);
            this.btnCancelItem.TabIndex = 4;
            this.btnCancelItem.Text = "Cancelar Item";
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.BtnCancelItem_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCancelSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSale.FlatAppearance.BorderSize = 0;
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Location = new System.Drawing.Point(6, 101);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(183, 30);
            this.btnCancelSale.TabIndex = 2;
            this.btnCancelSale.Text = "Cancelar Venda";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.BtnCancelSale_Click);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(105, 57);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(274, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCode_KeyDown);
            // 
            // labelCodigoBarras
            // 
            this.labelCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigoBarras.AutoSize = true;
            this.labelCodigoBarras.Location = new System.Drawing.Point(102, 41);
            this.labelCodigoBarras.Name = "labelCodigoBarras";
            this.labelCodigoBarras.Size = new System.Drawing.Size(88, 13);
            this.labelCodigoBarras.TabIndex = 2;
            this.labelCodigoBarras.Text = "Código de Barras\r\n";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(6, 57);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(59, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "1";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.TxtAmount_Leave);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(3, 41);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.labelQuantidade.TabIndex = 0;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.picProduct);
            this.groupBox2.Location = new System.Drawing.Point(867, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 319);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomer.Controls.Add(this.btnRemoveCustomer);
            this.gbCustomer.Controls.Add(this.lblCustomerCPF);
            this.gbCustomer.Controls.Add(this.lblCustomerName);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Location = new System.Drawing.Point(868, 353);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(384, 64);
            this.gbCustomer.TabIndex = 13;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Cliente";
            this.gbCustomer.Visible = false;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnRemoveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCustomer.FlatAppearance.BorderSize = 0;
            this.btnRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCustomer.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(284, 34);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(94, 24);
            this.btnRemoveCustomer.TabIndex = 7;
            this.btnRemoveCustomer.Text = "Remover Cliente";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.BtnRemoveCustomer_Click);
            // 
            // lblCustomerCPF
            // 
            this.lblCustomerCPF.AutoSize = true;
            this.lblCustomerCPF.Location = new System.Drawing.Point(51, 41);
            this.lblCustomerCPF.Name = "lblCustomerCPF";
            this.lblCustomerCPF.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerCPF.TabIndex = 3;
            this.lblCustomerCPF.Text = "placeholder";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(51, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "placeholder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimizeBox = false;
            this.Name = "SaleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labelCodigoBarras;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelQuantidadeItens;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblCustomerCPF;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCifraoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveCustomer;
    }
}