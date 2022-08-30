using System.ComponentModel.DataAnnotations;

namespace ENQUETEWEB.models{

    public class Resposta{
        [Required(ErrorMessage ="O campo nome deve ser prenchido")]
        public string Nome {get;set;}
        [Required(ErrorMessage ="O campo e-mail deve ser prenchido")]
        [EmailAddress(ErrorMessage ="O campo e-mail não corresponde a um endereço válido")]
        public string Email {get;set;}
        [Required(ErrorMessage ="O campo resposta deve ser prenchido")]
        public bool? Sim {get;set;}
    }

}