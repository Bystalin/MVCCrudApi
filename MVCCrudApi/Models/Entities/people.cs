namespace MVCCrudApi.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class people
    {
        public int id { get; set; }

        public string name { get; set; }

        public int age { get; set; }
        public string correo { get; set; }
    }
}
