using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DTO.Stage;

namespace MakerHubAPIV2.Mappers {
    static class StageMapper {

        public static StageModel ToModel(this StageAddDTO dto) {
            return new StageModel {
                ClassementMaximum = dto.ClassementMaximum,
                ClassementMinimum = dto.ClassementMinimum,
                DateDebut = dto.DateDebut,
                DateFin = dto.DateFin,
                Description = dto.Description,
                Entraineur = dto.Entraineur,
                HeureDebut = dto.HeureDebut,
                HeureFin = dto.HeureFin,
                NombreMax = dto.NombreMax,
                PrixAffilies = dto.PrixAffilies,
                PrixExternes = dto.PrixExternes,
                Titre = dto.Titre
            };
        }

        public static StageIndexDTO ToIndexDTO(this StageModel model) {
            return new StageIndexDTO {
                DateDebut = model.DateDebut,
                DateFin = model.DateFin,
                HeureDebut = model.HeureDebut,
                HeureFin = model.HeureFin,
                Id = model.Id,
                Titre = model.Titre
            };
        }

        public static StageDetailsDTO ToDetailsDTO(this StageModel model) {
            return new StageDetailsDTO {
                Titre = model.Titre,
                Id = model.Id,
                HeureFin = model.HeureFin,
                ClassementMaximum = model.ClassementMaximum,
                ClassementMinimum = model.ClassementMinimum,
                DateDebut = model.DateDebut,
                DateFin = model.DateFin,
                Description = model.Description,
                Entraineur = model.Entraineur,
                HeureDebut = model.HeureDebut,
                NombreMax = model.NombreMax,
                PrixAffilies = model.PrixAffilies,
                PrixExternes = model.PrixExternes
            };
        }

    }
}
