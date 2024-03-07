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
    public class Traversee
    {
        private string idTraversee;
        private string idBateau;
        private Liaison liaison;
        private string dateT;
        private string heure;

        public Traversee(string idTraversee, string idBateau, Liaison Liaison, string dateT, string heure)
        {
            this.idTraversee = idTraversee;
            this.idBateau = idBateau;
            this.liaison = Liaison;
            this.dateT = dateT;
            this.heure = heure;
        }
        public string idTravarsee
        {
            get => idTraversee;
        }
        public string IdBateau
        {
            get => idBateau;
        }
        public string DateT
        {
            get => dateT;
        }

        public string Heure
        {
            get => heure;
        }

        public string Description
        {
            get => $"Id Traversee : {idTravarsee}, Nom bateau : {IdBateau}, Id Liaison : {liaison.IdLiaison}, Nom Port Départ : {dateT}, Nom Port arrivée : {heure}";
        }
    }
}
