using RgCms.Api.Models;
using RgCms.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace RgCms.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PontoDeInteresseController : ControllerBase
{
    PontoDeInteresseService _service;

    public PontoDeInteresseController(PontoDeInteresseService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<PontoDeInteresse> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<PontoDeInteresse> GetById(int id)
    {
        var pontoDeInteresse = _service.GetById(id);

        if(pontoDeInteresse is not null)
        {
            return pontoDeInteresse;
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost]
    public IActionResult Create(PontoDeInteresse newPontoDeInteresse)
    {
        var pontoDeInteresse = _service.Create(newPontoDeInteresse);
        return CreatedAtAction(nameof(GetById), new { id = pontoDeInteresse!.Id }, pontoDeInteresse);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, PontoDeInteresse altPontoDeInteresse)
    {
        var pontoDeInteresseToUpdate = _service.GetById(id);

        if(pontoDeInteresseToUpdate is null)
            return NotFound();
        
        _service.Update(altPontoDeInteresse);
        return NoContent();  
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pontoDeInteresse = _service.GetById(id);

        if(pontoDeInteresse is null)
            return NotFound();
        
        _service.DeleteById(id);
        return Ok();
    }
}