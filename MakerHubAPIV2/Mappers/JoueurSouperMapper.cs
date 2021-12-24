using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DTO.JoueurSouper;

namespace MakerHubAPIV2.Mappers {
    static class JoueurSouperMapper {

        public static JoueurSouperModel ToModel(this JoueurSouperAddDTO dto) {
            return new JoueurSouperModel {
                IdJoueur = dto.IdJoueur,
                IdSouper = dto.IdSouper,
                NbReservations = dto.NbReservations,
                Token = dto.Token
            };
        }

    }
}
