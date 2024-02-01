using RgCms.Api.Models;
using RgCms.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace RgCms.Api.Services;

public class PontoDeInteresseService
{
    private readonly RgCmsContext _context;

    public PontoDeInteresseService(RgCmsContext context)
    {
        _context = context;
    }

    public IEnumerable<PontoDeInteresse> GetAll()
    {
        return _context.PontosDeInteresse
                .Include(p => p.RedesSociais)
                .Include(p => p.Fotos)
                .AsNoTracking()
                .ToList();
    }

    public PontoDeInteresse GetById(int id)
    {
        return _context.PontosDeInteresse
            .Include(p => p.RedesSociais)
            .Include(p => p.Fotos)
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id);
    }

    public PontoDeInteresse Create(PontoDeInteresse newPontoDeInteresse)
    {
        _context.PontosDeInteresse.Add(newPontoDeInteresse);
        _context.SaveChanges();

        return newPontoDeInteresse;
    }

    public void Update(int pontoDeInteresseId, PontoDeInteresse alterPontoDeInteresse)
    {
        var pontoDeInteresseToUpdate = _context.PontosDeInteresse.Find(pontoDeInteresseId);

        if (pontoDeInteresseToUpdate is null)
            throw new InvalidOperationException("O ponto de interesse informado não existe.");

        pontoDeInteresseToUpdate = alterPontoDeInteresse;

        _context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var pontoDeInteresseToDelete = _context.PontosDeInteresse.Find(id);
        if (pontoDeInteresseToDelete is null)
            throw new InvalidOperationException("O ponto de interesse informado não existe.");
        
        _context.PontosDeInteresse.Remove(pontoDeInteresseToDelete);
        _context.SaveChanges();     
    }
}