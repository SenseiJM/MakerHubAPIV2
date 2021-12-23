using MakerHubAPIV2.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MakerHubAPIV2.DAL.Repositories {
    public class AnnonceRepository {

        private CTTDBContext _context;

        public AnnonceRepository(CTTDBContext context) {
            _context = context;
        }

        public int Create(Annonce a) {
            _context.Annonces.Add(a);
            _context.SaveChanges();
            return a.Id;
        }

        public bool Update(Annonce a, int id) {
            Annonce old = _context.Annonces.FirstOrDefault(a => a.Id == id);
            if (old != null) {
                old.Titre = a.Titre;
                old.Description = a.Description;
                old.Photo = a.Photo;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Annonce> GetAll() {
            return _context.Annonces;
        }

        public Annonce GetByID(int id) {
            return _context.Annonces.FirstOrDefault(a => a.Id == id);
        }

        public bool Delete(int id) {
            Annonce a = _context.Annonces.FirstOrDefault(a => a.Id == id);

            if (a != null) {
                _context.Annonces.Remove(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
