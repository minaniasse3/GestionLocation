using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierGestionLocation.Model;

namespace MetierGestionLocation
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // Appartement
        [OperationContract]
        bool AddAppartement(Appartement appartement);
        [OperationContract]
        List<Appartement> GetListeAppartement(string adresse, float? capacite, bool? disponible);
        [OperationContract]
        Appartement GetAppartementById(int? id);
        [OperationContract]
        bool DeleteAppartement(Appartement appartement);
        [OperationContract]
        bool UpdateAppartement(Appartement appartement);

        // Locataire
        [OperationContract]
        bool AddLocataire(Locataire locataire);
        [OperationContract]
        bool UpdateLocataire(Locataire locataire);
        [OperationContract]
        bool DeleteLocataire(Locataire locataire);
        [OperationContract]
        Locataire GetLocataireById(int? id);
        [OperationContract]
        List<Locataire> GetListeLocataires();

        // Propriétaire
        [OperationContract]
        bool AddProprietaire(Proprietaire proprietaire);
        [OperationContract]
        bool UpdateProprietaire(Proprietaire proprietaire);
        [OperationContract]
        bool DeleteProprietaire(Proprietaire proprietaire);
        [OperationContract]
        Proprietaire GetProprietaireById(int? id);
        [OperationContract]
        List<Proprietaire> GetListeProprietaires();

        // Mode Paiement
        [OperationContract]
        bool AddModePaiement(ModePaiement mode);
        [OperationContract]
        ModePaiement GetModePaiementById(int? id);
        [OperationContract]
        bool UpdateModePaiement(ModePaiement mode);
        [OperationContract]
        bool DeleteModePaiement(ModePaiement mode);
        [OperationContract]
        List<ModePaiement> GetListeModePaiements();

        // ContratLocation
        [OperationContract]
        bool AddContratLocation(ContratLocation contrat);
        [OperationContract]
        bool UpdateContratLocation(ContratLocation contrat);
        [OperationContract]
        bool DeleteContratLocation(ContratLocation contrat);
        [OperationContract]
        ContratLocation GetContratLocationById(int? id);
        [OperationContract]
        List<ContratLocation> GetListeContratLocation(string statut);

        // Paiement
        [OperationContract]
        bool AddPaiement(Paiement paiement);
        [OperationContract]
        bool UpdatePaiement(Paiement paiement);
        [OperationContract]
        bool DeletePaiement(Paiement paiement);
        [OperationContract]
        Paiement GetPaiementById(int? id);
        [OperationContract]
        List<Paiement> GetListePaiements(DateTime? dateDebut, DateTime? dateFin, int? idContrat);

        // Utilisateur
        [OperationContract]
        bool AddUtilisateur(Utilisateur utilisateur);
        [OperationContract]
        bool UpdateUtilisateur(Utilisateur utilisateur);
        [OperationContract]
        bool DeleteUtilisateur(Utilisateur utilisateur);
        [OperationContract]
        Utilisateur GetUtilisateurById(int? id);
        [OperationContract]
        Utilisateur AuthenticateUser(string identifiant, string motDePasse);
        [OperationContract]
        List<Utilisateur> GetListeUtilisateurs();
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
