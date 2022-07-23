using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMercadoWeb.Models
{
    public partial class PedidosItem
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnidad { get; set; }
    }
}
