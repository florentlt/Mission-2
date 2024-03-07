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
    public class LiaisonDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        // Suppression d'une liaison
        public static void deleteLiaison(Liaison l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("delete from liaison where IDLIAISON = " + l.IdLiaison);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        // Mise à jour d'une liaison

        public static void updateLiaison(Liaison l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("update liaison set DUREE= '" + l.Duree + "' where IDLIAISON = " + l.IdLiaison);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        public static void createLiaison(string idLiaison, string idSecteur, string idPortDepart, string idPortArrivee, string duree)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("insert into liaison values('" + idLiaison + "','" + idSecteur + "','" + idPortDepart + "','" + idPortArrivee + "','" + duree + "')");
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }


        // Récupération de la liste des liaisons
        public static List<Liaison> getLiaisons()
        {

            List<Liaison> ll = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from liaison");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;


                while (reader.Read())
                {

                    string id = (string)reader.GetValue(0);
                    string idSecteur = (string)reader.GetValue(1);
                    string idPortDepart = (string)reader.GetValue(2);
                    string idPortArrivee = (string)reader.GetValue(3);
                    string duree = (string)reader.GetValue(4);

                    //Instanciation d'une liaison
                    l = new Liaison(id, duree, idSecteur, idPortArrivee, idPortDepart);

                    // Ajout de cette Liaison à la liste 
                    ll.Add(l);



                }

                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (ll);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static List<Liaison> getLiaisonsSecteur(Secteur unSecteur)
        {

            List<Liaison> ll = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                string req = "Select * from liaison where IDSECTEUR ='" + unSecteur.IdSecteur + "'";


                Ocom = maConnexionSql.reqExec(req);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;


                while (reader.Read())
                {

                    string id = (string)reader.GetValue(0);
                    string idSecteur = (string)reader.GetValue(1);
                    string idPortDepart = (string)reader.GetValue(2);
                    string idPortArrivee = (string)reader.GetValue(3);
                    string duree = (string)reader.GetValue(4);

                    //Instanciation d'une liaison
                    l = new Liaison(id, duree, idSecteur, idPortDepart, idPortArrivee);

                    // Ajout de cette Liaison à la liste 
                    ll.Add(l);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                // Envoi de la liste au Manager
                return (ll);
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
    }

}
