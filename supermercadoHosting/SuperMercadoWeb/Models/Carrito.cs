using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMercadoWeb.Models
{
    public partial class Carrito
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
    }
}
