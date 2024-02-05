using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RgCms.Api.Data;
using RgCms.Api.Models;

namespace RgCms.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PontoDeInteresseController : ControllerBase
{
    private readonly RgCmsContext _context;

    public PontoDeInteresseController(RgCmsContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.PontosDeInteresse
                .Include(p => p.RedesSociais)
                .Include(p => p.Fotos)
                .AsNoTracking()
                .ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var pontoDeInteresse = _context.PontosDeInteresse
            .Include(p => p.Fotos) // Incluir a propriedade "fotos"
            .Include(p => p.RedesSociais) // Incluir a propriedade "redesSociais"
            .FirstOrDefault(p => p.Id == id);
;

        if(pontoDeInteresse is null)
            return NotFound();
            
        return Ok(pontoDeInteresse);
    }

    [HttpPost]
    public IActionResult Create(PontoDeInteresse newPontoDeInteresse)
    {
        _context.PontosDeInteresse.Add(newPontoDeInteresse);
        _context.SaveChanges();

        return Ok(CreatedAtAction(nameof(GetById), new { id = newPontoDeInteresse!.Id }, newPontoDeInteresse));
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePontoDeInteresse(int id, PontoDeInteresse altPontoDeInteresse)
    {
        var pontoDeInteresseToUpdate = GetById(id);

        if(pontoDeInteresseToUpdate is null)
            return NotFound();

        _context.Entry(pontoDeInteresseToUpdate).CurrentValues.SetValues(altPontoDeInteresse);

        //_context.PontosDeInteresse.Update(pontoDeInteresseToUpdate);
        _context.Update(pontoDeInteresseToUpdate);
        _context.SaveChanges();

        return Ok(pontoDeInteresseToUpdate); // resolver pendencias na atualização de Fotos e redes sociais
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pontoDeInteresseToDelete = _context.PontosDeInteresse.Find(id);

        if(pontoDeInteresseToDelete is null)
            return NotFound();
        
        _context.PontosDeInteresse.Remove(pontoDeInteresseToDelete);
        _context.SaveChanges();     
        return Ok();

        
    }
}