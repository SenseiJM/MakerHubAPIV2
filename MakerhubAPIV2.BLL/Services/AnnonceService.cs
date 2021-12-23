using MakerhubAPIV2.BLL.Mappers;
using MakerhubAPIV2.BLL.Models;
using MakerHubAPIV2.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MakerhubAPIV2.BLL.Services {
    public class AnnonceService {

        private readonly AnnonceRepository _annonceRepository;

        public AnnonceService(AnnonceRepository annonceRepository) {
            _annonceRepository = annonceRepository;
        }

        public int Create(AnnonceModel model) {
            return _annonceRepository.Create(model.ToEntity());
        }

        public IEnumerable<AnnonceModel> GetAll() {
            return _annonceRepository.GetAll().Select(a => a.ToModel());
        }

        public AnnonceModel GetById(int id) {
            return _annonceRepository.GetByID(id).ToModel();
        }

        public bool Update(AnnonceModel model, int id) {
            return _annonceRepository.Update(model.ToEntity(), id);
        }

        public bool Delete(int id) {
            return _annonceRepository.Delete(id);
        }
    }
}
