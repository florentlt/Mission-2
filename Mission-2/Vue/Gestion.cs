using Connecte;
using Connecte.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecte
{
    public partial class Gestion : Form
    {
        Mgr monManager;
        List<Secteur> lstSecteur = new List<Secteur>();
        List<Liaison> lstLiaison = new List<Liaison>();
        List<Traversee> lstTraversee = new List<Traversee>();


        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }


        private void Gestion_Load(object sender, EventArgs e)
        {
            lstSecteur = monManager.chargementSecteurBD();
            afficherSecteur();
        }
  
        public void afficherLiaison()
        {
            try
            {
                listBoxLiaison.DataSource = null;
                listBoxLiaison.DataSource = lstLiaison;
                listBoxLiaison.DisplayMember = "Description";
                labelNombreLiaisons.Text = lstLiaison.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void afficherSecteur()
        {
            try
            {
                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = lstSecteur;
                listBoxSecteur.DisplayMember = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void afficherTraversee()
        {
            try
            {
                listBoxTraversee.DataSource = null;
                listBoxTraversee.DataSource = lstTraversee;
                listBoxTraversee.DisplayMember = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void buttonLiaison_Click(object sender, EventArgs e)
        {
            int compte = lstLiaison.Count();
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            Insertion insertion = new Insertion(uneLiaison.IdSecteur);
            insertion.ShowDialog();
            if (lstLiaison.Count() > compte)
            {
                Secteur unSecteur = (Secteur)listBoxSecteur.SelectedItem;
                lstLiaison = monManager.chargementLiaisonSecteurBD(unSecteur);
                afficherLiaison();
            }
        }

        private void buttonModifier_Click_1(object sender, EventArgs e)
        {
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            Insertion insertion = new Insertion(uneLiaison.IdSecteur, uneLiaison);
            insertion.ShowDialog();
            if (uneLiaison != listBoxLiaison.SelectedItem)
            {
                Secteur unSecteur = (Secteur)listBoxSecteur.SelectedItem;
                lstLiaison = monManager.chargementLiaisonSecteurBD(unSecteur);
                afficherLiaison();
            }   
        }

        private void buttonSupprimer_Click_1(object sender, EventArgs e)
        {
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            monManager.deleteLiaison(uneLiaison);
            Secteur unSecteur = (Secteur)listBoxSecteur.SelectedItem;
            lstLiaison = monManager.chargementLiaisonSecteurBD(unSecteur);
            afficherLiaison();
        }

        private void listBoxSecteur_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Secteur unSecteur = (Secteur)listBoxSecteur.SelectedItem;
            lstLiaison = monManager.chargementLiaisonSecteurBD(unSecteur);
            afficherLiaison();

        }

        private void listBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            if (uneLiaison != null)
            {
                lstTraversee = monManager.chargementTraverseeLiaisonBD(uneLiaison);
                afficherTraversee();
            } 
        }
    }
}