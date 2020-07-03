namespace Sispani.View.AuxSale
{
    partial class FinalizeForm
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
            this.groupBoxFormasPagamento = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnTerm = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.lblSelTerm = new System.Windows.Forms.Label();
            this.lblSelCard = new System.Windows.Forms.Label();
            this.lblSelMoney = new System.Windows.Forms.Label();
            this.txtPayValue = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.groupBoxFormasPagamento.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFormasPagamento
            // 
            this.groupBoxFormasPagamento.Controls.Add(this.label4);
            this.groupBoxFormasPagamento.Controls.Add(this.label3);
            this.groupBoxFormasPagamento.Controls.Add(this.label2);
            this.groupBoxFormasPagamento.Controls.Add(this.lblTerm);
            this.groupBoxFormasPagamento.Controls.Add(this.lblCard);
            this.groupBoxFormasPagamento.Controls.Add(this.lblMoney);
            this.groupBoxFormasPagamento.Controls.Add(this.btnTerm);
            this.groupBoxFormasPagamento.Controls.Add(this.btnCard);
            this.groupBoxFormasPagamento.Controls.Add(this.btnMoney);
            this.groupBoxFormasPagamento.Location = new System.Drawing.Point(12, 50);
            this.groupBoxFormasPagamento.Name = "groupBoxFormasPagamento";
            this.groupBoxFormasPagamento.Size = new System.Drawing.Size(249, 76);
            this.groupBoxFormasPagamento.TabIndex = 8;
            this.groupBoxFormasPagamento.TabStop = false;
            this.groupBoxFormasPagamento.Text = "Formas de Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "R$";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(192, 52);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(28, 13);
            this.lblTerm.TabIndex = 5;
            this.lblTerm.Text = "0,00";
            // 
            // lblCard
            // 
            this.lblCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(111, 52);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(28, 13);
            this.lblCard.TabIndex = 4;
            this.lblCard.Text = "0,00";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(30, 52);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(28, 13);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "0,00";
            // 
            // btnTerm
            // 
            this.btnTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerm.FlatAppearance.BorderSize = 0;
            this.btnTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerm.ForeColor = System.Drawing.Color.White;
            this.btnTerm.Location = new System.Drawing.Point(168, 19);
            this.btnTerm.Name = "btnTerm";
            this.btnTerm.Size = new System.Drawing.Size(75, 23);
            this.btnTerm.TabIndex = 2;
            this.btnTerm.Text = "Prazo";
            this.btnTerm.UseVisualStyleBackColor = false;
            this.btnTerm.Click += new System.EventHandler(this.BtnTerm_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.ForeColor = System.Drawing.Color.White;
            this.btnCard.Location = new System.Drawing.Point(87, 19);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(75, 23);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "Cartão";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.BtnCard_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoney.FlatAppearance.BorderSize = 0;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.ForeColor = System.Drawing.Color.White;
            this.btnMoney.Location = new System.Drawing.Point(6, 19);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(75, 23);
            this.btnMoney.TabIndex = 0;
            this.btnMoney.Text = "Dinheiro";
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.BtnMoney_Click);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.lblSelTerm);
            this.groupBoxTipo.Controls.Add(this.lblSelCard);
            this.groupBoxTipo.Controls.Add(this.lblSelMoney);
            this.groupBoxTipo.Controls.Add(this.txtPayValue);
            this.groupBoxTipo.Location = new System.Drawing.Point(12, 132);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(249, 53);
            this.groupBoxTipo.TabIndex = 13;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Método";
            // 
            // lblSelTerm
            // 
            this.lblSelTerm.AutoSize = true;
            this.lblSelTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelTerm.Location = new System.Drawing.Point(51, 18);
            this.lblSelTerm.Name = "lblSelTerm";
            this.lblSelTerm.Size = new System.Drawing.Size(86, 24);
            this.lblSelTerm.TabIndex = 22;
            this.lblSelTerm.Text = "Prazo R$";
            this.lblSelTerm.Visible = false;
            // 
            // lblSelCard
            // 
            this.lblSelCard.AutoSize = true;
            this.lblSelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelCard.Location = new System.Drawing.Point(45, 18);
            this.lblSelCard.Name = "lblSelCard";
            this.lblSelCard.Size = new System.Drawing.Size(92, 24);
            this.lblSelCard.TabIndex = 21;
            this.lblSelCard.Text = "Cartão R$";
            this.lblSelCard.Visible = false;
            // 
            // lblSelMoney
            // 
            this.lblSelMoney.AutoSize = true;
            this.lblSelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelMoney.Location = new System.Drawing.Point(28, 18);
            this.lblSelMoney.Name = "lblSelMoney";
            this.lblSelMoney.Size = new System.Drawing.Size(109, 24);
            this.lblSelMoney.TabIndex = 20;
            this.lblSelMoney.Text = "Dinheiro R$";
            // 
            // txtPayValue
            // 
            this.txtPayValue.Location = new System.Drawing.Point(143, 21);
            this.txtPayValue.Name = "txtPayValue";
            this.txtPayValue.Size = new System.Drawing.Size(100, 20);
            this.txtPayValue.TabIndex = 3;
            this.txtPayValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPayValue_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(168, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 25);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0,00";
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalize.Enabled = false;
            this.btnFinalize.FlatAppearance.BorderSize = 0;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.ForeColor = System.Drawing.Color.White;
            this.btnFinalize.Location = new System.Drawing.Point(160, 191);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(101, 23);
            this.btnFinalize.TabIndex = 4;
            this.btnFinalize.Text = "Finalizar";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.BtnFinalize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(7, 13);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(155, 25);
            this.lblTotalValue.TabIndex = 18;
            this.lblTotalValue.Text = "Valor Total: R$";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(56, 13);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(106, 25);
            this.lblTroco.TabIndex = 19;
            this.lblTroco.Text = "Troco: R$";
            this.lblTroco.Visible = false;
            // 
            // FinalizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 226);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.groupBoxFormasPagamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalizeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxFormasPagamento.ResumeLayout(false);
            this.groupBoxFormasPagamento.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormasPagamento;
        private System.Windows.Forms.Button btnTerm;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.TextBox txtPayValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSelMoney;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelTerm;
        private System.Windows.Forms.Label lblSelCard;
        private System.Windows.Forms.Label lblTroco;
    }
}