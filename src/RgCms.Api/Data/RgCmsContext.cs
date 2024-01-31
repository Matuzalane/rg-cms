using Microsoft.EntityFrameworkCore;
using RgCms.Api.Models;

namespace RgCms.Api.Data;

public class RgCmsContext : DbContext
{
    public RgCmsContext (DbContextOptions<RgCmsContext> options)
        : base(options)
    {
    }

    public DbSet<PontoDeInteresse> PontosDeInteresse => Set<PontoDeInteresse>();
    public DbSet<Foto> Fotos => Set<Foto>();
    public DbSet<RedeSocial> RedesSociais => Set<RedeSocial>();
}