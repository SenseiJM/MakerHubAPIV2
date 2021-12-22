using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.JoueurSouper;
using MakerHubAPIV2.Mappers;
using Microsoft.AspNetCore.Mvc;

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

    }
}
