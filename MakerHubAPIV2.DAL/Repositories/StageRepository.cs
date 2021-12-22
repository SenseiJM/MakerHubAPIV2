using MakerHubAPIV2.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MakerHubAPIV2.DAL.Repositories {
    public class StageRepository {

        private CTTDBContext _context;

        public StageRepository(CTTDBContext context) {
            _context = context;
        }

        public int Create(Stage s) {
            _context.Stages.Add(s);
            _context.SaveChanges();
            return s.Id;
        }

        public Stage GetByID(int id) {
            return _context.Stages.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Stage> GetAll() {
            return _context.Stages;
        }

    }
}
