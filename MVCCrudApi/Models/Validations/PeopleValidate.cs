using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrudApi.Models
{

    [MetadataType(typeof(people.MetaData))]
    public partial class people
    {
        //clases selladas
        sealed class MetaData
        {
            [Display(Name = "Nombre")] //texto q se muestra en los mensajes
            [Required]
            [StringLength(5)]
            public string name;
        }
    }
}