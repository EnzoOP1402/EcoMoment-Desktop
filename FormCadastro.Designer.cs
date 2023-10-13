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
            this.gpbxCadastrar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCadastrar = new System.Windows.Forms.TextBox();
            this.txtEmailCadastrar = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaCadastrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha2Cadastrar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gpbxCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbxCadastrar);
            this.panel1.Location = new System.Drawing.Point(55, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 511);
            this.panel1.TabIndex = 0;
            // 
            // gpbxCadastrar
            // 
            this.gpbxCadastrar.Controls.Add(this.txtSenha2Cadastrar);
            this.gpbxCadastrar.Controls.Add(this.label4);
            this.gpbxCadastrar.Controls.Add(this.txtSenhaCadastrar);
            this.gpbxCadastrar.Controls.Add(this.label3);
            this.gpbxCadastrar.Controls.Add(this.btnCadastrar);
            this.gpbxCadastrar.Controls.Add(this.txtEmailCadastrar);
            this.gpbxCadastrar.Controls.Add(this.txtNomeCadastrar);
            this.gpbxCadastrar.Controls.Add(this.label2);
            this.gpbxCadastrar.Controls.Add(this.label1);
            this.gpbxCadastrar.Location = new System.Drawing.Point(45, 96);
            this.gpbxCadastrar.Name = "gpbxCadastrar";
            this.gpbxCadastrar.Size = new System.Drawing.Size(338, 392);
            this.gpbxCadastrar.TabIndex = 0;
            this.gpbxCadastrar.TabStop = false;
            this.gpbxCadastrar.Text = "Cadastrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // txtNomeCadastrar
            // 
            this.txtNomeCadastrar.Location = new System.Drawing.Point(66, 71);
            this.txtNomeCadastrar.Name = "txtNomeCadastrar";
            this.txtNomeCadastrar.Size = new System.Drawing.Size(180, 22);
            this.txtNomeCadastrar.TabIndex = 2;
            // 
            // txtEmailCadastrar
            // 
            this.txtEmailCadastrar.Location = new System.Drawing.Point(69, 132);
            this.txtEmailCadastrar.Name = "txtEmailCadastrar";
            this.txtEmailCadastrar.Size = new System.Drawing.Size(177, 22);
            this.txtEmailCadastrar.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(43, 342);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(242, 32);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // txtSenhaCadastrar
            // 
            this.txtSenhaCadastrar.Location = new System.Drawing.Point(69, 201);
            this.txtSenhaCadastrar.Name = "txtSenhaCadastrar";
            this.txtSenhaCadastrar.PasswordChar = '*';
            this.txtSenhaCadastrar.Size = new System.Drawing.Size(177, 22);
            this.txtSenhaCadastrar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite sua senha novamente:";
            // 
            // txtSenha2Cadastrar
            // 
            this.txtSenha2Cadastrar.Location = new System.Drawing.Point(69, 263);
            this.txtSenha2Cadastrar.Name = "txtSenha2Cadastrar";
            this.txtSenha2Cadastrar.Size = new System.Drawing.Size(177, 22);
            this.txtSenha2Cadastrar.TabIndex = 8;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 580);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastro";
            this.panel1.ResumeLayout(false);
            this.gpbxCadastrar.ResumeLayout(false);
            this.gpbxCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbxCadastrar;
        private System.Windows.Forms.TextBox txtSenha2Cadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmailCadastrar;
        private System.Windows.Forms.TextBox txtNomeCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}