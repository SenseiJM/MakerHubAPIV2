using MakerhubAPIV2.BLL.Mappers;
using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Repositories;
using System;

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
            //Prévu que le token soit l'email. A Modifier dans les versions futures !
            if (model.Token != _joueurService.GetByID(model.IdJoueur).Email) {
                throw new ArgumentException("Wrong token");
            }

            if (_souperService.GetByID(model.IdSouper).Date <= DateTime.Now) {
                throw new ArgumentException("Les inscriptions pour ce souper sont fermées");
            }

            return _joueurSouperRepository.CreateInscription(model.ToEntity());
        }

    }
}
