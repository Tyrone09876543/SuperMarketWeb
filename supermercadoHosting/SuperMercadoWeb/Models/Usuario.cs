using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMercadoWeb.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime Fnacimiento { get; set; }
    }
}
