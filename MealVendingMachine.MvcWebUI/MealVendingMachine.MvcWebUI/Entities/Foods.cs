using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities
{
    public class Foods
    {
        [DataMember]
        [Column("foodId"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int foodId { get; set; }
        public string foodİmageUrl { get; set; }
        public string foodName { get; set; }
        [Column("categoryId")]
        public int categoryId { get; set; }
        public decimal? foodprice { get; set; }
        public string? desription { get; set; }

    }
}
