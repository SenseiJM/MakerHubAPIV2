using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Entities;

namespace MakerhubAPIV2.BLL.Mappers {
    static class SouperMapper {

        public static Souper ToEntity(this SouperModel model) {
            return new Souper {
                Date = model.Date,
                Description = model.Description,
                NombreMax = model.NombreMax,
                PrixAffilies = model.PrixAffilies,
                PrixExternes = model.PrixExternes,
                Titre = model.Titre,
                UrlPhoto = model.UrlPhoto,
                TypeSouper = model.TypeSouper
            };
        }

        public static SouperModel ToModel(this Souper s) {
            return new SouperModel {
                Id = s.Id,
                Date = s.Date,
                Description = s.Description,
                NombreMax = s.NombreMax,
                PrixAffilies = s.PrixAffilies,
                PrixExternes = s.PrixExternes,
                Titre = s.Titre,
                TypeSouper = s.TypeSouper,
                UrlPhoto = s.UrlPhoto
            };
        }

    }
}
