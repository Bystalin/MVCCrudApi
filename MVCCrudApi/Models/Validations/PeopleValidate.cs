using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrudApi.Models.Entities
{

    [MetadataType(typeof(MetaData))]
    public partial class people
    {
        //clases selladas
        sealed class MetaData
        {
            [Display(Name = "Nombre")] //texto q se muestra en los mensajes
            [Required]
            [StringLength(100)]
            public string name;

            [Display(Name ="Email")]
            [Required]
            [StringLength(50)]
            public string correo;

        }
    }
}