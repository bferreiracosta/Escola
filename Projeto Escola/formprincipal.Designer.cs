namespace Projeto_Escola
{
    partial class formprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEscolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroEscolaToolStripMenuItem,
            this.cadastroAlunoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroEscolaToolStripMenuItem
            // 
            this.cadastroEscolaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.editarCadastroToolStripMenuItem});
            this.cadastroEscolaToolStripMenuItem.Name = "cadastroEscolaToolStripMenuItem";
            this.cadastroEscolaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.cadastroEscolaToolStripMenuItem.Text = "Escola";
            this.cadastroEscolaToolStripMenuItem.Click += new System.EventHandler(this.cadastroEscolaToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar ";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editarCadastroToolStripMenuItem.Text = "Editar Cadastro";
            this.editarCadastroToolStripMenuItem.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem_Click);
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            this.cadastroAlunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.editarCadastroToolStripMenuItem1});
            this.cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            this.cadastroAlunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cadastroAlunoToolStripMenuItem.Text = "Aluno";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // editarCadastroToolStripMenuItem1
            // 
            this.editarCadastroToolStripMenuItem1.Name = "editarCadastroToolStripMenuItem1";
            this.editarCadastroToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.editarCadastroToolStripMenuItem1.Text = "Editar Cadastro";
            this.editarCadastroToolStripMenuItem1.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem1_Click);
            // 
            // formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(539, 253);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "formprincipal";
            this.Text = "formprincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEscolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem1;
    }
}