using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.Annonce;
using Microsoft.AspNetCore.Mvc;
using MakerHubAPIV2.Mappers;
using System.Linq;

namespace MakerHubAPIV2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AnnonceController : ControllerBase {

        private readonly AnnonceService _annonceService;

        public AnnonceController(AnnonceService annonceService) {
            _annonceService = annonceService;
        }

        [HttpPost]
        public IActionResult Create(AnnonceAddDTO dto) {
            return Ok(_annonceService.Create(dto.ToModel()));
        }

        [HttpGet("All")]
        public IActionResult GetAll() {
            return Ok(_annonceService.GetAll().Select(a => a.ToIndexDTO()));
        }

        [HttpGet("ByID/{id}")]
        public IActionResult GetByID(int id) {
            return Ok(_annonceService.GetById(id).ToDetailsDTO());
        }

        [HttpPut]
        public IActionResult Update(int id, AnnonceAddDTO dto) {
            return Ok(_annonceService.Update(dto.ToModel(), id));
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            return Ok(_annonceService.Delete(id));
        }

    }
}
