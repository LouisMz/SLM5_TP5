using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public static class Modele // bien mettre vos noms
    {
        private static bd_partitionEntities maConnexion;
        private static commande maCommande;
        public static void init()
        {
            maConnexion = new bd_partitionEntities();
        }
        public static List<client> listeClients()
        {
            return maConnexion.client.ToList();
        }
        public static List<commande> listeCommande()
        {
            return maConnexion.commande.ToList();
        }
        public static List<partitions> listPartitions()
        {
            return maConnexion.partitions.ToList();
        }

        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            bool vretour = true;
            try
            {
                maCommande = new commande(); // instanciation de l’objet précédemment créé
                maCommande.MONTANTCDE = montant; // mise à jour des propriétés
                maCommande.DATECDE = dateC.Date;
                maCommande.NUMCLI = idClient;

                maConnexion.commande.Add(maCommande); // ajout de l’objet
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static commande RecupererCommande(int idCommande)
        {
            commande uneCommande = new commande();
            try
            {
                uneCommande = maConnexion.commande.First(x => x.NUMCDE == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }
        public static bool ModifierCommande(int idCde, int montant, DateTime dateC, int idClient)
        {
            bool vretour = true;
            try
            {
                maCommande = RecupererCommande(idCde);
                maCommande.MONTANTCDE = montant;
                maCommande.DATECDE = dateC.Date;
                maCommande.NUMCLI = idClient;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool SuppCommande(int idCommande)
        {
            bool vretour = true;
            try
            {
                maCommande = RecupererCommande(idCommande);
                maConnexion.commande.Remove(maCommande);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }
        public static List<partitions> listePartitionsParCommande(int idC)
        {
            commande c = maConnexion.commande.Find(idC);
            return (c.partitions.ToList());
        }
    }
}
