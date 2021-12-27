using MakerHubAPIV2.DAL.Entities;
using System.Collections.Generic;

namespace MakerHubAPIV2.DAL.Repositories {
    public class JoueurSouperRepository {

        private CTTDBContext _context;

        public JoueurSouperRepository(CTTDBContext context) {
            _context = context;
        }

        public int CreateInscription(JoueurSouper js) {
            _context.JoueurSoupers.Add(js);
            _context.SaveChanges();
            return js.Id;
        }

        public IEnumerable<JoueurSouper> GetBySouperID(int id) {
            foreach (JoueurSouper js in _context.JoueurSoupers) {
                if (js.IdSouper == id) {
                    yield return js;
                }
            }
        }

    }
}
