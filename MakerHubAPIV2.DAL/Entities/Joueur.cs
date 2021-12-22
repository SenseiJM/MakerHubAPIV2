using System.Collections.Generic;

namespace MakerHubAPIV2.DAL.Entities {
    public class Joueur {

        public int Id { get; set; }
        public int? IdAFTT { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string IdentifiantConnexion { get; set; }
        public string MotDePasse { get; set; }
        public int? IdEquipeHommes { get; set; }
        public int? IdEquipeDames { get; set; }
        public string HeureDepartHommes { get; set; }
        public string HeureDepartDames { get; set; }
        public IEnumerable<JoueurSouper> JoueurSoupers { get; set; }


    }
}
