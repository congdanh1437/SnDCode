namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Borrow_List = new HashSet<Borrow_List>();
        }

        [Key]
        [StringLength(50)]
        public string C_ID { get; set; }

        public int Lend_Status { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone_numb { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Create { get; set; }

        [StringLength(50)]
        public string C_Name { get; set; }

        public int? Age { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoB { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string E_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrow_List> Borrow_List { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
