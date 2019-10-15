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
        private static fichefrais fichefrais3;

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
        public static LigneFraisForfait trouveLignefrais(string id)
        {
            var LQuery = maConnexion.LigneFraisForfait.ToList()
                .Where(x => x.idFraisForfait == id);

            return (LigneFraisForfait)LQuery.ToList().First();
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
    }
}

