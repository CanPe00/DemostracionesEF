using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }

        [Column(TypeName = "varchar")] 
        [StringLength(50)] 
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public Profesor profesor { get; set; }

        [ForeignKey(nameof(profesor))]
        public int ProfesorId { get; set; }

    }
}
