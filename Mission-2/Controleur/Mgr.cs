using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.Controleur;
using Connecte;
using Connecte.DAL;

namespace Connecte.Controleur
{
    public class Mgr
    {

        LiaisonDAO LiaisonDAO = new LiaisonDAO();

        List<Liaison> maListeLiaison;
        List<Secteur> maListeSecteur;
        List<Port> maListePort;
        List<Traversee> maListeTraversee;

        public Mgr()
        {

            maListeLiaison = new List<Liaison>();
        }



        // Récupération de la liste des Liaisons à partir de la DAL
        public List<Liaison> chargementLiaisonBD()
        {

            maListeLiaison = LiaisonDAO.getLiaisons();

            return (maListeLiaison);
        }

        // Récupération du nombre de Liaisons à partir de la DAL

        public List<Liaison> chargementLiaisonSecteurBD(Secteur unSecteur)
        {

            maListeLiaison = LiaisonDAO.getLiaisonsSecteur(unSecteur);

            return (maListeLiaison);
        }


        // Récupération de la liste des Secteurs à partir de la DAL
        public List<Secteur> chargementSecteurBD()
        {

            maListeSecteur = SecteurDAO.getSecteurs();

            return (maListeSecteur);
        }

        // Récupération de la liste des Ports à partir de la DAL
        public List<Port> chargementPortBD()
        {

            maListePort = PortDAO.getPorts();

            return (maListePort);
        }

        // Récupération de la liste des Traversees à partir de la DAL
        public List<Traversee> chargementTraverseeLiaisonBD(Liaison uneLiaison)
        {

            maListeTraversee = TraverseeDAO.getTraverseeLiaisons(uneLiaison);

            return (maListeTraversee);
        }



        // Mise à jour d'une Liason  dans la DAL
        public void updateLiaison(Liaison l)
        {

            LiaisonDAO.updateLiaison(l);

        }
        // Suppression d'une liaison
        public void deleteLiaison(Liaison l)
        {

            LiaisonDAO.deleteLiaison(l);

        }
        

        // Insertion d'une liaison dans la DAL
        public void createLiaison(string idLiaison, string idSecteur,string idPortDepart, string idPortArrivee, string duree)
        {

            LiaisonDAO.createLiaison(idLiaison, idSecteur, idPortDepart, idPortArrivee, duree);

        }

    }
}
