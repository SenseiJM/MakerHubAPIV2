using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DTO.JoueurSouper;

namespace MakerHubAPIV2.Mappers {
    static class JoueurSouperMapper {

        public static JoueurSouperModel ToModel(this JoueurSouperAddDTO dto) {
            return new JoueurSouperModel {
                IdSouper = dto.IdSouper,
                NbReservations = dto.NbReservations,
                Token = dto.Token
            };
        }

        public static JoueurSouperIndexDTO ToIndexDTO(this JoueurSouperModel model) {
            return new JoueurSouperIndexDTO {
                Id = model.IdJoueur,
                IdJoueur = model.IdJoueur,
                IdSouper = model.IdSouper,
                Prenom = model.Prenom,
                Nom = model.Nom,
                Email = model.Email,
                NbCommande = model.NbReservations
            };
        }

    }
}
