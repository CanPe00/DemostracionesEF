using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Producto")]
    public class Producto
    {
        public int ProductoId { get; set; }

        [Column(TypeName = "varchar")] //Indicamos el tipo de dato en SQL Server
        [StringLength(50)] //Long de la cadena
        [Required] //no acepta nulls / es obligatorio
        public string Nombre { get; set; }

        [Column(TypeName = "money")]
        public decimal Precio { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1)]
        public string LineaProducto { get; set; }


        [ForeignKey(nameof(categoria))]
        public int CategoriaId { get; set; }

        #region Propiedades de navegacion
        //[ForeignKey("CategoriaId")]
        public Categoria categoria { get; set; }
        #endregion

    }
}
