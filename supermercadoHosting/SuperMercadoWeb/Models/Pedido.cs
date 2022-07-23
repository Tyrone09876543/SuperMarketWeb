using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMercadoWeb.Models
{
    public partial class Pedido
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
        public double PrecioTotal { get; set; }
    }
}
