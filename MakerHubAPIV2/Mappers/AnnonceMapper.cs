using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DTO.Annonce;

namespace MakerHubAPIV2.Mappers {
    static class AnnonceMapper {

        public static AnnonceModel ToModel(this AnnonceAddDTO dto) {
            return new AnnonceModel {
                Description = dto.Description,
                Titre = dto.Titre,
                UrlPhoto = dto.UrlPhoto
            };
        }

        public static AnnonceIndexDTO ToIndexDTO(this AnnonceModel model) {
            return new AnnonceIndexDTO {
                Id = model.Id,
                Titre = model.Titre,
                UrlPhoto = model.UrlPhoto
            };
        }

        public static AnnonceDetailsDTO ToDetailsDTO(this AnnonceModel model) {
            return new AnnonceDetailsDTO {
                Description = model.Description,
                Id = model.Id,
                Titre = model.Titre,
                UrlPhoto = model.UrlPhoto
            };
        }

    }
}
