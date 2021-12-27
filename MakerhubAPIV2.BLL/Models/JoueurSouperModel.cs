namespace MakerhubAPIV2.BLL.Models {
    public class JoueurSouperModel {

        public int IdSouper { get; set; }
        public int IdJoueur { get; set; }
        public int NbReservations { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

    }
}
