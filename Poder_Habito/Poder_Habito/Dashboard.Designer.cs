namespace Poder_Habito
{
    partial class Dashboard
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
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarRotinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarExcluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarRotinaToolStripMenuItem,
            this.alterarExcluirToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // criarRotinaToolStripMenuItem
            // 
            this.criarRotinaToolStripMenuItem.Name = "criarRotinaToolStripMenuItem";
            this.criarRotinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criarRotinaToolStripMenuItem.Text = "Criar Rotina";
            this.criarRotinaToolStripMenuItem.Click += new System.EventHandler(this.criarRotinaToolStripMenuItem_Click);
            // 
            // alterarExcluirToolStripMenuItem
            // 
            this.alterarExcluirToolStripMenuItem.Name = "alterarExcluirToolStripMenuItem";
            this.alterarExcluirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.alterarExcluirToolStripMenuItem.Text = "Ver/Excluir Rotina";
            this.alterarExcluirToolStripMenuItem.Click += new System.EventHandler(this.alterarExcluirToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 423);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarRotinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarExcluirToolStripMenuItem;
    }
}

