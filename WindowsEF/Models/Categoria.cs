using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Categoria")] //Cambiamos el nombre de la tabla
    public class Categoria
    {
        public int Id { get; set; } //usa la convension de EF para indicar que en SQL la columna id sea clave principal y autonumerica


        [Column(TypeName = "varchar")] //Indicamos el tipo de dato en SQL Server
        [StringLength(50)] //Long de la cadena
        [Required] //no acepta nulls / es obligatorio
        public string Nombre { get; set; }

        #region Propiedades de navegacion
        public List<Producto> Productos { get; set; }
        #endregion  

    }
}
