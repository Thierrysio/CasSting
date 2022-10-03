using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasSting.Modeles
{
    public class Groupe
    {
        #region Attributs

        public static List<Groupe> CollClasse = new List<Groupe>();
        private int _id;
        private string _nom;
        private string _genreMusical;
        private string _photo;
        private string _urlPageWeb;
        private List<Album> _lesAlbums;
        #endregion

        #region Constructeurs

        public Groupe(int id, string nom, string genreMusical, string photo, string urlPageWeb)
        {
            Groupe.CollClasse.Add(this);
            _id = id;
            _nom = nom;
            _genreMusical = genreMusical;
            _photo = photo;
            _urlPageWeb = urlPageWeb;
            _lesAlbums = new List<Album>();
        }



        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string GenreMusical { get => _genreMusical; set => _genreMusical = value; }
        public string Photo { get => _photo; set => _photo = value; }
        public string UrlPageWeb { get => _urlPageWeb; set => _urlPageWeb = value; }
        internal List<Album> LesAlbums { get => _lesAlbums; set => _lesAlbums = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
