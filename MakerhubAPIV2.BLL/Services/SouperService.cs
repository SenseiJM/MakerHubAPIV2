using MakerhubAPIV2.BLL.Mappers;
using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MakerhubAPIV2.BLL.Services {
    public class SouperService {

        private readonly SouperRepository _souperRepository;

        public SouperService(SouperRepository souperRepository) {
            _souperRepository = souperRepository;
        }

        public int Create(SouperModel model) {
            return _souperRepository.Create(model.ToEntity());
        }

        public SouperModel GetByID(int id) {
            return _souperRepository.GetByID(id).ToModel();
        }

        public IEnumerable<SouperModel> GetAll() {
            return _souperRepository.GetAll().Select(s => s.ToModel());
        }

    }
}
