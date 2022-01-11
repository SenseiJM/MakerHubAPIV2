using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DTO.Annonce;
using Microsoft.AspNetCore.Mvc;
using MakerHubAPIV2.Mappers;
using System.Linq;
using System;

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

            if (dto.Blob != null) {
                string fileExtension = dto.Blob.Split("/", 3)[1].Split(";")[0];
                string base64String = dto.Blob.Split(",")[1];
                byte[] base64 = Convert.FromBase64String(base64String);
                Guid guid = Guid.NewGuid();
                string filePath = "assets/images/" + guid.ToString() + "." + fileExtension;

                System.IO.File.WriteAllBytes("wwwroot/" + filePath, base64);
            }


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

        [HttpPut("{id}")]
        public IActionResult Update(int id, AnnonceAddDTO dto) {
            return Ok(_annonceService.Update(dto.ToModel(), id));
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            return Ok(_annonceService.Delete(id));
        }

        [HttpGet("image/{id}")]
        public IActionResult GetImage(int id) {
            AnnonceDetailsDTO dto = _annonceService.GetById(id).ToDetailsDTO();
            if (dto?.Photo is null) {
                return NotFound();
            }

            return File(dto.Photo, "image/png");
        }

    }
}
