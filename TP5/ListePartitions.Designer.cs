namespace TP5
{
    partial class ListePartitions
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsCommande = new System.Windows.Forms.BindingSource(this.components);
            this.cbCommande = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // bsCommande
            // 
            this.bsCommande.CurrentChanged += new System.EventHandler(this.BsCommande_CurrentChanged);
            // 
            // cbCommande
            // 
            this.cbCommande.FormattingEnabled = true;
            this.cbCommande.Location = new System.Drawing.Point(12, 53);
            this.cbCommande.Name = "cbCommande";
            this.cbCommande.Size = new System.Drawing.Size(121, 21);
            this.cbCommande.TabIndex = 1;
            // 
            // ListePartitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCommande);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListePartitions";
            this.Text = "ListePartitions";
            this.Load += new System.EventHandler(this.ListePartitions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsCommande;
        private System.Windows.Forms.ComboBox cbCommande;
    }
}