using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Entities;

namespace MakerhubAPIV2.BLL.Mappers {
    static class JoueurSouperMapper {

        public static JoueurSouper ToEntity(this JoueurSouperModel model) {
            return new JoueurSouper {
                IdJoueur = model.IdJoueur,
                IdSouper = model.IdSouper,
                NbReservations = model.NbReservations
            };
        }

        public static JoueurSouperModel ToModel(this JoueurSouper js, Joueur j) {
            return new JoueurSouperModel {
                IdJoueur = js.IdJoueur,
                IdSouper = js.IdSouper,
                NbReservations = js.NbReservations,
                Email = j.Email,
                Nom = j.Nom,
                Prenom = j.Prenom
            };
        }

    }
}
