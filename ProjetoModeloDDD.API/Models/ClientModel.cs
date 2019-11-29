using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.API.Models
{
    public class ClientModel
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "O Nome É Necessário.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} Caratéres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} Caractéres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O SobreNome É Necessário.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} Caratéres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} Caractéres.")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Email Inválido.")]
        [Required(ErrorMessage = "Email É Necessário.")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }

        public bool Active { get; set; }

        public ICollection<ProductModel> Products { get; set; }
    }
}
