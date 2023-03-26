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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suplier()
        {
            Import_List = new HashSet<Import_List>();
        }

        [Key]
        [StringLength(50)]
        public string Sup_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Sup_Name { get; set; }

        [StringLength(50)]
        public string Sup_Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import_List> Import_List { get; set; }
    }
}
