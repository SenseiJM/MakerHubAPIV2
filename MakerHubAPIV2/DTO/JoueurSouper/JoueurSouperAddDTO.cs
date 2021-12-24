using System.ComponentModel.DataAnnotations;

namespace MakerHubAPIV2.DTO.JoueurSouper {
    public class JoueurSouperAddDTO {

        [Required]
        public int IdSouper { get; set; }

        [Required]
        public int IdJoueur { get; set; }

        [Required]
        public int NbReservations { get; set; }

        [Required]
        public string Token { get; set; }

    }
}
