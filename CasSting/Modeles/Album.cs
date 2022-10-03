using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasSting.Modeles
{
    public class Album
    {
        #region Attributs

        public static List<Album> CollClasse = new List<Album>();
        private int _id;
        private string _nom;
        private string _urlPageWeb;
        private string _photoPochette;
        private Groupe _leGroupe;
        private List<Titre> _lesTitres;
        #endregion

        #region Constructeurs

        public Album(int id, string nom, string urlPageWeb, string photoPochette, Groupe leGroupe)
        {
            Album.CollClasse.Add(this);
            _id = id;
            _nom = nom;
            _urlPageWeb = urlPageWeb;
            _photoPochette = photoPochette;
            _leGroupe = leGroupe;
            _lesTitres = new List<Titre>();
        }


        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string UrlPageWeb { get => _urlPageWeb; set => _urlPageWeb = value; }
        public string PhotoPochette { get => _photoPochette; set => _photoPochette = value; }
        internal Groupe LeGroupe { get => _leGroupe; set => _leGroupe = value; }
        public List<Titre> LesTitres { get => _lesTitres; set => _lesTitres = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
