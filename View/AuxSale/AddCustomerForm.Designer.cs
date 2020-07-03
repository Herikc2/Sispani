namespace Sispani.View.AuxSale
{
    partial class AddCustomerForm
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
            this.txtCpfT = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.txtNameT = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnCancelT = new System.Windows.Forms.Button();
            this.btnConfirmT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCpfT
            // 
            this.txtCpfT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpfT.Location = new System.Drawing.Point(12, 70);
            this.txtCpfT.MaxLength = 14;
            this.txtCpfT.Name = "txtCpfT";
            this.txtCpfT.Size = new System.Drawing.Size(253, 20);
            this.txtCpfT.TabIndex = 14;
            this.txtCpfT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCpfT_KeyDown);
            this.txtCpfT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpfT_KeyPress);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(12, 54);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 18;
            this.labelCPF.Text = "CPF";
            // 
            // txtNameT
            // 
            this.txtNameT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameT.Enabled = false;
            this.txtNameT.Location = new System.Drawing.Point(12, 25);
            this.txtNameT.MaxLength = 127;
            this.txtNameT.Name = "txtNameT";
            this.txtNameT.Size = new System.Drawing.Size(253, 20);
            this.txtNameT.TabIndex = 13;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 17;
            this.labelNome.Text = "Nome";
            // 
            // btnCancelT
            // 
            this.btnCancelT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnCancelT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelT.FlatAppearance.BorderSize = 0;
            this.btnCancelT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelT.ForeColor = System.Drawing.Color.White;
            this.btnCancelT.Location = new System.Drawing.Point(109, 111);
            this.btnCancelT.Name = "btnCancelT";
            this.btnCancelT.Size = new System.Drawing.Size(75, 23);
            this.btnCancelT.TabIndex = 16;
            this.btnCancelT.Text = "Cancelar";
            this.btnCancelT.UseVisualStyleBackColor = false;
            this.btnCancelT.Click += new System.EventHandler(this.BtnCancelT_Click);
            // 
            // btnConfirmT
            // 
            this.btnConfirmT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnConfirmT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmT.FlatAppearance.BorderSize = 0;
            this.btnConfirmT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmT.ForeColor = System.Drawing.Color.White;
            this.btnConfirmT.Location = new System.Drawing.Point(190, 111);
            this.btnConfirmT.Name = "btnConfirmT";
            this.btnConfirmT.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmT.TabIndex = 15;
            this.btnConfirmT.Text = "Confirmar";
            this.btnConfirmT.UseVisualStyleBackColor = false;
            this.btnConfirmT.Click += new System.EventHandler(this.BtnConfirmT_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 146);
            this.Controls.Add(this.txtCpfT);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.txtNameT);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnCancelT);
            this.Controls.Add(this.btnConfirmT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfT;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox txtNameT;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnCancelT;
        private System.Windows.Forms.Button btnConfirmT;
    }
}