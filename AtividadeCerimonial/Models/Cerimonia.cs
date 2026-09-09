using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AtividadeCerimonial.Models;

public class Cerimonia{
    public int Id {get; set;}

    [Required(ErrorMessage = "O campo Noiva é obrigatório!")] //Propreidade de validação do campo Noiva
    public string? Noiva {get; set;}
    
    [Required(ErrorMessage ="O campo Noivo é obrigatório!")] //Propreidade de validação do campo Noivo
    public string? Noivo {get; set;}

    [Required(ErrorMessage ="O campo Data é obrigatório!")] //Propreidade de validação do campo Data
    [DataType(DataType.Date)] //Define o tipo de dado como data
    public DateTime Data {get; set;}

    [Required(ErrorMessage ="O campo Local é obrigatório!")] //Propreidade de validação do campo Local
    public string Local {get; set;}

    [Range(1,100, ErrorMessage ="Informe uma quantidade válida.")]
    [Display(Name = "Quantidade de Convidados")] //Propreidade de validação do campo Quantidade de Convidados
    public int QuantidadeConvidados {get; set;}
}