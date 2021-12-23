using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Entities;

namespace MakerhubAPIV2.BLL.Mappers {
    static class AnnonceMapper {

        public static Annonce ToEntity(this AnnonceModel model) {
            return new Annonce {
                Description = model.Description,
                Id = model.Id,
                Titre = model.Titre,
                UrlPhoto = model.UrlPhoto
            };
        }

        public static AnnonceModel ToModel(this Annonce a) {
            return new AnnonceModel {
                Description = a.Description,
                Titre = a.Titre,
                UrlPhoto = a.UrlPhoto,
                Id = a.Id
            };
        }

    }
}
