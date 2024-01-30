using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RgCms.Api.Models;

public class Foto {
    [Key]
    public int Id { get; set; }
    [StringLength(100)]
    public string Titulo { get; set; }
    [StringLength(255)]
    public string Url { get; set; }

    [ForeignKey("PontoDeInteresse")]
    public int PontoDeInteresseID { get; set; }
    public PontoDeInteresse PontoDeInteresse { get; set; }
}