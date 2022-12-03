using ApexLegendsFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Final_v1.Data;
using ApexLegendsFinal.Models.charater;

namespace ApexLegendsFinal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly FinalDatabase _context;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Legends()
        {
            return View();
        }

        public IActionResult Weapons()
        {
            return View();
        }

        public IActionResult Maps()
        {
            return View();
        }

        public IActionResult Ranked()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //testing 

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_context.GetCharacter());
        //}
        //[HttpDelete("id")]
        //public IActionResult GetByCharacterId(int id)
        //{
        //    var characters = _context.GetByCharacterId(id);
        //    if (characters.ToList().Count() == 0)
        //    {
        //        return NotFound();
        //    }
        //    if (characters != null)
        //    {
        //        return Ok(characters);
        //    }
        //    return NotFound();
        //}
        //[HttpPost]
        //public IActionResult AddNewCharacters(Characters characters)
        //{
        //    try
        //    {
        //        _context.AddNewCharacter(characters);
        //    }
        //    catch (Exception e)
        //    {
        //        return new StatusCodeResult(500);
        //    }
        //    return Created("", characters);
        //}

        //[HttpPut]
        //public IActionResult UpdateCharacters(Characters characters)
        //{
        //    var result = _context.UpdatecCharacters(characters);
        //    if (result == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(characters);
        //}

        //[HttpDelete]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Finalcontext))]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]

        //public IActionResult DeleteCharacters(string Name)
        //{
        //    try
        //    {
        //        var deletedcharacters = _context.DeleteCharactersDatabase(Name);
        //        if (deletedcharacters == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(deletedcharacters);
        //    }
        //    catch (Exception)
        //    {
        //        return new StatusCodeResult(500);
        //    }   
        //}
    }
}