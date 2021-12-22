using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.Stage;
using Microsoft.AspNetCore.Mvc;
using MakerHubAPIV2.Mappers;
using System.Linq;

namespace MakerHubAPIV2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StageController : ControllerBase {

        private readonly StageService _stageService;

        public StageController(StageService stageService) {
            _stageService = stageService;
        }

        [HttpPost]
        public IActionResult Create(StageAddDTO dto) {
            return Ok(_stageService.Create(dto.ToModel()));
        }

        [HttpGet("ByID/{id}")]
        public IActionResult GetByID(int id) {
            return Ok(_stageService.GetByID(id).ToDetailsDTO());
        }

        [HttpGet("All")]
        public IActionResult GetAll() {
            return Ok(_stageService.GetAll().Select(s => s.ToIndexDTO()));
        }
    }
}
