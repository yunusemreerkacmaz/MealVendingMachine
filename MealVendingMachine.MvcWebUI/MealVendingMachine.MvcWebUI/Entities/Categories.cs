using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities
{
    public class Categories
    {
        [DataMember]
        [Column("Id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string categoryName { get; set; }
        public int categoryId { get; set; }
    }
}
