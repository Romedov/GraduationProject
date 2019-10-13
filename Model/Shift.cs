namespace GraduationProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shift
    {
        [Key]
        public long SId { get; set; }

        [Required]
        [StringLength(50)]
        public string UId { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public decimal CashReceived { get; set; }

        public decimal CashReturned { get; set; }

        public decimal CashAdded { get; set; }

        public decimal CashWithdrawn { get; set; }
    }
}
