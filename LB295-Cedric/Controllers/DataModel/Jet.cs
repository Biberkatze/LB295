using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LB295_Cedric.Controllers.DataModel
{
    public class ProductDataModel
    {
        [Key]
        public Guid jet_id { get; set; }

        [Required]
        public string modellname { get; set; }

        [Required]
        public string Hersteller { get; set; }

        [Required]
        public string Erstflug { get; set; }
    }
}

