using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Models
{
    public class HistoryViewModel:History
    {
        public int PetId { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Display(Name ="Tipo de Servicio")]
        [Range(1,int.MaxValue,ErrorMessage ="Debes seleccionar un Tipo de Servicio")]
        public int ServiceTypeId { get; set; }

        public IEnumerable<SelectListItem> ServiceTypes { get; set; }
    }
}
