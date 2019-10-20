using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace GraduationProject
{

    public partial class Item
    {
        [Key]
        [StringLength(50)]
        public string IId { get; private set; }

        [Required]
        [StringLength(100)]
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public long Number { get; private set; }

        public int Discount { get; private set; }
    }
}
