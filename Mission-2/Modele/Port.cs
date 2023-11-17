using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class Port
    {
        private string idPort;
        private string nom;

        public Port(string idPort, string nom)
        {
            this.idPort = idPort;
            this.nom = nom; 
        }
        public string IdPort
        {
            get => idPort;
        }
        public string Nom
        {
            get => nom;
        }
    }


}
