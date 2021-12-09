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
    public partial class ListeClients : Form
    {
        public ListeClients()
        {
            InitializeComponent();
        }

        private void ListeClients_Load(object sender, EventArgs e)
        {
            bsClients.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
            dgvClients.Columns[5].Visible = false;
        }

        private void ListeClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu M = new Menu();
            this.Hide();
            M.Show();
        }
    }
}
