namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Borrow_List
    {
        [Key]
        [StringLength(50)]
        public string Borrow_List_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string C_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Call_Day { get; set; }

        [Column(TypeName = "date")]
        public DateTime Due_Date { get; set; }

        public double Total_Price { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Return_Day { get; set; }

        public double? Fine { get; set; }
    }
}
