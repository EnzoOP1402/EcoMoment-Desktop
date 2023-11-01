namespace EcoMoment_Desktop
{
    partial class FormExcluirAtualizarUsuarioWeb
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
            this.comboBoxExcluirWeb = new System.Windows.Forms.ComboBox();
            this.txtNomeExcluirWeb = new System.Windows.Forms.TextBox();
            this.btnExcluirWeb = new System.Windows.Forms.Button();
            this.txtSenhaExcluirWeb = new System.Windows.Forms.TextBox();
            this.txtEmailExcluirWeb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxExcluirWeb
            // 
            this.comboBoxExcluirWeb.FormattingEnabled = true;
            this.comboBoxExcluirWeb.Location = new System.Drawing.Point(77, 140);
            this.comboBoxExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxExcluirWeb.Name = "comboBoxExcluirWeb";
            this.comboBoxExcluirWeb.Size = new System.Drawing.Size(260, 24);
            this.comboBoxExcluirWeb.TabIndex = 13;
            // 
            // txtNomeExcluirWeb
            // 
            this.txtNomeExcluirWeb.Location = new System.Drawing.Point(77, 210);
            this.txtNomeExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeExcluirWeb.Name = "txtNomeExcluirWeb";
            this.txtNomeExcluirWeb.Size = new System.Drawing.Size(260, 22);
            this.txtNomeExcluirWeb.TabIndex = 12;
            // 
            // btnExcluirWeb
            // 
            this.btnExcluirWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnExcluirWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirWeb.Location = new System.Drawing.Point(94, 469);
            this.btnExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirWeb.Name = "btnExcluirWeb";
            this.btnExcluirWeb.Size = new System.Drawing.Size(243, 46);
            this.btnExcluirWeb.TabIndex = 11;
            this.btnExcluirWeb.Text = "Excluir/ Atualizar";
            this.btnExcluirWeb.UseVisualStyleBackColor = false;
            // 
            // txtSenhaExcluirWeb
            // 
            this.txtSenhaExcluirWeb.Location = new System.Drawing.Point(77, 347);
            this.txtSenhaExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaExcluirWeb.Name = "txtSenhaExcluirWeb";
            this.txtSenhaExcluirWeb.Size = new System.Drawing.Size(260, 22);
            this.txtSenhaExcluirWeb.TabIndex = 10;
            // 
            // txtEmailExcluirWeb
            // 
            this.txtEmailExcluirWeb.Location = new System.Drawing.Point(74, 277);
            this.txtEmailExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailExcluirWeb.Name = "txtEmailExcluirWeb";
            this.txtEmailExcluirWeb.Size = new System.Drawing.Size(263, 22);
            this.txtEmailExcluirWeb.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EcoMoment_Desktop.Properties.Resources.Excluir_Web;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 546);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormExcluirAtualizarUsuarioWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 543);
            this.Controls.Add(this.comboBoxExcluirWeb);
            this.Controls.Add(this.txtNomeExcluirWeb);
            this.Controls.Add(this.btnExcluirWeb);
            this.Controls.Add(this.txtSenhaExcluirWeb);
            this.Controls.Add(this.txtEmailExcluirWeb);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormExcluirAtualizarUsuarioWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Usuário Web";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxExcluirWeb;
        private System.Windows.Forms.TextBox txtNomeExcluirWeb;
        private System.Windows.Forms.Button btnExcluirWeb;
        private System.Windows.Forms.TextBox txtSenhaExcluirWeb;
        private System.Windows.Forms.TextBox txtEmailExcluirWeb;
    }
}