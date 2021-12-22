using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.Souper;
using MakerHubAPIV2.Mappers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MakerHubAPIV2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SouperController : ControllerBase {

        private SouperService _souperService;

        public SouperController(SouperService souperService) {
            _souperService = souperService;
        }

        [HttpPost]
        public IActionResult Create(SouperAddDTO dto) {
            return Ok(_souperService.Create(dto.ToModel()));
        }

        [HttpGet("ByID/{id}")]
        public IActionResult GetByID(int id) {
            return Ok(_souperService.GetByID(id).ToDetailsDTO());
        }

        [HttpGet("All")]
        public IActionResult GetAll() {
            return Ok(_souperService.GetAll().Select(s => s.ToIndexDTO()));
        }

    }
}
