﻿using MetierGestionLocation.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MetierGestionLocation.Utils
{
    public class Helper
    {
        BdAppartementContext db = new BdAppartementContext();
        /// <summary>
        /// cette methode permet de logger les erreurs dans la table Td_Erreur
        /// </summary>
        /// <param name="TitreErreur">Titre erreur</param>
        /// <param name="erreur">erreur</param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 1000 ? erreur.Substring(0, 2000) : erreur;
                log.TitreErreur = TitreErreur;
                db.Td_Erreurs.Add(log);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Gestion Location Appartement";
                eventLog.WriteEntry(string.Format("date: {0},libelle: {1},description:{2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}