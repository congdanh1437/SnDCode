namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Import_List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Import_List()
        {
            Imports = new HashSet<Import>();
        }

        [Key]
        [StringLength(50)]
        public string Import_List_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Supplier_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Import { get; set; }

        [StringLength(50)]
        public string E_ID { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports { get; set; }

        public virtual Suplier Suplier { get; set; }
    }
}
