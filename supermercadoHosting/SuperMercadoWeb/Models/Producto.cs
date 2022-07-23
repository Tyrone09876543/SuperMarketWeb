using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SuperMercadoWeb.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingrese un Precio Mayor a Cero")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese una Catidad Mayor o igual a Cero")]
        public int Cantidad { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Ingrese una categoria")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Tiene que seleccionar una imagen")]
        public byte[] Imagen { get; set; }
    }
}
