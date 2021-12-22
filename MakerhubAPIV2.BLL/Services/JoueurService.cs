using MakerhubAPIV2.BLL.Mappers;
using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Repositories;

namespace MakerhubAPIV2.BLL.Services {
    public class JoueurService {

        private readonly JoueurRepository _joueurRepository;

        public JoueurService(JoueurRepository joueurRepository) {
            _joueurRepository = joueurRepository;
        }

        public int Create(JoueurModel model) {
            return _joueurRepository.Create(model.ToEntity());
        }

    }
}
