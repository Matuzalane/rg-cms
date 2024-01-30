using RgCms.Api.Models;
using RgCms.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace RgCms.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PontoDeInteresseController : ControllerBase
{
    public PontoDeInteresseController()
    {
    }

    [HttpGet]
    public ActionResult<List<PontoDeInteresse>> GetAll() => 
        PontoDeInteresseService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<PontoDeInteresse> Get(int id)
    {
        var pontodeinteresse = PontoDeInteresseService.Get(id);

        if (pontodeinteresse == null)
            return NotFound();

        return pontodeinteresse;
    }

    [HttpPost]
    public IActionResult Create(PontoDeInteresse pontodeinteresse)
    {            
        PontoDeInteresseService.Add(pontodeinteresse);
        return CreatedAtAction(nameof(Get), new { id = pontodeinteresse.Id }, pontodeinteresse);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, PontoDeInteresse pontodeinteresse)
    {
        if (id != pontodeinteresse.Id)
        return BadRequest();
           
        var existingPontoDeInteresse = PontoDeInteresseService.Get(id);
        if(existingPontoDeInteresse is null)
            return NotFound();
    
        PontoDeInteresseService.Update(pontodeinteresse);           
    
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pontodeinteresse = PontoDeInteresseService.Get(id);
   
        if (pontodeinteresse is null)
            return NotFound();
        
        PontoDeInteresseService.Delete(id);
    
        return NoContent();
    }
}