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

    }
}
