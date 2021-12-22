﻿using MakerHubAPIV2.DAL.Entities;

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

    }
}