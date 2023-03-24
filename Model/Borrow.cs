namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Borrow")]
    public partial class Borrow
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string BL_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string B_ID { get; set; }
    }
}
