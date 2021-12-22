using MakerhubAPIV2.BLL.Mappers;
using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Repositories;

namespace MakerhubAPIV2.BLL.Services {
    public class JoueurSouperService {

        private readonly JoueurSouperRepository _joueurSouperRepository;

        public JoueurSouperService(JoueurSouperRepository joueurSouperRepository) {
            _joueurSouperRepository = joueurSouperRepository;
        }

        public int CreateInscription(JoueurSouperModel model) {
            return _joueurSouperRepository.CreateInscription(model.ToEntity());
        }

    }
}
