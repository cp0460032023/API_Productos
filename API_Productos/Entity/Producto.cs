using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Productos.Entity
{
    // Clase que representa la entidad Productos en la base de datos
    public class Productos
    {
        // Propiedad clave primaria con generación automática de identidad
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Propiedad requerida para el nombre del producto
        [Required]
        public string Nombre { get; set; }

        // Propiedad que almacena el precio con precisión decimal
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }

        // Propiedad que representa la cantidad de productos en stock
        public int Stock { get; set; }
    }
}



