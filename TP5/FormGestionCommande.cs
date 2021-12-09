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
    public partial class FormGestionCommande : Form
    {
        private int idCommande;


        public FormGestionCommande(int idCommande)
        {  
            this.idCommande = idCommande;
         
            InitializeComponent();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            tbMontant.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cbClients.SelectedIndex = -1;
        }

        private void FormGestionCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu M = new Menu();
            this.Hide();
            M.Show();
        }

        private void FormGestionCommande_Load(object sender, EventArgs e)
        {
            cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "NOMCLI";
            bsClient.DataSource = Modele.listeClients();
            cbClients.DataSource = bsClient;
            tbMontant.Text = "0";
            if (idCommande!=-1)
            {
                commande c = Modele.RecupererCommande(idCommande);
                tbMontant.Text = Convert.ToString(c.MONTANTCDE);
                dateTimePicker1.Value = c.DATECDE.Value;
                cbClients.SelectedValue = c.NUMCLI;
            }
        }

        private void TbMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789" + (char)8;
            if (st.IndexOf(e.KeyChar) == -1)
            {
                MessageBox.Show("Entrez uniquement des chiffres");
                e.Handled = true;
            }
        }

        private void TbMontant_Leave(object sender, EventArgs e)
        {
            if(tbMontant.Text == "" || Convert.ToInt32(tbMontant.Text) < 0)
            {
                MessageBox.Show("Entrer un prix positif.");
            }
        }

        private void DateTimePicker1_Leave(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("La commande ne peut être antèrieur à la date du jour.");
            }
        }

        private void CbClients_Leave(object sender, EventArgs e)
        {
            if(cbClients.SelectedIndex == -1)
            {
                MessageBox.Show("Renseigner le client.");
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (idCommande == -1)
            {
                if (Modele.AjoutCommande(Convert.ToInt32(tbMontant.Text), dateTimePicker1.Value, Convert.ToInt32(cbClients.SelectedValue)))
                {
                    MessageBox.Show("La commande a été enregistrée");
                }
                else
                {
                    MessageBox.Show("Erreur La commande n'a pas été enregistrée");
                }
                tbMontant.Clear();
                dateTimePicker1.Value = DateTime.Now;
                cbClients.SelectedIndex = -1;
            }
            else
            {
                if(Modele.ModifierCommande(idCommande, Convert.ToInt32(tbMontant.Text), dateTimePicker1.Value, Convert.ToInt32(cbClients.SelectedValue)))
                {
                    MessageBox.Show("La commande a bien été modifiée.");
                }
                else
                {
                    MessageBox.Show("Erreur La commande n'a pas été modifiée");
                }
            }
        }
    }
}
