namespace Sispani.View
{
    partial class ReportUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtLastMonthSale = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbcReportSales = new System.Windows.Forms.GroupBox();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.labelAte = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chtLastMonthSale)).BeginInit();
            this.gbcReportSales.SuspendLayout();
            this.groupBoxPesquisa.SuspendLayout();
            this.groupBoxDados.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPeriodo.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtLastMonthSale
            // 
            this.chtLastMonthSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chtLastMonthSale.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtLastMonthSale.Legends.Add(legend1);
            this.chtLastMonthSale.Location = new System.Drawing.Point(6, 19);
            this.chtLastMonthSale.Name = "chtLastMonthSale";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtLastMonthSale.Series.Add(series1);
            this.chtLastMonthSale.Size = new System.Drawing.Size(837, 541);
            this.chtLastMonthSale.TabIndex = 0;
            this.chtLastMonthSale.Text = "chart1";
            // 
            // gbcReportSales
            // 
            this.gbcReportSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbcReportSales.BackColor = System.Drawing.Color.White;
            this.gbcReportSales.Controls.Add(this.chtLastMonthSale);
            this.gbcReportSales.Location = new System.Drawing.Point(307, 27);
            this.gbcReportSales.Name = "gbcReportSales";
            this.gbcReportSales.Size = new System.Drawing.Size(849, 566);
            this.gbcReportSales.TabIndex = 1;
            this.gbcReportSales.TabStop = false;
            this.gbcReportSales.Text = "Vendas totais dos últimos 30 dias";
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPesquisa.BackColor = System.Drawing.Color.White;
            this.groupBoxPesquisa.Controls.Add(this.groupBoxDados);
            this.groupBoxPesquisa.Controls.Add(this.groupBoxPeriodo);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(3, 27);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(298, 566);
            this.groupBoxPesquisa.TabIndex = 2;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Total de vendas no período";
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDados.Controls.Add(this.groupBox3);
            this.groupBoxDados.Controls.Add(this.groupBox1);
            this.groupBoxDados.Location = new System.Drawing.Point(6, 160);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(286, 400);
            this.groupBoxDados.TabIndex = 8;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 57);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(198, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTerm);
            this.groupBox1.Controls.Add(this.lblCard);
            this.groupBox1.Controls.Add(this.lblMoney);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "R$";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(198, 66);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(28, 13);
            this.lblTerm.TabIndex = 12;
            this.lblTerm.Text = "0,00";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(198, 48);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(28, 13);
            this.lblCard.TabIndex = 11;
            this.lblCard.Text = "0,00";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(198, 30);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(28, 13);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dinheiro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prazo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cartão";
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPeriodo.Controls.Add(this.labelAte);
            this.groupBoxPeriodo.Controls.Add(this.dtpStart);
            this.groupBoxPeriodo.Controls.Add(this.dtpEnd);
            this.groupBoxPeriodo.Controls.Add(this.btnSearch);
            this.groupBoxPeriodo.Location = new System.Drawing.Point(6, 19);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(286, 135);
            this.groupBoxPeriodo.TabIndex = 7;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Período";
            // 
            // labelAte
            // 
            this.labelAte.AutoSize = true;
            this.labelAte.Location = new System.Drawing.Point(120, 52);
            this.labelAte.Name = "labelAte";
            this.labelAte.Size = new System.Drawing.Size(22, 13);
            this.labelAte.TabIndex = 8;
            this.labelAte.Text = "até";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(38, 29);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(38, 68);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(98, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.menuFiscalToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
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
            this.tsmiExportCSV.Size = new System.Drawing.Size(142, 22);
            this.tsmiExportCSV.Text = "Exportar CSV";
            // 
            // menuFiscalToolStripMenuItem
            // 
            this.menuFiscalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechamentoDeCaixaToolStripMenuItem});
            this.menuFiscalToolStripMenuItem.Name = "menuFiscalToolStripMenuItem";
            this.menuFiscalToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.menuFiscalToolStripMenuItem.Text = "Menu Fiscal";
            // 
            // fechamentoDeCaixaToolStripMenuItem
            // 
            this.fechamentoDeCaixaToolStripMenuItem.Name = "fechamentoDeCaixaToolStripMenuItem";
            this.fechamentoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fechamentoDeCaixaToolStripMenuItem.Text = "Fechamento de Caixa";
            // 
            // ReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.gbcReportSales);
            this.Controls.Add(this.menuStrip);
            this.Name = "ReportUC";
            this.Size = new System.Drawing.Size(1159, 596);
            this.Load += new System.EventHandler(this.ReportUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtLastMonthSale)).EndInit();
            this.gbcReportSales.ResumeLayout(false);
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxPeriodo.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtLastMonthSale;
        private System.Windows.Forms.GroupBox gbcReportSales;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.Label labelAte;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportCSV;
    }
}
