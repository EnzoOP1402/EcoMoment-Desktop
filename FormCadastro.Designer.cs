namespace EcoMoment_Desktop
{
    partial class FormCadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeCadastrar = new System.Windows.Forms.TextBox();
            this.txtSenha2Cadastrar = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastrar = new System.Windows.Forms.TextBox();
            this.txtEmailCadastrar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EcoMoment_Desktop.Properties.Resources.Tela_cadastro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtEmailCadastrar);
            this.panel1.Controls.Add(this.txtSenhaCadastrar);
            this.panel1.Controls.Add(this.txtSenha2Cadastrar);
            this.panel1.Controls.Add(this.txtNomeCadastrar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 684);
            this.panel1.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(76, 603);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(278, 44);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeCadastrar
            // 
            this.txtNomeCadastrar.Location = new System.Drawing.Point(46, 126);
            this.txtNomeCadastrar.Name = "txtNomeCadastrar";
            this.txtNomeCadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtNomeCadastrar.TabIndex = 5;
            // 
            // txtSenha2Cadastrar
            // 
            this.txtSenha2Cadastrar.Location = new System.Drawing.Point(46, 327);
            this.txtSenha2Cadastrar.Name = "txtSenha2Cadastrar";
            this.txtSenha2Cadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtSenha2Cadastrar.TabIndex = 6;
            // 
            // txtSenhaCadastrar
            // 
            this.txtSenhaCadastrar.Location = new System.Drawing.Point(46, 258);
            this.txtSenhaCadastrar.Name = "txtSenhaCadastrar";
            this.txtSenhaCadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtSenhaCadastrar.TabIndex = 7;
            // 
            // txtEmailCadastrar
            // 
            this.txtEmailCadastrar.Location = new System.Drawing.Point(46, 192);
            this.txtEmailCadastrar.Name = "txtEmailCadastrar";
            this.txtEmailCadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtEmailCadastrar.TabIndex = 8;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 681);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Administrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmailCadastrar;
        private System.Windows.Forms.TextBox txtSenhaCadastrar;
        private System.Windows.Forms.TextBox txtSenha2Cadastrar;
        private System.Windows.Forms.TextBox txtNomeCadastrar;
    }
}