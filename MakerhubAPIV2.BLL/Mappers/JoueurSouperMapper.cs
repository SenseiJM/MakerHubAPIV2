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

    }
}
