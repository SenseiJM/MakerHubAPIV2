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

        public bool Update(Souper souper, int id) {
            Souper old = _context.Soupers.FirstOrDefault(s => s.Id == id);
            if (old != null) {
                old.Titre = souper.Titre;
                old.TypeSouper = souper.TypeSouper;
                old.Description = souper.Description;
                old.NombreMax = souper.NombreMax;
                old.Date = souper.Date;
                old.PrixExternes = souper.PrixExternes;
                old.PrixAffilies = souper.PrixAffilies;
                old.Photo = souper.Photo;
                return true;
            }
            return false;
        }

        public bool Delete(int id) {
            Souper s = _context.Soupers.FirstOrDefault(s => id == s.Id);

            if (s != null) {
                _context.Soupers.Remove(s);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
