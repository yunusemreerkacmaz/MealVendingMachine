using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities
{
    public class Beverages
    {
        [DataMember]
        [Column("beverageId"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int beverageId { get; set; }
        public string beverageİmageUrl { get; set; }
        public string beverageName { get; set; }
        [Column("categoryId")]
        public int categoryId { get; set; }
        public decimal? beverageprice { get; set; }
        public string? description { get; set; }
    }
}
