using Fansub.DataAccesLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fansub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase

    {
        Context ct = new Context();
        [HttpGet]
        public IActionResult GetList()
        {
            var getlist = ct.Animes.ToList();
            return Ok(getlist);
        }
        [HttpPost]
        public IActionResult AnimeAdd(Anime anime)
        {
            var addanime = ct.Animes.Add(anime);
            ct.SaveChanges();
            return Ok(addanime);
        }

        [HttpDelete("{id}")]
        public IActionResult AnimeDelete(int id)
        {
            var deleteanime = ct.Animes.Find(id);
            ct.Remove(deleteanime);
            ct.SaveChanges();
            return Ok();

        }
        [HttpPut]
        public IActionResult AnimeUpdate(Anime anime)
        {
            var emp = ct.Find<Anime>(anime.ID);
            if (emp == null)
            {
                return NotFound();

            }
            else
            {
                emp.Name = anime.Name;
                ct.Update(emp);
                ct.SaveChanges();
                return Ok();

            }
        }
    }
}

