using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ListeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClients LC = new ListeClients();
            this.Hide();
            LC.Show();
        }

        private void ListeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeCommande LCo = new ListeCommande();
            this.Hide();
            LCo.Show();
        }

        private void AjouterCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionCommande FGC = new FormGestionCommande(-1);
            this.Hide();
            FGC.Show();
        }
    }
}
