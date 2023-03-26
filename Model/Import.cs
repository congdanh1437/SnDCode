namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Import")]
    public partial class Import
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string B_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string IL_ID { get; set; }

        public int Quantity { get; set; }

        public virtual Book Book { get; set; }

        public virtual Import_List Import_List { get; set; }
    }
}
