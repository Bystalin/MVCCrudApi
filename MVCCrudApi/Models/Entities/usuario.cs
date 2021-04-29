namespace MVCCrudApi.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuario")]
    public partial class usuario
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string usuarioced { get; set; }

        public string password { get; set; }

        public string correo { get; set; }

        public DateTime fechaN { get; set; }
    }
}
