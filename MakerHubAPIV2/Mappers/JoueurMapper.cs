using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DTO.Joueur;

namespace MakerHubAPIV2.Mappers {
    static class JoueurMapper {

        public static JoueurModel ToModel(this JoueurAddDTO dto) {
            return new JoueurModel {
                Email = dto.Email,
                HeureDepartDames = dto.HeureDepartDames,
                HeureDepartHommes = dto.HeureDepartHommes,
                IdAFTT = dto.IdAFTT,
                IdentifiantConnexion = dto.IdentifiantConnexion,
                IdEquipeDames = dto.IdEquipeDames,
                IdEquipeHommes = dto.IdEquipeHommes,
                MotDePasse = dto.MotDePasse,
                Nom = dto.Nom,
                Prenom = dto.Prenom
            };
        }

        public static JoueurDetailsDTO ToDetailsDTO(this JoueurModel model) {
            return new JoueurDetailsDTO {
                Email = model.Email,
                HeureDepartDames = model.HeureDepartDames,
                HeureDepartHommes = model.HeureDepartHommes,
                Id = model.Id,
                IdAFTT = model.IdAFTT,
                IdentifiantConnexion = model.IdentifiantConnexion,
                IdEquipeDames = model.IdEquipeDames,
                IdEquipeHommes = model.IdEquipeHommes,
                MotDePasse = model.MotDePasse,
                Nom = model.Nom,
                Prenom = model.Prenom
            };
        }

    }
}
