using System.ComponentModel.DataAnnotations;

namespace MakerHubAPIV2.DTO.Joueur {
    public class JoueurAddDTO {

        public int? IdAFTT { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
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
