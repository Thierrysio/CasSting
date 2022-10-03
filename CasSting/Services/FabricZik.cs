using CasSting.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CasSting.Services
{
    public static class FabricZik
    {
        public static List<Album> GetAlbumsUnGroupe(Groupe unGroupe)
        {
            List<Album> lesAlbums = new List<Album>();
            /*
             *  on appelle l'API zikoc pour obtenir tous les albums du groupe 
                dont le numéro est passé en paramètre. Puis, on récupère dans la collection xLesAlbums 
                tous les nœuds album du fichier XML obtenu lors de l'appel à l'API. 
            */
            string urlDetailsAlbums = "https://api.zikoc.com/2.0/artist/"
            + unGroupe.Id.ToString() + "/albums&output=xml";
            IEnumerable<XElement> xLesAlbums =
            XDocument.Load(urlDetailsAlbums).Root.Element("data").Elements("album");
            /*
                pour chaque élément de la collection xLesAlbums, on crée une 
                instance d'Album avec les caractéristiques de l'élément. Puis, on l'ajoute à la collection 
                lesAlbums qui est retournée par la méthode.
            */
            foreach (XElement xUnAlbum in xLesAlbums)
            {
                int id = (int)xUnAlbum.Element("id");
                string nom = xUnAlbum.Element("title").Value;

                //erreur le fichier XML indique link et non pas url
                string urlPageWeb = xUnAlbum.Element("link").Value;
                string photoPochette = xUnAlbum.Element("cover").Value;
                Album unAlbum = new Album(id, nom, urlPageWeb, photoPochette, unGroupe);
                lesAlbums.Add(unAlbum);
            }
            return lesAlbums;
        }
    }
}
