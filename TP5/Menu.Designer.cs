namespace TP5
{
    partial class Menu
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
            this.listeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listePartitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientToolStripMenuItem,
            this.listeCommandeToolStripMenuItem,
            this.ajouterCommandeToolStripMenuItem,
            this.listePartitionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeClientToolStripMenuItem
            // 
            this.listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            this.listeClientToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.listeClientToolStripMenuItem.Text = "Liste Client";
            this.listeClientToolStripMenuItem.Click += new System.EventHandler(this.ListeClientToolStripMenuItem_Click);
            // 
            // listeCommandeToolStripMenuItem
            // 
            this.listeCommandeToolStripMenuItem.Name = "listeCommandeToolStripMenuItem";
            this.listeCommandeToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.listeCommandeToolStripMenuItem.Text = "Liste Commande";
            this.listeCommandeToolStripMenuItem.Click += new System.EventHandler(this.ListeCommandeToolStripMenuItem_Click);
            // 
            // ajouterCommandeToolStripMenuItem
            // 
            this.ajouterCommandeToolStripMenuItem.Name = "ajouterCommandeToolStripMenuItem";
            this.ajouterCommandeToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.ajouterCommandeToolStripMenuItem.Text = "Ajouter Commande";
            this.ajouterCommandeToolStripMenuItem.Click += new System.EventHandler(this.AjouterCommandeToolStripMenuItem_Click);
            // 
            // listePartitionToolStripMenuItem
            // 
            this.listePartitionToolStripMenuItem.Name = "listePartitionToolStripMenuItem";
            this.listePartitionToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.listePartitionToolStripMenuItem.Text = "Liste Partition";
            this.listePartitionToolStripMenuItem.Click += new System.EventHandler(this.ListePartitionToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listePartitionToolStripMenuItem;
    }
}