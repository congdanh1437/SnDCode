namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Import_List
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Import_List_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Supplier_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Import { get; set; }
    }
}
