using MakerHubAPIV2.DAL.Enums;
using System;

namespace MakerHubAPIV2.DTO.Souper {
    public class SouperIndexDTO {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TypeSouper TypeSouper { get; set; }
        public string UrlPhoto { get; set; }
        public string Titre { get; set; }

    }
}
