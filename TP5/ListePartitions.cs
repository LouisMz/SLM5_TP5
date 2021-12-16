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
    public partial class ListePartitions : Form
    {
        public ListePartitions()
        {
            InitializeComponent();
        }

        private void ListePartitions_Load(object sender, EventArgs e)
        {
            cbCommande.ValueMember = "NUMCDE";
            cbCommande.DisplayMember = "NUMCDE";
            bsCommande.DataSource = Modele.listeCommande();
            cbCommande.DataSource = bsCommande;
            cbCommande.SelectedIndex = -1;
        }

        private void BsCommande_CurrentChanged(object sender, EventArgs e)
        {

            Modele.listePartitionsParCommande(idCommande);
        }
    }
}
