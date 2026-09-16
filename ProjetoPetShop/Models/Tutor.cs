using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoPetShop.Models
{
    public class Tutor
    {
        /*
        create table Tutor(
        id_tutor int primary key auto_increment,
        nome varchar(67) not null,
        telefone varchar(15) not null,
        email varchar(49) not null
        );

        */
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O telefone é obrigatório")]
        public string telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string email { get; set; }
    }
}
