using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.DAL
{
    public class PortDAO
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

        // Récupération de la liste des Ports
        public static List<Port> getPorts()
        {

            List<Port> lp = new List<Port>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from port");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Port p;




                while (reader.Read())
                {

                    string idPort = (string)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);

                    //Instanciation d'un port
                    p = new Port(idPort, nom);

                    // Ajout de ce port à la liste 
                    lp.Add(p);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lp);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }




}

