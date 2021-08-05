
namespace Csharp.Capitulo01.Sintaxe
{
    partial class VariaveisForm
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
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritméticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox1 = new System.Windows.Forms.ListBox();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementaisDecrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boleanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lógicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ternariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritméticasToolStripMenuItem,
            this.reduzidasToolStripMenuItem,
            this.incrementaisDecrementaisToolStripMenuItem,
            this.boleanasToolStripMenuItem,
            this.lógicasToolStripMenuItem,
            this.ternariasToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operaçõesToolStripMenuItem.Text = "&Operações";
            this.operaçõesToolStripMenuItem.Click += new System.EventHandler(this.operaçõesToolStripMenuItem_Click);
            // 
            // aritméticasToolStripMenuItem
            // 
            this.aritméticasToolStripMenuItem.Name = "aritméticasToolStripMenuItem";
            this.aritméticasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aritméticasToolStripMenuItem.Text = "&Aritméticas";
            this.aritméticasToolStripMenuItem.Click += new System.EventHandler(this.aritméticasToolStripMenuItem_Click);
            // 
            // resultadoListBox1
            // 
            this.resultadoListBox1.FormattingEnabled = true;
            this.resultadoListBox1.ItemHeight = 16;
            this.resultadoListBox1.Location = new System.Drawing.Point(12, 31);
            this.resultadoListBox1.Name = "resultadoListBox1";
            this.resultadoListBox1.Size = new System.Drawing.Size(776, 404);
            this.resultadoListBox1.TabIndex = 1;
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // incrementaisDecrementaisToolStripMenuItem
            // 
            this.incrementaisDecrementaisToolStripMenuItem.Name = "incrementaisDecrementaisToolStripMenuItem";
            this.incrementaisDecrementaisToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.incrementaisDecrementaisToolStripMenuItem.Text = "&Incrementais /&Decrementais";
            this.incrementaisDecrementaisToolStripMenuItem.Click += new System.EventHandler(this.incrementaisDecrementaisToolStripMenuItem_Click);
            // 
            // boleanasToolStripMenuItem
            // 
            this.boleanasToolStripMenuItem.Name = "boleanasToolStripMenuItem";
            this.boleanasToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.boleanasToolStripMenuItem.Text = "&Booleanas";
            this.boleanasToolStripMenuItem.Click += new System.EventHandler(this.boleanasToolStripMenuItem_Click);
            // 
            // lógicasToolStripMenuItem
            // 
            this.lógicasToolStripMenuItem.Name = "lógicasToolStripMenuItem";
            this.lógicasToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.lógicasToolStripMenuItem.Text = "&Lógicas";
            this.lógicasToolStripMenuItem.Click += new System.EventHandler(this.lógicasToolStripMenuItem_Click);
            // 
            // ternariasToolStripMenuItem
            // 
            this.ternariasToolStripMenuItem.Name = "ternariasToolStripMenuItem";
            this.ternariasToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.ternariasToolStripMenuItem.Text = "&Ternárias";
            this.ternariasToolStripMenuItem.Click += new System.EventHandler(this.ternariasToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultadoListBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VariaveisForm";
            this.Text = "Variáveis e Operações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritméticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox1;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementaisDecrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boleanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lógicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariasToolStripMenuItem;
    }
}

