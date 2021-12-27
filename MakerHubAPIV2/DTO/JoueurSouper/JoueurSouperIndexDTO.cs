namespace MakerHubAPIV2.DTO.JoueurSouper {
    public class JoueurSouperIndexDTO {

        public int Id { get; set; }
        public int IdSouper { get; set; }
        public int IdJoueur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int NbCommande { get; set; }

    }
}
