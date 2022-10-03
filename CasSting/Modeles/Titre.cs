using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasSting.Modeles
{
    public class Titre
    {
        #region Attributs

        public static List<Titre> CollClasse = new List<Titre>();
        private int _id;
        private string _nom;
        private string _urlPageWeb;
        private int _duree;
        private string _extraitAudio;
        private Album _theAlbum;
        #endregion

        #region Constructeurs

        public Titre(int id, string nom, string urlPageWeb, int duree, string extraitAudio, Album theAlbum)
        {
            Titre.CollClasse.Add(this);
            _id = id;
            _nom = nom;
            _urlPageWeb = urlPageWeb;
            _duree = duree;
            _extraitAudio = extraitAudio;
            _theAlbum = theAlbum;
        }



        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string UrlPageWeb { get => _urlPageWeb; set => _urlPageWeb = value; }
        public int Duree { get => _duree; set => _duree = value; }
        public string ExtraitAudio { get => _extraitAudio; set => _extraitAudio = value; }
        public Album TheAlbum { get => _theAlbum; set => _theAlbum = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
