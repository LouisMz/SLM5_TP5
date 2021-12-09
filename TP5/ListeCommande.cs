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
    public partial class ListeCommande : Form
    {
        public ListeCommande()
        {
            InitializeComponent();
        }

        private void ListeCommande_Load(object sender, EventArgs e)
        {
            cbClient.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClient.DisplayMember = "NOMCLI";
            bsCommande.DataSource = Modele.listeCommande(); // appel de la méthode listeClients
            dgvCommande.DataSource = bsCommande;
            dgvCommande.Columns[4].Visible = false;
            dgvCommande.Columns[5].Visible = false;
            bsClient.DataSource = Modele.listeClients();
            cbClient.DataSource = bsClient;
        }

        private void BsClient_CurrentChanged(object sender, EventArgs e)
        {
            bsCommande.DataSource = ((client)bsClient.Current).commande.Select(x => new {
                x.NUMCDE,
                x.DATECDE,
                x.MONTANTCDE,
                x.NUMCLI,
                x.client.NOMCLI,
                x.client.PRENOMCLI
            })
            .OrderBy(x => x.DATECDE);
            dgvCommande.DataSource = bsCommande;
        }

        private void ListeCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu M = new Menu();
            this.Hide();
            M.Show();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            FormGestionCommande FGC = new FormGestionCommande(-1);
            this.Hide();
            FGC.Show();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsCommande.Current.GetType();
            int idCommande = (int)type.GetProperty("NUMCDE").GetValue(bsCommande.Current, null);
            int montant = (int)type.GetProperty("MONTANTCDE").GetValue(bsCommande.Current, null);
            DateTime dateTime = (DateTime)type.GetProperty("DATECDE").GetValue(bsCommande.Current, null);
            int idClient = (int)type.GetProperty("NUMCLI").GetValue(bsCommande.Current, null);

            FormGestionCommande FGC = new FormGestionCommande(idCommande);
            this.Hide();
            FGC.Show();
        }
    }
}
