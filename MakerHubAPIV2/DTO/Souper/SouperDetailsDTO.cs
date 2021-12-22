using MakerHubAPIV2.DAL.Enums;
using System;

namespace MakerHubAPIV2.DTO.Souper {
    public class SouperDetailsDTO {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TypeSouper TypeSouper { get; set; }
        public decimal PrixAffilies { get; set; }
        public decimal PrixExternes { get; set; }
        public string Description { get; set; }
        public string UrlPhoto { get; set; }
        public int NombreMax { get; set; }
        public string Titre { get; set; }

    }
}
