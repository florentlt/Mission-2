using Connecte.Controleur;
using Connecte;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecte
{
    public class Liaison
    {
        private string idLiaison;
        private string duree;
        private string idSecteur;
        private string idPortDepart;
        private string idPortArrivee;

        public Liaison(string idLiaison, string duree, string idSecteur, string idPortDepart, string idPortArrivee)
        {
            this.idLiaison = idLiaison;
            this.duree = duree;
            this.idSecteur = idSecteur;
            this.idPortDepart = idPortDepart;
            this.idPortArrivee = idPortArrivee;
        }

        public string IdPortDepart
        {
            get => idPortDepart;
        }

        public string IdSecteur
        {
            get => idSecteur;
        }

        public string IdLiaison
        {
            get => idLiaison;
        }
        public string Duree
        {
            get => duree;
            set => duree = value;
        }
        public string IdPortArrivee
        {
            get => idPortArrivee;
        }

        public string Description
        {
            get => $"Id Liaison : {idLiaison}, Nom Port Départ : {idPortDepart}, Nom Port arrivée : {idPortArrivee}, durée : {duree}";
        }
    }
}
