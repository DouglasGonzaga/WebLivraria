using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLivraria.Models
{
    public class Livro
    {//Imagem da capa, título, ISBN, Editora, Autor, Sinopse, data de publicação
        [Key]
        public int Id { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Título deve ser informado!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 100 caracteres!")]
        public string Titulo { get; set; }
        [Display(Name = "ISBN")]
        [Required(ErrorMessage = "ISBN deve ser informado!")]
        public ulong Isbn { get; set; }
        [Required(ErrorMessage = "Editora deve ser informada!")]
        public string Editora { get; set; }
        [Required(ErrorMessage = "Sinopse deve ser informada!")]
        public string Sinopse { get; set; }
        [Required(ErrorMessage = "Data deve ser informada!")]
        [Display(Name = "Data de Publicação")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataPublicacao { get; set; }
    }
}
