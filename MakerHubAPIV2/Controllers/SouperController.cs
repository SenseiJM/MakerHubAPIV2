using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.Souper;
using MakerHubAPIV2.Mappers;
using Microsoft.AspNetCore.Mvc;
using System;
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

            if (dto.Blob != null) {
                string fileExtension = dto.Blob.Split("/", 3)[1].Split(";")[0];
                string base64String = dto.Blob.Split(",")[1];
                byte[] base64 = Convert.FromBase64String(base64String);
                Guid guid = Guid.NewGuid();
                string filePath = "assets/images/" + guid.ToString() + "." + fileExtension;

                System.IO.File.WriteAllBytes("wwwroot/" + filePath, base64);
            }

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

        [HttpGet("image/{id}")]
        public IActionResult GetImage(int id) {
            SouperDetailsDTO dto = _souperService.GetByID(id).ToDetailsDTO();
            if (dto?.Photo is null) {
                return NotFound();
            }

            return File(dto.Photo, "image/png");
        }

    }
}
