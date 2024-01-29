using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RgCms.Api.Models;

[Table("PontosDeInteresse")]
public class PontoDeInteresse {
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(160, MinimumLength=2)]
    public string? Nome { get; set; }
    public CategoriaEnum Categoria { get; set; }
    public SubCategoriaEnum SubCategoria { get; set; }
    
    //Informações de Endereço
    [Required]
    public string? Endereco { get; set; }
    [Required]
    public string? Bairro { get; set; }
    [Required]
    [DataType(DataType.PostalCode)]
    public string? Cep { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }

    //Informações de Contato
    [DataType(DataType.PhoneNumber)]
    [DisplayFormat(DataFormatString = "{0:(##) #####-####}", ApplyFormatInEditMode = true)]
    public long Telefone { get; set; }
    public bool WhatsApp { get; set; }

    [DataType(DataType.PhoneNumber)]
    [DisplayFormat(DataFormatString = "{0:(##) ####-####}", ApplyFormatInEditMode = true)]
    public long TelefoneFixo { get; set; }

    [DataType(DataType.EmailAddress)]
    [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Informe um email válido...")]
    public string? Email { get; set; }
    public TipoRedeSocialEnum TipoRedeSocial { get; set; }
    
    [DataType(DataType.Url)]
    public IList<string>? RedesSociais { get; set; }
}