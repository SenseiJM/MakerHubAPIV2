namespace MakerhubAPIV2.BLL.Models {
    public class JoueurModel {

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

    }
}
