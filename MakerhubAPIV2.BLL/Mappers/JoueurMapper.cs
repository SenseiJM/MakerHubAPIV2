using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Entities;

namespace MakerhubAPIV2.BLL.Mappers {
    static class JoueurMapper {

        public static Joueur ToEntity(this JoueurModel model) {
            return new Joueur {
                Email = model.Email,
                HeureDepartDames = model.HeureDepartDames,
                HeureDepartHommes = model.HeureDepartHommes,
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
