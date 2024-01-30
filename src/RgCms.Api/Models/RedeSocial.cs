using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RgCms.Api.Models;

public class RedeSocial {
    [Key]
    public int Id { get; set; }
    public RedeSocialEnum Nome { get; set; }
    [DataType(DataType.Url)]
    public string Url { get; set; }

    [ForeignKey("PontoDeInteresse")]
    public int PontoDeInteresseID { get; set; }
    public PontoDeInteresse PontoDeInteresse { get; set; }
}