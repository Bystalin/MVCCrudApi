using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrudApi.Models.Entities
{

    [MetadataType(typeof(MetaData))]
    public partial class usuario
    {

        sealed class MetaData
        {
            [Display(Name = "Usuario")] //texto q se muestra en los mensajes
            [Required]
            [StringLength(10)]
            public string usuarioced;


            [Display(Name = "Contraseña")] //texto q se muestra en los mensajes
            [Required]
            [StringLength(150)]
            public string password;



            [Display(Name = "Nombre")] //texto q se muestra en los mensajes
            [Required]
            [StringLength(200)]
            public string nombre;



            [Display(Name = "Fecha de nacimiento")] //texto q se muestra en los mensajes
            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
            public string fechaN;


            [Display(Name = "Email")]
            [Required]
            [StringLength(55)]
            [EmailAddress]
            public string correo;

        }

    }
}