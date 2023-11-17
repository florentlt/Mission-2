using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class Secteur
    {
        private string idSecteur;
        private string libelle;

        public Secteur (string idSecteur, string libelle)
        {
            this.idSecteur = idSecteur;
            this.libelle = libelle;
        }
        public string IdSecteur
        {
            get => idSecteur;
        }
        public string Description
        {
            get => $"Id Secteur:{idSecteur},Libelle:{libelle}";
        }
    }


}
