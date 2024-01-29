using System.ComponentModel.DataAnnotations;

public enum CategoriaEnum {
    Gastronomia,
    Atrativos,
    Transporte,

    [Display(Name = "Unidades de Saúde")]
    UnidadesDeSaude,
    
    [Display(Name = "Meios de Hospedagem")]
    MeiosDeHospedagem,
    Entretenimento,

    [Display(Name = "Unidades Administrativas")]
    UnidadesAdministrativas,

    [Display(Name = "Unidades de Assistência Social")]
    UnidadesDeAssistenciaSocial,

    [Display(Name = "Agências de Turismo")]
    AgenciasDeTurismo,

    [Display(Name = "Unidades de Educação")]
    UnidadesDeEducacao
}