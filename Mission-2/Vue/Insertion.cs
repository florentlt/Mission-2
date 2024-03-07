using Connecte.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecte
{
    public partial class Insertion : Form
    {
        private Liaison l;
        private string idSect;
        Mgr monManager;
        List<Liaison> lstLiaison;
        List<Port> lstPort;
        public Insertion(string idSecteur, Liaison uneLiaison = null)
        {
            InitializeComponent();
            monManager = new Mgr();
            if (uneLiaison != null )
            {
                this.l = uneLiaison;
            }
            this.idSect = idSecteur;
        }

        private void Insertion_Load(object sender, EventArgs e)
        {
            if (l != null)
            {
                btnValider.Text = "Valider la modification";
                cBPortDepart.Text = l.IdPortDepart;
                cBPortArrivee.Text = l.IdPortArrivee;
                TextBoxSecteur.Text = l.IdSecteur;
                TextBoxLiaison.Text = l.IdLiaison;
                TextBoxDuree.Text = l.Duree;

            }
            else
            {
                TextBoxLiaison.ReadOnly = false;

                cBPortDepart.Enabled = true;
                cBPortArrivee.Enabled = true;

                TextBoxSecteur.Text = idSect;

                lstPort = monManager.chargementPortBD();
                foreach (Port port in lstPort)
                {
                    cBPortDepart.Items.Add(port.IdPort);
                    cBPortArrivee.Items.Add(port.IdPort);
                }

                btnValider.Text = "Valider l'insertion";
            }
        }

        private void inserer_Click(object sender, EventArgs e)
        {
            if (l != null)
            {
                l.Duree = TextBoxDuree.Text;
                monManager.updateLiaison(l);
            }
            else
            {
                monManager.createLiaison(TextBoxLiaison.Text, TextBoxSecteur.Text, cBPortDepart.Text, cBPortArrivee.Text, TextBoxDuree.Text);
                lstLiaison = monManager.chargementLiaisonBD();
            }
            this.Close();
        }

    }
    }
