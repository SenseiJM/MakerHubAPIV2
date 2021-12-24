using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.Joueur;
using MakerHubAPIV2.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace MakerHubAPIV2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class JoueurController : ControllerBase {

        private readonly JoueurService _joueurService;

        public JoueurController(JoueurService joueurService) {
            _joueurService = joueurService;
        }

        [HttpPost]
        public IActionResult Create(JoueurAddDTO dto) {
            return Ok(_joueurService.Create(dto.ToModel()));
        }

        [HttpGet("ByID/{id}")]
        public IActionResult GetByID(int id) {
            return Ok(_joueurService.GetByID(id).ToDetailsDTO());
        }

    }
}
