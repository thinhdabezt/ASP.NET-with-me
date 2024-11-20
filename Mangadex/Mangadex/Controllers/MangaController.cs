using Mangadex.Data;
using Mangadex.Models;
using Mangadex.Models.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Mangadex.Controllers
{
    [Route("api/Manga")]
    [ApiController]
    public class MangaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public MangaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MangaDTO>> GetMangas()
        {
            return Ok(_context.Mangas.ToList());
        }

        [HttpGet("id", Name = "GetManga")]
        public IActionResult GetManga(int id)
        {
            var manga = _context.Mangas.FirstOrDefault(x => x.Id == id);
            if (manga == null)
            {
                return NotFound();
            }
            return Ok(manga);
        }

        [HttpPost]
        public IActionResult CreateManga(int id, [FromBody] MangaDTO model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            if (model.Title.ToLower() == _context.Mangas.FirstOrDefault(x => x.Id == id).Title.ToLower() != null)
            {
                ModelState.AddModelError("DuplicateManga", "Manga already exist");
            }
            
            model.Id = _context.Mangas.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;

            Manga manga = new()
            {
                Title = model.Title,
                ImageUrl = model.ImageUrl,
                Rating = model.Rating,
                Description = model.Description,
            };

            _context.Mangas.Add(manga);
            _context.SaveChanges();

            return CreatedAtRoute("GetManga", new { id = model.Id }, model);
        }

        [HttpDelete("id", Name = "DeleteManga")]
        public IActionResult Delete(int id)
        {
            var villa = _context.Mangas.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _context.Mangas.Remove(villa);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("id", Name = "UpdateManga")]
        public IActionResult Update(int id, [FromBody] MangaDTO mangaDTO)
        {
            if (mangaDTO == null || id != mangaDTO.Id)
            {
                return BadRequest();
            }
            Manga manga = new()
            {
                Title = mangaDTO.Title,
                ImageUrl = mangaDTO.ImageUrl,
                Rating = mangaDTO.Rating,
                Description = mangaDTO.Description,
            };
            _context.Mangas.Update(manga);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
