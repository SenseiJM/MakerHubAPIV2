namespace MakerHubAPIV2.DAL.Entities {
    public class Annonce {

        public int Id { get; set; }
        public string Titre { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }

    }
}
