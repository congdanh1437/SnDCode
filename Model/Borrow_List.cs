namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Borrow_List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Borrow_List()
        {
            Borrows = new HashSet<Borrow>();
        }

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

        public int? Quality { get; set; }

        [StringLength(50)]
        public string E_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrow> Borrows { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
