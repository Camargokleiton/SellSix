namespace SellSix
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            panelScreens = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1010, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeProdutoToolStripMenuItem, cadastroDeUsuárioToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            cadastroDeProdutoToolStripMenuItem.Size = new Size(183, 22);
            cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            cadastroDeUsuárioToolStripMenuItem.Size = new Size(183, 22);
            cadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            // 
            // panelScreens
            // 
            panelScreens.Dock = DockStyle.Fill;
            panelScreens.Location = new Point(0, 24);
            panelScreens.Name = "panelScreens";
            panelScreens.Size = new Size(1010, 612);
            panelScreens.TabIndex = 1;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1010, 636);
            Controls.Add(panelScreens);
            Controls.Add(menuStrip1);
            Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "MainScreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellSix";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private Panel panelScreens;
    }
}
