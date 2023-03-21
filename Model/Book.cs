namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [StringLength(50)]
        public string BookID { get; set; }

        [Required]
        [StringLength(50)]
        public string Book_Title { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
