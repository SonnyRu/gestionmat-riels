using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMatériels.Models;
using GestionMatériels.Tools;
using GestionMatériels.Forms;
using System.IO;
using Microsoft.VisualBasic.Logging;
using GestionMatériels.DataAccess;
using System.Drawing;

namespace GestionMatériels.DataAccess
{
    internal class DBInterface
    {

        #region GetAdmin
        /// <summary>
        /// Obtenir l'Admin qui s'est connecté
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>L'objet Conseiller qui s'est connecté</returns>
        public static AdminModel GetAdmin(string login, byte[] password)
        {
            AdminModel admin = new AdminModel();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_Authentification", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pLogin", SqlDbType.NVarChar).Value = login;
                    sqlCommand.Parameters.Add("@pPassword", SqlDbType.VarBinary).Value = password;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            sqlDataReader.Read();
                            admin.Id = sqlDataReader.GetInt32(0);
                            admin.Nom = sqlDataReader.GetString(1);
                            admin.Prenom = sqlDataReader.GetString(2);
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Logs.WriteLog(String.Concat("DBInterface : l'utilisateur ", login, " vient de se connecter"), w);
                            }
                        }
                        else
                        {
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Logs.WriteLog(String.Concat(String.Concat("DBInterface : identifiants de connexion invalide. Login :", login)), w);
                            }
                        }
                    }
                }
            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Logs.WriteLog("DBInterface : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return admin;
        }
        #endregion

        #region GetAllCombi
        /// <summary>
        /// Voir toutes les combinaisons
        /// </summary>
        /// <param name="Nom"></param>
        /// <returns></returns>
        public static List<CombinaisonModel> GetAllCombi(string Nom)
        {
            List<CombinaisonModel> materiels_combi = new List<CombinaisonModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_ProVoirStock", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = Nom;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                CombinaisonModel materiel_combi = new CombinaisonModel();
                                materiel_combi.Id = (int)sqlDataReader["Id"];
                                materiel_combi.Nom = (string)sqlDataReader["Nom"];
                                materiel_combi.Marque = (string)sqlDataReader["Marque"];
                                materiel_combi.Taille = sqlDataReader["Taille"] == DBNull.Value ? "" : (string)sqlDataReader["Taille"];
                                materiel_combi.SaisonCombi = sqlDataReader["SaisonCombi"] == DBNull.Value ? "" : (string)sqlDataReader["SaisonCombi"];
                                materiels_combi.Add(materiel_combi);
                            }
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Matériel Combi : Affichage du matériel"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat(String.Concat("Matériel Combi : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Matériel Combi : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return materiels_combi;
        }
        #endregion

        #region GetAllMono
        /// <summary>
        /// Voir toutes les monopalmes
        /// </summary>
        /// <param name="Nom"></param>
        /// <returns></returns>
        public static List<MonopalmeModel> GetAllMono(string Nom)
        {
            List<MonopalmeModel> materiels_mono = new List<MonopalmeModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_ProVoirStock", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = Nom;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                MonopalmeModel materiel_mono = new MonopalmeModel();
                                materiel_mono.Id = (int)sqlDataReader["Id"];
                                materiel_mono.Nom = (string)sqlDataReader["Nom"];
                                materiel_mono.Marque = (string)sqlDataReader["Marque"];
                                materiel_mono.TypeMono = sqlDataReader["TypeMono"] == DBNull.Value ? "" : (string)sqlDataReader["TypeMono"];
                                materiel_mono.Pointure = sqlDataReader["Pointure"] == DBNull.Value ? "" : (string)sqlDataReader["Pointure"];
                                materiels_mono.Add(materiel_mono);
                            }
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Matériel Mono : Affichage du matériel"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat(String.Concat("Matériel Mono : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Matériel Mono : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return materiels_mono;
        }
        #endregion

        #region GetAllTubas
        /// <summary>
        /// Voir tout les tubas
        /// </summary>
        /// <returns></returns>
        public static List<MatérielModel> GetAllTubas()
        {
            List<MatérielModel> tubas = new List<MatérielModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_ProVoirStock", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = "tuba";

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                MatérielModel tuba = new MatérielModel();
                                tuba.Id = (int)sqlDataReader["Id"];
                                tuba.Nom = (string)sqlDataReader["Nom"];
                                tuba.Marque = (string)sqlDataReader["Marque"];
                                tubas.Add(tuba);
                            }
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Matériel Tuba : Affichage du matériel"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat(String.Concat("Matériel Tuba : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Matériel Tuba : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return tubas;
        }
        #endregion

        #region GetAllLunettes
        /// <summary>
        /// Voir toutes les lunettes
        /// </summary>
        /// <returns></returns>
        public static List<MatérielModel> GetAllLunettes()
        {
            List<MatérielModel> lunettes = new List<MatérielModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_ProVoirStock", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = "lunettes";

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            MatérielModel lunette = new MatérielModel();
                            lunette.Id = (int)sqlDataReader["Id"];
                            lunette.Nom = (string)sqlDataReader["Nom"];
                            lunette.Marque = (string)sqlDataReader["Marque"];
                            lunettes.Add(lunette);
                        }
                        sqlCommand.ExecuteNonQuery();
                        string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                        using (StreamWriter w = File.AppendText(logErrorFilePath))
                        {
                            Logs.WriteLog(String.Concat("Matériel Lunettes : Affichage du matériel"), w);
                        }
                    }
                }
            }
            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Matériel Lunettes : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return lunettes;
        }
        #endregion

        #region GetAllNageurs
        /// <summary>
        /// Voir tout les nageurs
        /// </summary>
        /// <returns></returns>
        public static List<NageurModel> GetAllNageurs()
        {
            List<NageurModel> nageurs = new List<NageurModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_ProVoirNageur", connection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                NageurModel nageur = new NageurModel();
                                nageur.Id1 = (int)sqlDataReader["Id"];
                                nageur.Nom1 = (string)sqlDataReader["Nom"];
                                nageur.Prénom1 = (string)sqlDataReader["Prénom"];
                                nageur.Mail1 = (string)sqlDataReader["Mail"];
                                nageur.Téléphone1 = (string)sqlDataReader["Téléphone"];
                                nageurs.Add(nageur);
                            }
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Nageur : Affichage les nageurs"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat(String.Concat("Nageur : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Nageur : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return nageurs;
        }
        #endregion

        #region GetAllPrêt
        /// <summary>
        /// Voir tout les prêts
        /// </summary>
        /// <param name="Nom"></param>
        /// <returns></returns>
        public static List<PrêtModel> GetAllPrêt()
        {
            List<PrêtModel> prêts = new List<PrêtModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_ProVoirPret", connection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                PrêtModel prêt = new PrêtModel();
                                prêt.Id = (int)sqlDataReader["Id"];
                                prêt.DateEmprunt = (DateTime)sqlDataReader["DateEmprunt"];
                                prêt.DateRetour = (DateTime)sqlDataReader["DateRetourPret"];
                                NageurModel nageur = new NageurModel();
                                nageur.Nom1 = (string)sqlDataReader["Nom"];
                                nageur.Prénom1 = (string)sqlDataReader["Prenom"];
                                prêt.Nageur = nageur;
                                MatérielModel matériel = new MatérielModel();
                                matériel.Nom = (string)sqlDataReader["Nom_Matériel"];
                                matériel.Marque = (string)sqlDataReader["Marque"];
                                prêt.Matériel = matériel;
                                prêts.Add(prêt);
                            }
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Prêt : Affichage des prêts"), w);
                            }
                        }
                        else
                        {
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat(String.Concat("Prêt : Erreur")), w);
                            }
                        }
                    }
                }
            }

            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Prêt : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return prêts;
        }
        #endregion

        #region AjouterCombinaison
        /// <summary>
        /// Ajouter une Combinaison
        /// </summary>
        /// <param name="Marque"></param>
        /// <param name="Nom"></param>
        /// <param name="Taille"></param>
        /// <param name="SaisonCombi"></param>
        public static void AjouterCombinaison(string Marque, string Nom, string Taille, string SaisonCombi)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                {
                    using (SqlCommand fonction = new SqlCommand("getMaxID", connection))
                    {
                        fonction.CommandType = System.Data.CommandType.StoredProcedure;

                       
                        SqlParameter maxIDParam = new SqlParameter("@maxID", SqlDbType.Int);
                        maxIDParam.Direction = ParameterDirection.Output;
                        fonction.Parameters.Add(maxIDParam);

                        fonction.ExecuteNonQuery();

                        
                        int maxID = (int)maxIDParam.Value;


                        CombinaisonModel combinaison = new CombinaisonModel();
                        combinaison.Id = maxID + 1;
                        combinaison.Marque = Marque;
                        combinaison.Nom = Nom;
                        combinaison.Taille = Taille;
                        combinaison.SaisonCombi = SaisonCombi;
                        using (SqlCommand sqlCommand = new SqlCommand("lp_AjouterCombinaison", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            
                            sqlCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = combinaison.Id;
                            sqlCommand.Parameters.Add("@pMarque", SqlDbType.VarChar).Value = Marque;
                            sqlCommand.Parameters.Add("@pNom", SqlDbType.VarChar).Value = Nom;
                            sqlCommand.Parameters.Add("@pTaille", SqlDbType.VarChar).Value = Taille;
                            sqlCommand.Parameters.Add("@pSaisonCombi", SqlDbType.VarChar).Value = SaisonCombi;

                            sqlCommand.ExecuteNonQuery();
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Ajout_Combi : Ajout d'une combinaison (Nom : " + Nom + ") "), w);
                            }
                        }
                    }

                }
            }
            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Ajout_Combi : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AjouterMonopalme
        /// <summary>
        /// Ajouter une monopalme
        /// </summary>
        /// <param name="Marque"></param>
        /// <param name="Nom"></param>
        /// <param name="TypeMono"></param>
        /// <param name="Pointure"></param>
        public static void AjouterMonopalme(string Marque, string Nom, string TypeMono, string Pointure)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                {
                    using (SqlCommand fonction = new SqlCommand("getMaxID", connection))
                    {
                        fonction.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter maxIDParam = new SqlParameter("@maxID", SqlDbType.Int);
                        maxIDParam.Direction = ParameterDirection.Output;
                        fonction.Parameters.Add(maxIDParam);

                        fonction.ExecuteNonQuery();

                        int maxID = (int)maxIDParam.Value;


                        MonopalmeModel monopalme = new MonopalmeModel();
                        monopalme.Id = maxID + 1;
                        monopalme.Marque = Marque;
                        monopalme.Nom = Nom;
                        monopalme.TypeMono = TypeMono;
                        monopalme.Pointure = Pointure;
                        using (SqlCommand sqlCommand = new SqlCommand("lp_AjouterMonopalme", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = monopalme.Id;
                            sqlCommand.Parameters.Add("@pMarque", SqlDbType.VarChar).Value = Marque;
                            sqlCommand.Parameters.Add("@pNom", SqlDbType.VarChar).Value = Nom;
                            sqlCommand.Parameters.Add("@pTypeMono", SqlDbType.VarChar).Value = TypeMono;
                            sqlCommand.Parameters.Add("@pPointure", SqlDbType.VarChar).Value = Pointure;

                            sqlCommand.ExecuteNonQuery();
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Ajout_Mono : Ajout d'un monopalme (Nom : " + Nom + ") "), w);
                            }
                        }
                    }

                }
            }
            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Ajout_Mono : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AjouterPrêt
        public static void AjouterPrêt(DateTime dateEmprunt, DateTime dateRetour, string ID_1, string ID_2)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                {
                    using (SqlCommand fonction = new SqlCommand("getMaxIDPrêt", connection))
                    {
                        fonction.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter maxIDParam = new SqlParameter("@maxID", SqlDbType.Int);
                        maxIDParam.Direction = ParameterDirection.Output;
                        fonction.Parameters.Add(maxIDParam);

                        fonction.ExecuteNonQuery();

                        int maxID = (int)maxIDParam.Value;


                        PrêtModel prêt = new PrêtModel();
                        prêt.Id = maxID + 1;

                        using (SqlCommand sqlCommand = new SqlCommand("lp_AjouterUnPret", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            PrêtModel pret = new PrêtModel();
                            pret.DateEmprunt = dateEmprunt;
                            pret.DateRetour = dateRetour;
                            NageurModel nageur = new NageurModel();
                            nageur.Id1 = Convert.ToInt32(ID_1);
                            pret.Nageur = nageur;
                            MatérielModel matériel = new MatérielModel();
                            matériel.Id = Convert.ToInt32(ID_2);
                            pret.Matériel = matériel;
                            sqlCommand.Parameters.Add(new SqlParameter("@pId", prêt.Id));
                            sqlCommand.Parameters.Add(new SqlParameter("@pDateEmprunt", dateEmprunt));
                            sqlCommand.Parameters.Add(new SqlParameter("@pDateRetourPret", dateRetour));
                            sqlCommand.Parameters.Add(new SqlParameter("@pID1", ID_1));
                            sqlCommand.Parameters.Add(new SqlParameter("@pID2", ID_2));
                            sqlCommand.ExecuteNonQuery();
                            string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                            using (StreamWriter w = File.AppendText(logErrorFilePath))
                            {
                                Logs.WriteLog(String.Concat("Ajout_Prêt : Ajout d'un prêt" ), w);
                            }
                        }
                    }

                }
            }
            catch (InvalidOperationException)
            {
                string logErrorFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "logerror.txt");
                using (StreamWriter w = File.AppendText(logErrorFilePath))
                {
                    Logs.WriteLog("Ajout_Prêt : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

    }
}
