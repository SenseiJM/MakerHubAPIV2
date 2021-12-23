using MakerHubAPIV2.Validators;
using System.ComponentModel.DataAnnotations;

namespace MakerHubAPIV2.DTO.Annonce {
    public class AnnonceAddDTO {

        [Required]
        [MaxLength(255)]
        public string Titre { get; set; }

        public string Blob { get; set; }

        ////Taille de 2Mo
        //[MaxLength(2 * 1024 * 1024)]
        public byte[] Photo { get; set; }

        [MimeTypeValidator("image/jpg", "image/jpeg", "image/svg", "image/png")]
        public string MimeType { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

    }
}
