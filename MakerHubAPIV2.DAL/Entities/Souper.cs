using MakerHubAPIV2.DAL.Enums;
using System;
using System.Collections.Generic;

namespace MakerHubAPIV2.DAL.Entities {
    public class Souper {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TypeSouper TypeSouper { get; set; }
        public decimal PrixAffilies { get; set; }
        public decimal PrixExternes { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public int NombreMax { get; set; }
        public string Titre { get; set; }
        public IEnumerable<JoueurSouper> JoueurSoupers { get; set; }

    }
}
