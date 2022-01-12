using MakerhubAPIV2.BLL.Mappers;
using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MakerhubAPIV2.BLL.Services {
    public class JoueurSouperService {

        private readonly JoueurSouperRepository _joueurSouperRepository;
        private readonly JoueurService _joueurService;
        private readonly SouperService _souperService;

        public JoueurSouperService(JoueurSouperRepository joueurSouperRepository, JoueurService joueurService, SouperService souperService) {
            _joueurSouperRepository = joueurSouperRepository;
            _joueurService = joueurService;
            _souperService = souperService;
        }

        public int CreateInscription(JoueurSouperModel model) {

            JoueurModel j = _joueurService.GetByMail(model.Email);

            //Prévu que le token soit l'email. A Modifier dans les versions futures !
            if (j is null) {
                throw new ArgumentException("Wrong token");
            }

            //Éviter les réservations à des soupers déjà terminés
            if (_souperService.GetByID(model.IdSouper).Date <= DateTime.Now) {
                throw new ArgumentException("Les inscriptions pour ce souper sont fermées");
            }
            //ajouter idJoueur à model
            model.IdJoueur = j.Id;
            return _joueurSouperRepository.CreateInscription(model.ToEntity());
        }

        public IEnumerable<JoueurSouperModel> GetBySouperID(int id) {
            return _joueurSouperRepository.GetBySouperID(id).Select(js => js.ToModel(_joueurService.GetByID(js.Id).ToEntity()));
        }

        //Si je supprime un souper, qu'est-ce qu'il se passe ? -> Delete en cascade

        //Si modifie un souper, est-ce que je préviens les inscrits ? OUI. Comment ? MAIL

        //Si je supprime un joueur, que faire de l'inscription -> Supprime l'inscription

        //Qui modifie le souper ? -> User + Admin

        //Si je suis complet, et que quelq'un veut rajouter un souper ?

        // 

    }
}
