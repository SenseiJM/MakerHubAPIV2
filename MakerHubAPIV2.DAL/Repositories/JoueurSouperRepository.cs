﻿using MakerHubAPIV2.DAL.Entities;

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

    }
}
