using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Entities;

namespace MakerhubAPIV2.BLL.Mappers {
    static class StageMapper {

        public static Stage ToEntity(this StageModel model) {
            return new Stage {
                ClassementMaximum = model.ClassementMaximum,
                ClassementMinimum = model.ClassementMinimum,
                DateDebut = model.DateDebut,
                DateFin = model.DateFin,
                Description = model.Description,
                Entraineur = model.Entraineur,
                HeureDebut = model.HeureDebut,
                HeureFin = model.HeureFin,
                Id = model.Id,
                NombreMax = model.NombreMax,
                PrixAffilies = model.PrixAffilies,
                PrixExternes = model.PrixExternes,
                Titre = model.Titre
            };
        }

        public static StageModel ToModel(this Stage s) {
            return new StageModel {
                ClassementMaximum = s.ClassementMaximum,
                ClassementMinimum = s.ClassementMinimum,
                DateDebut = s.DateDebut,
                DateFin = s.DateFin,
                Description = s.Description,
                Entraineur = s.Entraineur,
                HeureDebut = s.HeureDebut,
                HeureFin = s.HeureFin,
                Id = s.Id,
                NombreMax = s.NombreMax,
                PrixAffilies = s.PrixAffilies,
                PrixExternes = s.PrixExternes,
                Titre = s.Titre
            };
        }

    }
}
