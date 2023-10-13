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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.txtEmailEntrar = new System.Windows.Forms.TextBox();
            this.lblSenhaEntrar = new System.Windows.Forms.Label();
            this.lblEmailEntrar = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.usuárioAdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTodosOsUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(685, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosWebToolStripMenuItem,
            this.usuárioAdmToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(95, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 481);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Não tem uma conta? Cadastre-se!";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(158, 419);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(192, 35);
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
            this.groupBox1.Location = new System.Drawing.Point(119, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrar";
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.Location = new System.Drawing.Point(48, 128);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(192, 22);
            this.txtSenhaEntrar.TabIndex = 4;
            // 
            // txtEmailEntrar
            // 
            this.txtEmailEntrar.Location = new System.Drawing.Point(48, 63);
            this.txtEmailEntrar.Name = "txtEmailEntrar";
            this.txtEmailEntrar.Size = new System.Drawing.Size(191, 22);
            this.txtEmailEntrar.TabIndex = 3;
            // 
            // lblSenhaEntrar
            // 
            this.lblSenhaEntrar.AutoSize = true;
            this.lblSenhaEntrar.Location = new System.Drawing.Point(46, 109);
            this.lblSenhaEntrar.Name = "lblSenhaEntrar";
            this.lblSenhaEntrar.Size = new System.Drawing.Size(49, 16);
            this.lblSenhaEntrar.TabIndex = 2;
            this.lblSenhaEntrar.Text = "Senha:";
            this.lblSenhaEntrar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEmailEntrar
            // 
            this.lblEmailEntrar.AutoSize = true;
            this.lblEmailEntrar.Location = new System.Drawing.Point(46, 44);
            this.lblEmailEntrar.Name = "lblEmailEntrar";
            this.lblEmailEntrar.Size = new System.Drawing.Size(48, 16);
            this.lblEmailEntrar.TabIndex = 1;
            this.lblEmailEntrar.Text = "E-mail:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(48, 179);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(191, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // usuárioAdmToolStripMenuItem
            // 
            this.usuárioAdmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.consultarTodosOsUsuáriosToolStripMenuItem});
            this.usuárioAdmToolStripMenuItem.Name = "usuárioAdmToolStripMenuItem";
            this.usuárioAdmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuárioAdmToolStripMenuItem.Text = "Usuário[Web]";
            this.usuárioAdmToolStripMenuItem.Click += new System.EventHandler(this.usuárioAdmToolStripMenuItem_Click);
            // 
            // usuáriosWebToolStripMenuItem
            // 
            this.usuáriosWebToolStripMenuItem.Name = "usuáriosWebToolStripMenuItem";
            this.usuáriosWebToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuáriosWebToolStripMenuItem.Text = "Usuários[Adm]";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.consultarToolStripMenuItem.Text = "Consultar dados do usuário";
            // 
            // consultarTodosOsUsuáriosToolStripMenuItem
            // 
            this.consultarTodosOsUsuáriosToolStripMenuItem.Name = "consultarTodosOsUsuáriosToolStripMenuItem";
            this.consultarTodosOsUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.consultarTodosOsUsuáriosToolStripMenuItem.Text = "Consultar todos os usuários";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+-";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ToolStripMenuItem consultarTodosOsUsuáriosToolStripMenuItem;
    }
}

