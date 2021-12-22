using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DTO.Souper;

namespace MakerHubAPIV2.Mappers {
    static class SouperMapper {

        public static SouperModel ToModel(this SouperAddDTO dto) {
            return new SouperModel {
                Date = dto.Date,
                Description = dto.Description,
                NombreMax = dto.NombreMax,
                PrixAffilies = dto.PrixAffilies,
                PrixExternes = dto.PrixExternes,
                Titre = dto.Titre,
                TypeSouper = dto.TypeSouper,
                UrlPhoto = dto.UrlPhoto
            };
        }

        public static SouperDetailsDTO ToDetailsDTO(this SouperModel model) {
            return new SouperDetailsDTO {
                Date = model.Date,
                Description = model.Description,
                Id = model.Id,
                NombreMax = model.NombreMax,
                PrixAffilies = model.PrixAffilies,
                PrixExternes = model.PrixExternes,
                Titre = model.Titre,
                TypeSouper = model.TypeSouper,
                UrlPhoto = model.UrlPhoto
            };
        }

        public static SouperIndexDTO ToIndexDTO(this SouperModel model) {
            return new SouperIndexDTO {
                Date = model.Date,
                Id = model.Id,
                Titre = model.Titre,
                TypeSouper = model.TypeSouper,
                UrlPhoto = model.UrlPhoto
            };
        }

    }
}
