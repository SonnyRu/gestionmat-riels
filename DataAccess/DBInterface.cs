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

namespace GestionMatériels.DataAccess
{
    internal class DBInterface
    {
        #region GetAllCombi
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
                    // Ajoutez les paramètres nécessaires à la procédure stockée
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = Nom;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                CombinaisonModel materiel_combi = new CombinaisonModel();
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
        /// Voir tout les monopalmes
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
                    // Ajoutez les paramètres nécessaires à la procédure stockée
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = Nom;

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                MonopalmeModel materiel_mono = new MonopalmeModel();
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
                    // Ajoutez les paramètres nécessaires à la procédure stockée
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = "tuba";

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                TubaModel tuba = new TubaModel();
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
        public static List<LunettesModel> GetAllLunettes()
        {
            List<LunettesModel> lunettes = new List<LunettesModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("lp_ProVoirStock", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    // Ajoutez les paramètres nécessaires à la procédure stockée
                    sqlCommand.Parameters.Add("@pNomMat", SqlDbType.VarChar).Value = "lunettes";

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            LunettesModel lunette = new LunettesModel();
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

                        // Définir le paramètre de sortie
                        SqlParameter maxIDParam = new SqlParameter("@maxID", SqlDbType.Int);
                        maxIDParam.Direction = ParameterDirection.Output;
                        fonction.Parameters.Add(maxIDParam);

                        fonction.ExecuteNonQuery();

                        // Récupérer la valeur de retour
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

                            // Ajoutez les paramètres nécessaires à la procédure stockée
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


    }
}
