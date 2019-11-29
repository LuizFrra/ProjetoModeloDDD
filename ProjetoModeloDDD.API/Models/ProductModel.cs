using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.API.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "O Nome É Necessário.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} Caratéres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} Caractéres.")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999")]
        [Required(ErrorMessage = "Valor É Necessário.")]
        public decimal Value { get; set; }

        public int ClientIds { get; set; }

        public bool Available { get; set; }

        public virtual ClientModel Client { get; set; }
    }
}
