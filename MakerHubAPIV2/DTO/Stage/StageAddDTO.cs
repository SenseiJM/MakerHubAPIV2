using System;
using System.ComponentModel.DataAnnotations;

namespace MakerHubAPIV2.DTO.Stage {
    public class StageAddDTO {

        [Required]
        [MaxLength(100)]
        public string Titre { get; set; }

        [Required]
        public DateTime DateDebut { get; set; }

        [Required]
        public DateTime DateFin { get; set; }

        [Required]
        [MaxLength(5)]
        public string HeureDebut { get; set; }
        
        [Required]
        [MaxLength(5)]
        public string HeureFin { get; set; }

        [Required]
        public decimal PrixAffilies { get; set; }
        
        [Required]
        public decimal PrixExternes { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Entraineur { get; set; }
        
        public int NombreMax { get; set; }
        
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(2)]
        public string ClassementMaximum { get; set; }
        
        [Required]
        [MaxLength(2)]
        public string ClassementMinimum { get; set; }

    }
}
