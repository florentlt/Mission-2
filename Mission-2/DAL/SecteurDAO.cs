using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.DAL
{
    public class SecteurDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Mise à jour d'un employé

        /*public static void updateLiaison(Liaison l)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update secteur set DUREE= '" + l.Login + "' where IDLIAISON = " + l.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }*/

        // Récupération de la liste des Secteurs
        public static List<Secteur> getSecteurs()
        {

            List<Secteur> ls = new List<Secteur>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur s;




                while (reader.Read())
                {

                    string idSecteur = (string)reader.GetValue(0);
                    string libelle = (string)reader.GetValue(1);

                    //Instanciation d'un secteur
                    s = new Secteur(idSecteur, libelle);

                    // Ajout de ce secteur à la liste 
                    ls.Add(s);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (ls);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }




}

