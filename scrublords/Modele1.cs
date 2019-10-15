using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace scrublords
{
    public static class Modele1
    {
        private static connectScrubLords maConnexion;
        private static Visiteur visiteurConnecte;
        

        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }

        public static void trouvVisiteurId(string id)
        {
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.idVisiteur == id);

            visiteurConnecte = (Visiteur)LQuery.ToList().First();
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
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static string validConnexion(string id, string mp)
        {
            string message = "";
            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables utilisateurConnecte et connexionValide, la comparaison des mots de passes se fera via utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
            return message;
        }
        public static bool verifLogin(string ID, string MDP)
        {
            var MDPCry = "0x" + GetMd5Hash(MDP);
            foreach (Visiteur util in maConnexion.Visiteur)
            {
                if (ID == util.idVisiteur && MDPCry == util.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

