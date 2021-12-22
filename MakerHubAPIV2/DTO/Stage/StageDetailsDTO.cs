using System;

namespace MakerHubAPIV2.DTO.Stage {
    public class StageDetailsDTO {

        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public decimal PrixAffilies { get; set; }
        public decimal PrixExternes { get; set; }
        public string Entraineur { get; set; }
        public int NombreMax { get; set; }
        public string Description { get; set; }
        public string ClassementMaximum { get; set; }
        public string ClassementMinimum { get; set; }

    }
}
