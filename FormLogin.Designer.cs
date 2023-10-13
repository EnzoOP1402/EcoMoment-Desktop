namespace EcoMoment_Desktop
{
    partial class FormLogin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioAdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.txtEmailEntrar = new System.Windows.Forms.TextBox();
            this.lblSenhaEntrar = new System.Windows.Forms.Label();
            this.lblEmailEntrar = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosWebToolStripMenuItem,
            this.usuárioAdmToolStripMenuItem});
            this.menuToolStripMenuItem.Enabled = false;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // usuáriosWebToolStripMenuItem
            // 
            this.usuáriosWebToolStripMenuItem.Name = "usuáriosWebToolStripMenuItem";
            this.usuáriosWebToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.usuáriosWebToolStripMenuItem.Text = "Usuários[Adm]";
            // 
            // usuárioAdmToolStripMenuItem
            // 
            this.usuárioAdmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.usuárioAdmToolStripMenuItem.Name = "usuárioAdmToolStripMenuItem";
            this.usuárioAdmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioAdmToolStripMenuItem.Text = "Usuário[Web]";
            this.usuárioAdmToolStripMenuItem.Click += new System.EventHandler(this.usuárioAdmToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultarToolStripMenuItem.Text = "Consultar dados do usuário";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(71, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 391);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Não tem uma conta? Cadastre-se!";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(118, 340);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(144, 28);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenhaEntrar);
            this.groupBox1.Controls.Add(this.txtEmailEntrar);
            this.groupBox1.Controls.Add(this.lblSenhaEntrar);
            this.groupBox1.Controls.Add(this.lblEmailEntrar);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(89, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(205, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrar";
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.Location = new System.Drawing.Point(36, 104);
            this.txtSenhaEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.PasswordChar = '*';
            this.txtSenhaEntrar.Size = new System.Drawing.Size(145, 20);
            this.txtSenhaEntrar.TabIndex = 4;
            this.txtSenhaEntrar.Text = "batata";
            // 
            // txtEmailEntrar
            // 
            this.txtEmailEntrar.Location = new System.Drawing.Point(36, 51);
            this.txtEmailEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailEntrar.Name = "txtEmailEntrar";
            this.txtEmailEntrar.Size = new System.Drawing.Size(144, 20);
            this.txtEmailEntrar.TabIndex = 3;
            this.txtEmailEntrar.Text = "vitorwolf0007@hotmail.com";
            // 
            // lblSenhaEntrar
            // 
            this.lblSenhaEntrar.AutoSize = true;
            this.lblSenhaEntrar.Location = new System.Drawing.Point(34, 89);
            this.lblSenhaEntrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaEntrar.Name = "lblSenhaEntrar";
            this.lblSenhaEntrar.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaEntrar.TabIndex = 2;
            this.lblSenhaEntrar.Text = "Senha:";
            // 
            // lblEmailEntrar
            // 
            this.lblEmailEntrar.AutoSize = true;
            this.lblEmailEntrar.Location = new System.Drawing.Point(34, 36);
            this.lblEmailEntrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailEntrar.Name = "lblEmailEntrar";
            this.lblEmailEntrar.Size = new System.Drawing.Size(38, 13);
            this.lblEmailEntrar.TabIndex = 1;
            this.lblEmailEntrar.Text = "E-mail:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(36, 145);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+-";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSenhaEntrar;
        private System.Windows.Forms.Label lblEmailEntrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.TextBox txtEmailEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem usuárioAdmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
    }
}

