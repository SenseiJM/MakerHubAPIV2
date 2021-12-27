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
            return _souperRepository.GetAll().Select(s => s.ToModel()).OrderByDescending(s => s.Date);
        }

        public bool Update(SouperModel model, int id) {
            return _souperRepository.Update(model.ToEntity(), id);
        }

        public bool Delete(int id) {
            return _souperRepository.Delete(id);
        }

    }
}
