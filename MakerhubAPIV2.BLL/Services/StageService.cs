using MakerhubAPIV2.BLL.Mappers;
using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MakerhubAPIV2.BLL.Services {
    public class StageService {

        private readonly StageRepository _stageRepository;

        public StageService(StageRepository stageRepository) {
            _stageRepository = stageRepository;
        }

        public int Create(StageModel model) {
            return _stageRepository.Create(model.ToEntity());
        }

        public StageModel GetByID(int id) {
            return _stageRepository.GetByID(id).ToModel();
        }

        public IEnumerable<StageModel> GetAll() { 
            return _stageRepository.GetAll().Select(s => s.ToModel());
        }
    }
}
