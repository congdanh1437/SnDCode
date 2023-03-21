namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Suplier")]
    public partial class Suplier
    {
        [Key]
        [StringLength(50)]
        public string Sup_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Sup_Name { get; set; }

        [StringLength(50)]
        public string Sup_Email { get; set; }
    }
}
