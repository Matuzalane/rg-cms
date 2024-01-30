using RgCms.Api.Models;

namespace RgCms.Api.Services;

public static class PontoDeInteresseService
{
    static List<PontoDeInteresse> PontosDeInteresse { get; }
    static int nextId = 3;
    static PontoDeInteresseService()
    {
        PontosDeInteresse = new List<PontoDeInteresse>
        {
            new PontoDeInteresse {
                Id = 1,
                Nome = "Exemplo",
                Categoria = CategoriaEnum.Gastronomia,
                SubCategoria = SubCategoriaEnum.Delivery,
                Endereco = "Rua Exemplo, 123",
                Bairro = "Bairro Exemplo",
                Cep = "12345-678",
                Latitude = 123.456f,
                Longitude = -45.678f,
                Telefone = 1234567890,
                WhatsApp = true,
                TelefoneFixo = 987654321,
                Email = "exemplo@email.com",
                RedesSociais = new List<RedeSocial>
                {
                    new RedeSocial { Nome = RedeSocialEnum.Facebook, Url = "http://facebook.com/exemplo" },
                    new RedeSocial { Nome = RedeSocialEnum.Instagram, Url = "http://instagram.com/exemplo" }
                },
                Fotos = new List<Foto>
                {
                    new Foto { Titulo = "Foto1", Url = "http://exemplo.com/foto1.jpg" },
                    new Foto { Titulo = "Foto2", Url = "http://exemplo.com/foto2.jpg" }
                }
            },
            new PontoDeInteresse {
                Id = 2,
                Nome = "Exemplo 2",
                Categoria = CategoriaEnum.Gastronomia,
                SubCategoria = SubCategoriaEnum.Churrascaria,
                Endereco = "Rua Exemplo 2, 123",
                Bairro = "Bairro Exemplo 2",
                Cep = "12345-678",
                Latitude = 123.456f,
                Longitude = -45.678f,
                Telefone = 1234567890,
                WhatsApp = true,
                TelefoneFixo = 987654321,
                Email = "exemplo2@email.com",
                RedesSociais = new List<RedeSocial>
                {
                    new RedeSocial { Nome = RedeSocialEnum.Facebook, Url = "http://facebook.com/exemplo2" },
                    new RedeSocial { Nome = RedeSocialEnum.Instagram, Url = "http://instagram.com/exemplo2" }
                },
                Fotos = new List<Foto>
                {
                    new Foto { Titulo = "Foto1", Url = "http://exemplo2.com/foto1.jpg" },
                    new Foto { Titulo = "Foto2", Url = "http://exemplo2.com/foto2.jpg" }
                }
            }
        };
    }

    public static List<PontoDeInteresse> GetAll() => PontosDeInteresse;

    public static PontoDeInteresse Get(int id) => PontosDeInteresse.FirstOrDefault(p => p.Id == id);

    public static void Add(PontoDeInteresse pontodeinteresse)
    {
        pontodeinteresse.Id = nextId++;
        PontosDeInteresse.Add(pontodeinteresse);
    }

    public static void Delete(int id)
    {
        var pontodeinteresse = Get(id);
        if(pontodeinteresse is null)
            return;

        PontosDeInteresse.Remove(pontodeinteresse);
    }

    public static void Update(PontoDeInteresse pontodeinteresse)
    {
        var index = PontosDeInteresse.FindIndex(p => p.Id == pontodeinteresse.Id);
        if(index == -1)
            return;

        PontosDeInteresse[index] = pontodeinteresse;
    }
}