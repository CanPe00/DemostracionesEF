using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Materia")]
    public class Materia
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")] 
        [StringLength(50)] 
        [Required] 
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Programa { get; set; }

        
    }
}
