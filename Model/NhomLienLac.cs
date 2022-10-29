namespace QuanLyDanhBaSInhVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomLienLac")]
    public partial class NhomLienLac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomLienLac()
        {
            LienLacs = new HashSet<LienLac>();
        }
        [Key]
        public int MaNhom { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LienLac> LienLacs { get; set; }
    }
}
