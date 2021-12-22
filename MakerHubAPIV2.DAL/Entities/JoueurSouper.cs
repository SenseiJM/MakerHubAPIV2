namespace MakerHubAPIV2.DAL.Entities {
    public class JoueurSouper {

        public int Id { get; set; }
        public int IdSouper { get; set; }
        public int IdJoueur { get; set; }
        public int NbReservations { get; set; }
        public Joueur Joueur { get; set; }
        public Souper Souper { get; set; }

    }
}
