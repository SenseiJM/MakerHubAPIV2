using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.Joueur;
using MakerHubAPIV2.DTO.JoueurSouper;
using MakerHubAPIV2.Mappers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MakerHubAPIV2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class JoueurSouperController : ControllerBase {

        private readonly JoueurSouperService _joueurSouperService;

        public JoueurSouperController(JoueurSouperService joueurSouperService) {
            _joueurSouperService = joueurSouperService;
        }

        [HttpPost]
        public IActionResult CreateInscription(JoueurSouperAddDTO dto) {
            return Ok(_joueurSouperService.CreateInscription(dto.ToModel()));
        }

        [HttpGet("BySouperID/{id}")]
        public IActionResult GetBySouperID(int id) {
            return Ok(_joueurSouperService.GetBySouperID(id).Select(js => js.ToIndexDTO()));
        }

        //Voir toutes les réservations d'un événement précis

        //Voir toutes les réservations d'un utilisateur

        

        //Annuler une réservation

        //Modifier le nombre de personnes dans une réservation
        /// Son token correspond à la réservation ?
        /// Admin + Utilisateur peuvent supprimer
        /// Règle Business : Réservation passée (event fini) -> pas moyen de modifier

    }
}
