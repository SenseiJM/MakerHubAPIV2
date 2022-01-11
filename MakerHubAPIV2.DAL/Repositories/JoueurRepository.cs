using MakerHubAPIV2.DAL.Entities;
using System.Linq;

namespace MakerHubAPIV2.DAL.Repositories {
    public class JoueurRepository {

        private CTTDBContext _context;

        public JoueurRepository(CTTDBContext context) {
            _context = context;
        }

        public int Create(Joueur j) {
            _context.Add(j);
            _context.SaveChanges();
            return j.Id;
        }

        public Joueur GetByID(int id) {
            return _context.Joueurs.FirstOrDefault(j => j.Id == id);
        }

        public Joueur GetByMail(string mail) {
            return _context.Joueurs.FirstOrDefault(j => j.Email == mail);
        }

    }
}
