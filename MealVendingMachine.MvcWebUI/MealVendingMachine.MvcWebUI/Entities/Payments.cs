using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities
{
    public class Payments
    {
        [DataMember]
        [Column("paymentId"),Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int paymentId { get; set; }
        [Column("foodId")]
        public int? foodId { get; set; }
        [Column("beverageId")]
        public int? beverageId { get; set; }
        public decimal? beverageQuantity { get; set; }
        public decimal? foodsQuantity { get; set; }
        public string paymentMethod { get; set; }
        public decimal? campaigns { get; set; }
        public decimal? sumprice { get; set; }

    }
}
