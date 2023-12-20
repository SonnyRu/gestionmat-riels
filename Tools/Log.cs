using System;
using System.IO;

namespace GestionMatériels.Tools
{
    /// <summary>
    /// Auteur : Sonny Russo.
    /// Date de création : 22/11/2023.
    /// Date de modification : 
    /// Gère les logs de l'application.
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// Ecrit les logs dans un fichier dédié.
        /// (logerror : fichier consignant les erreurs d'exécution, logmessage : fichier consignant les messages de l'application).
        /// </summary>
        /// <param name="logMessage">Le message à logger.</param>
        /// <param name="w">Le fichier dans lequel écrire.</param>
        public static void WriteLog(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
            w.Flush();
        }
    }
}
