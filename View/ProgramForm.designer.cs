namespace Sispani.View
{
    partial class ProgramForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this.TopWrapper = new System.Windows.Forms.Panel();
            this.panelEmpresa = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblTradeName = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.buttonAjuda = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.ucMain = new Sispani.View.UC.MainUC();
            this.ucHelp = new Sispani.View.UC.HelpUC();
            this.ucCustomer = new Sispani.View.UC.CustomerUC();
            this.ucProduct = new Sispani.View.UC.ProductUC();
            this.ucReport = new Sispani.View.UC.ReportUC();
            this.ucBill = new Sispani.View.UC.BillUC();
            this.SideBarMenu = new System.Windows.Forms.Panel();
            this.buttonContaCliente = new System.Windows.Forms.Button();
            this.pictureBoxLogoNome = new System.Windows.Forms.PictureBox();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.TopWrapper.SuspendLayout();
            this.panelEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.SideBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoNome)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopWrapper
            // 
            this.TopWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TopWrapper.Controls.Add(this.panelEmpresa);
            this.TopWrapper.Controls.Add(this.buttonAjuda);
            this.TopWrapper.Location = new System.Drawing.Point(0, 0);
            this.TopWrapper.Name = "TopWrapper";
            this.TopWrapper.Size = new System.Drawing.Size(1267, 60);
            this.TopWrapper.TabIndex = 0;
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.Controls.Add(this.lblCompanyName);
            this.panelEmpresa.Controls.Add(this.lblTradeName);
            this.panelEmpresa.Controls.Add(this.lblCNPJ);
            this.panelEmpresa.Location = new System.Drawing.Point(0, 0);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(1156, 60);
            this.panelEmpresa.TabIndex = 15;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(6, 26);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(0, 15);
            this.lblCompanyName.TabIndex = 13;
            // 
            // lblTradeName
            // 
            this.lblTradeName.AutoSize = true;
            this.lblTradeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTradeName.ForeColor = System.Drawing.Color.White;
            this.lblTradeName.Location = new System.Drawing.Point(3, 3);
            this.lblTradeName.Name = "lblTradeName";
            this.lblTradeName.Size = new System.Drawing.Size(0, 25);
            this.lblTradeName.TabIndex = 11;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.White;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 41);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(0, 15);
            this.lblCNPJ.TabIndex = 12;
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjuda.FlatAppearance.BorderSize = 0;
            this.buttonAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjuda.ForeColor = System.Drawing.Color.White;
            this.buttonAjuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjuda.Image")));
            this.buttonAjuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAjuda.Location = new System.Drawing.Point(1159, 0);
            this.buttonAjuda.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(105, 60);
            this.buttonAjuda.TabIndex = 9;
            this.buttonAjuda.TabStop = false;
            this.buttonAjuda.Text = "Ajuda";
            this.buttonAjuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAjuda.UseVisualStyleBackColor = true;
            this.buttonAjuda.Click += new System.EventHandler(this.ButtonAjuda_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.ErrorImage")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(25, 543);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(53, 29);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogo_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(5, 606);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(43, 13);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "v0.0.0";
            // 
            // Wrapper
            // 
            this.Wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wrapper.BackColor = System.Drawing.Color.White;
            this.Wrapper.Controls.Add(this.ucMain);
            this.Wrapper.Controls.Add(this.ucHelp);
            this.Wrapper.Controls.Add(this.ucCustomer);
            this.Wrapper.Controls.Add(this.ucProduct);
            this.Wrapper.Controls.Add(this.ucReport);
            this.Wrapper.Controls.Add(this.ucBill);
            this.Wrapper.Location = new System.Drawing.Point(105, 60);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1159, 596);
            this.Wrapper.TabIndex = 1;
            // 
            // ucMain
            // 
            this.ucMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMain.BackColor = System.Drawing.Color.White;
            this.ucMain.Location = new System.Drawing.Point(0, 0);
            this.ucMain.Name = "ucMain";
            this.ucMain.Size = new System.Drawing.Size(1159, 596);
            this.ucMain.TabIndex = 7;
            // 
            // ucHelp
            // 
            this.ucHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucHelp.BackColor = System.Drawing.Color.White;
            this.ucHelp.Location = new System.Drawing.Point(0, 0);
            this.ucHelp.Name = "ucHelp";
            this.ucHelp.Size = new System.Drawing.Size(1159, 596);
            this.ucHelp.TabIndex = 3;
            // 
            // ucCustomer
            // 
            this.ucCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCustomer.BackColor = System.Drawing.Color.White;
            this.ucCustomer.Location = new System.Drawing.Point(0, 0);
            this.ucCustomer.Name = "ucCustomer";
            this.ucCustomer.Size = new System.Drawing.Size(1159, 596);
            this.ucCustomer.TabIndex = 4;
            // 
            // ucProduct
            // 
            this.ucProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProduct.BackColor = System.Drawing.Color.White;
            this.ucProduct.Location = new System.Drawing.Point(0, 0);
            this.ucProduct.Name = "ucProduct";
            this.ucProduct.Size = new System.Drawing.Size(1159, 596);
            this.ucProduct.TabIndex = 5;
            // 
            // ucReport
            // 
            this.ucReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucReport.BackColor = System.Drawing.Color.White;
            this.ucReport.Location = new System.Drawing.Point(0, 0);
            this.ucReport.Name = "ucReport";
            this.ucReport.Size = new System.Drawing.Size(1159, 596);
            this.ucReport.TabIndex = 6;
            // 
            // ucBill
            // 
            this.ucBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBill.Location = new System.Drawing.Point(0, 0);
            this.ucBill.Name = "ucBill";
            this.ucBill.Size = new System.Drawing.Size(1159, 596);
            this.ucBill.TabIndex = 8;
            // 
            // SideBarMenu
            // 
            this.SideBarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.SideBarMenu.Controls.Add(this.buttonContaCliente);
            this.SideBarMenu.Controls.Add(this.pictureBoxLogo);
            this.SideBarMenu.Controls.Add(this.labelVersion);
            this.SideBarMenu.Controls.Add(this.pictureBoxLogoNome);
            this.SideBarMenu.Controls.Add(this.buttonRelatorio);
            this.SideBarMenu.Controls.Add(this.buttonClientes);
            this.SideBarMenu.Controls.Add(this.buttonProdutos);
            this.SideBarMenu.Controls.Add(this.buttonVenda);
            this.SideBarMenu.Location = new System.Drawing.Point(0, 60);
            this.SideBarMenu.Name = "SideBarMenu";
            this.SideBarMenu.Size = new System.Drawing.Size(105, 621);
            this.SideBarMenu.TabIndex = 2;
            // 
            // buttonContaCliente
            // 
            this.buttonContaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonContaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContaCliente.FlatAppearance.BorderSize = 0;
            this.buttonContaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContaCliente.ForeColor = System.Drawing.Color.White;
            this.buttonContaCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonContaCliente.Image")));
            this.buttonContaCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonContaCliente.Location = new System.Drawing.Point(0, 210);
            this.buttonContaCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonContaCliente.Name = "buttonContaCliente";
            this.buttonContaCliente.Size = new System.Drawing.Size(105, 70);
            this.buttonContaCliente.TabIndex = 12;
            this.buttonContaCliente.TabStop = false;
            this.buttonContaCliente.Text = "Conta do Cliente";
            this.buttonContaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonContaCliente.UseVisualStyleBackColor = true;
            this.buttonContaCliente.Click += new System.EventHandler(this.buttonContaCliente_Click);
            // 
            // pictureBoxLogoNome
            // 
            this.pictureBoxLogoNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxLogoNome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoNome.BackgroundImage")));
            this.pictureBoxLogoNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogoNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogoNome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoNome.ErrorImage")));
            this.pictureBoxLogoNome.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoNome.InitialImage")));
            this.pictureBoxLogoNome.Location = new System.Drawing.Point(7, 569);
            this.pictureBoxLogoNome.Name = "pictureBoxLogoNome";
            this.pictureBoxLogoNome.Size = new System.Drawing.Size(91, 44);
            this.pictureBoxLogoNome.TabIndex = 11;
            this.pictureBoxLogoNome.TabStop = false;
            this.pictureBoxLogoNome.Click += new System.EventHandler(this.PictureBoxLogoNome_Click);
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRelatorio.FlatAppearance.BorderSize = 0;
            this.buttonRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRelatorio.ForeColor = System.Drawing.Color.White;
            this.buttonRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("buttonRelatorio.Image")));
            this.buttonRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRelatorio.Location = new System.Drawing.Point(0, 280);
            this.buttonRelatorio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(105, 70);
            this.buttonRelatorio.TabIndex = 6;
            this.buttonRelatorio.TabStop = false;
            this.buttonRelatorio.Text = "Relatório";
            this.buttonRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRelatorio.UseVisualStyleBackColor = true;
            this.buttonRelatorio.Click += new System.EventHandler(this.ButtonRelatorio_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.ForeColor = System.Drawing.Color.White;
            this.buttonClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonClientes.Image")));
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClientes.Location = new System.Drawing.Point(0, 140);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(105, 70);
            this.buttonClientes.TabIndex = 5;
            this.buttonClientes.TabStop = false;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.ButtonClientes_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProdutos.FlatAppearance.BorderSize = 0;
            this.buttonProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutos.ForeColor = System.Drawing.Color.White;
            this.buttonProdutos.Image = ((System.Drawing.Image)(resources.GetObject("buttonProdutos.Image")));
            this.buttonProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProdutos.Location = new System.Drawing.Point(0, 70);
            this.buttonProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(105, 70);
            this.buttonProdutos.TabIndex = 3;
            this.buttonProdutos.TabStop = false;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProdutos.UseVisualStyleBackColor = true;
            this.buttonProdutos.Click += new System.EventHandler(this.ButtonProdutos_Click);
            // 
            // buttonVenda
            // 
            this.buttonVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVenda.FlatAppearance.BorderSize = 0;
            this.buttonVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVenda.ForeColor = System.Drawing.Color.White;
            this.buttonVenda.Image = ((System.Drawing.Image)(resources.GetObject("buttonVenda.Image")));
            this.buttonVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVenda.Location = new System.Drawing.Point(0, 0);
            this.buttonVenda.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(105, 70);
            this.buttonVenda.TabIndex = 1;
            this.buttonVenda.TabStop = false;
            this.buttonVenda.Text = "Venda";
            this.buttonVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVenda.UseVisualStyleBackColor = true;
            this.buttonVenda.Click += new System.EventHandler(this.ButtonVenda_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Location = new System.Drawing.Point(105, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 25);
            this.panel1.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(944, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(203, 18);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            this.progressBar.Visible = false;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideBarMenu);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.TopWrapper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sispani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProgram_Load);
            this.TopWrapper.ResumeLayout(false);
            this.panelEmpresa.ResumeLayout(false);
            this.panelEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.SideBarMenu.ResumeLayout(false);
            this.SideBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoNome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel SideBarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.Button buttonAjuda;
        private System.Windows.Forms.Button buttonRelatorio;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonProdutos;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTradeName;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Panel panelEmpresa;
        private System.Windows.Forms.Label lblCompanyName;
        private UC.HelpUC ucHelp;
        private UC.CustomerUC ucCustomer;
        private UC.ProductUC ucProduct;
        private UC.ReportUC ucReport;
        private UC.MainUC ucMain;
        private System.Windows.Forms.PictureBox pictureBoxLogoNome;
        private System.Windows.Forms.Button buttonContaCliente;
        private UC.BillUC ucBill;
    }
}

