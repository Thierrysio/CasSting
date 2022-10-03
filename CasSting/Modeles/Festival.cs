using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasSting.Modeles
{
    public class Festival
    {
        #region Attributs

        public static List<Festival> CollClasse = new List<Festival>();
        private int id;
        private int annee;
        private List<DateTime> lesDates;
        private string logo;
        private static string nom = "Festival Occitanie en musique";

        private Dictionary<Groupe, DateTime> laProgrammation;


        #endregion

        #region Constructeurs

        public Festival(int id, int annee, List<DateTime> lesDates, string logo)
        {
            Festival.CollClasse.Add(this);
            this.id = id;
            this.annee = annee;
            this.lesDates = lesDates;
            this.logo = logo;
            LaProgrammation = new Dictionary<Groupe, DateTime>();
        }

        #endregion

        #region Getters/Setters
        public static string Nom { get => nom; set => nom = value; }
        public int Annee { get => annee; set => annee = value; }
        public List<DateTime> LesDates { get => lesDates; set => lesDates = value; }
        public string Logo { get => logo; set => logo = value; }
        public Dictionary<Groupe, DateTime> LaProgrammation { get => laProgrammation; set => laProgrammation = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
