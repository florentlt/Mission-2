using Connecte;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.DAL
{
    public class TraverseeDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        // Récupération de la liste des traversees
        /*public static List<Traversee> getLiaisons()
        {

            List<Traversee> lt = new List<Traversee>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from traversee");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Traversee t;


                while (reader.Read())
                {

                    string idTraversee = (string)reader.GetValue(0);
                    string idBateau = (string)reader.GetValue(1);
                    string idLiaison = (string)reader.GetValue(2);
                    string idPortDepart = (string)reader.GetValue(3);
                    string idPortArrivee = (string)reader.GetValue(4);

                    //Instanciation d'une traversee
                    t = new Traversee(idTraversee, idBateau, idLiaison, idPortArrivee, idPortDepart);

                    // Ajout de cette traversee à la liste 
                    lt.Add(t);



                }

                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lt);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }*/

        public static List<Traversee> getTraverseeLiaisons(Liaison uneLiaison)
        {

            List<Traversee> lt = new List<Traversee>();
     

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                string req = "Select * from traversee where IDLIAISON ='" + uneLiaison.IdLiaison + "'";


                Ocom = maConnexionSql.reqExec(req);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Traversee t;


                while (reader.Read())
                {

                    string idTraversee = (string)reader.GetValue(0);
                    string idBateau = (string)reader.GetValue(1);
                    string idPortDepart = (string)reader.GetValue(3);
                    string idPortArrivee = (string)reader.GetValue(4);

                    //Instanciation d'une traversee
                    t = new Traversee(idTraversee, idBateau, uneLiaison, idPortArrivee, idPortDepart);

                    // Ajout de cette traversee à la liste 
                    lt.Add(t);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                // Envoi de la liste au Manager
                return (lt);
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
    }
}

