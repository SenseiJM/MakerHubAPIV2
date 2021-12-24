using MakerHubAPIV2.DAL.Enums;
using MakerHubAPIV2.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace MakerHubAPIV2.DTO.Souper {
    public class SouperAddDTO {

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TypeSouper TypeSouper { get; set; }

        [Required]
        public decimal PrixAffilies { get; set; }

        [Required]
        public decimal PrixExternes { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

        public byte[] Photo { get; set; }

        [MimeTypeValidator("image/jpg", "image/jpeg", "image/svg", "image/png")]
        public string MimeType { get; set; }
        public string Blob { get; set; }

        [Required]
        public int NombreMax { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titre { get; set; }

    }
}
