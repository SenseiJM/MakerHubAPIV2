using System;

namespace MakerHubAPIV2.DTO.Stage {
    public class StageIndexDTO {

        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }

    }
}
