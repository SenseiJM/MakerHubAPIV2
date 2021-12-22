using MakerHubAPIV2.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MakerHubAPIV2.DAL.Repositories {
    public class SouperRepository {

        private CTTDBContext _context;

        public SouperRepository(CTTDBContext context) {
            _context = context;
        }

        public int Create(Souper souper) {
            _context.Soupers.Add(souper);
            _context.SaveChanges();
            return souper.Id;
        }

        public Souper GetByID(int id) {
            return _context.Soupers.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Souper> GetAll() {
            foreach (Souper souper in _context.Soupers) {
                yield return souper;
            }
        }

    }
}
