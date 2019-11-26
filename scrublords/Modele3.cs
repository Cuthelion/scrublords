using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrublords
{
    public static class Modele3
    {
        private static connectScrubLords maConnexion;
        private static Visiteur visiteurConnecte3;

        public static Visiteur VisiteurConnecte3 { get => visiteurConnecte3; set => visiteurConnecte3 = value; }
        public static MEDECIN leMedecinChoisi;

        public static void trouvVisiteurId(string id)
        {
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.idVisiteur == id);

            visiteurConnecte3 = (Visiteur)LQuery.ToList().First();
        }

        public static void trouverMedecinId(int id)
        {
            var LQuery = maConnexion.MEDECIN.ToList()
                           .Where(x => x.idMedecin == id);

            leMedecinChoisi = (MEDECIN)LQuery.ToList().First();
        }
        public static LigneFraisForfait ligneFraisForfait(string idFraisForfait, string id, string mois)
        {
            var LQuery = maConnexion.LigneFraisForfait.ToList()
                .Where(x => x.idFraisForfait == idFraisForfait && x.idVisiteur == id && x.mois == mois);
            return (LigneFraisForfait)LQuery.ToList().First();
        }
        public static List<LigneFraisHorsForfait> ligneFraisHorsForfait(string id, string mois)
        {
            var LQuery = maConnexion.LigneFraisHorsForfait.ToList()
                .Where(x => x.mois == mois && x.idVisiteur == id);
            return LQuery.ToList();
        }
        

        public static void init()
        {
            maConnexion = new connectScrubLords();
        }
        public static List<Etat> listeEtat()
        {
            return maConnexion.Etat.ToList();
        }
        public static List<FAMILLE> listeFam()
        {
            return maConnexion.FAMILLE.ToList();
        }
        public static List<fichefrais> listeficheFrais()
        {
            return maConnexion.fichefrais.ToList();
        }
        public static List<FraisForfait> fraisForfaits()
        {
            return maConnexion.FraisForfait.ToList();
        }
        public static List<Laboratoire> listeLabo()
        {
            return maConnexion.Laboratoire.ToList();
        }
        public static List<LigneFraisForfait> listeLigneFraisForfait()
        {
            return maConnexion.LigneFraisForfait.ToList();
        }
        public static List<LigneFraisHorsForfait> listeFraisHsForfait()
        {
            return maConnexion.LigneFraisHorsForfait.ToList();
        }
        public static List<MEDECIN> listeMedecins()
        {
            return maConnexion.MEDECIN.ToList();
        }
        public static List<MEDICAMENT> listeMedicaments()
        {
            return maConnexion.MEDICAMENT.ToList();
        }
        public static List<MOTIF> listeMotif()
        {
            return maConnexion.MOTIF.ToList();
        }
        public static List<OFFRIR> listeoffrir()
        {
            return maConnexion.OFFRIR.ToList();
        }
        public static List<Region> listeRegion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Secteur> listeSecteur()
        {
            return maConnexion.Secteur.ToList();
        }
        public static List<SPECIALITE> listeSpecialite()
        {
            return maConnexion.SPECIALITE.ToList();
        }
        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<RAPPORT> listeRapVis()
        {
            return maConnexion.RAPPORT.ToList();
        }
        public static Object listficheFrais(string id)
        {
            var LQuery = maConnexion.fichefrais.ToList()
                         .Where(x => x.idVisiteur == id);
            return LQuery.ToList();
        }
        public static bool modifFicheFrais(fichefrais fiche, decimal montantValide)
        {
            bool retour = true;
            try
            {
                fiche.montantValide = montantValide;
                maConnexion.SaveChanges();
            }
            catch(Exception)
            {
                retour = false;
            }
            return retour;
        }
        public static bool modifLigneForfait(LigneFraisForfait ligne, int montant)
        {
            bool retour = true;
            try
            {
                ligne.quantite = montant;
                maConnexion.SaveChanges();
            }
            catch(Exception)
            {
                retour = false;
            }
            return retour;
        }
        public static bool insertLigneForfait(string id, string mois, string idForfait, int quantite)
        {
            bool retour = true;
            try
            {
                LigneFraisForfait ligneForfait = new LigneFraisForfait();
                ligneForfait.idVisiteur = id;
                ligneForfait.mois = mois;
                ligneForfait.idFraisForfait = idForfait;
                ligneForfait.quantite = quantite;
                maConnexion.LigneFraisForfait.Add(ligneForfait);
                maConnexion.SaveChanges();
            }
            catch(Exception)
            {
                retour = false;
            }
            return retour;
        }
        public static bool modifLigneHorsForfait(LigneFraisHorsForfait ligne, decimal montant, string libelle, DateTime date, int id)
        {
            bool retour = true;
            try
            {
                if (ligne.id == id)
                {
                    ligne.libelle = libelle;
                    ligne.montant = montant;
                    ligne.date = date;
                    maConnexion.SaveChanges();
                }
            }
            catch (Exception)
            {
                retour = false;
            }
            return retour;
        }
        public static bool insertLigneHorsForfait(string id, string mois, string libelle, DateTime date, decimal montant)
        {
            bool retour = true;
            try
            {
                LigneFraisHorsForfait lfhf = new LigneFraisHorsForfait();
                lfhf.idVisiteur = id;
                lfhf.mois = mois;
                lfhf.libelle = libelle;
                lfhf.date = date;
                lfhf.montant = montant;
                maConnexion.LigneFraisHorsForfait.Add(lfhf);
                maConnexion.SaveChanges();
            }
            catch (Exception)
            {
                retour = false;
            }
            return retour;
        }
        public static bool deleteLigneHorsForfait(int idlf)
        {
            bool retour = true;
            try
            {
                var LQuery = maConnexion.LigneFraisHorsForfait.ToList()
                          .Where(x => x.id == idlf);
                LigneFraisHorsForfait l = (LigneFraisHorsForfait)LQuery.ToList().First();
                maConnexion.LigneFraisHorsForfait.Remove(l);
                maConnexion.SaveChanges();
            }
            catch(Exception )
            {
                retour = false;
            }
            return retour;
        }
    }
}

