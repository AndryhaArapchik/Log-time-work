namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Info")]
    public partial class Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Info()
        {
            Data = new HashSet<Datum>();
        }

        public Guid Id { get; set; }

        public DateTime BeginTime { get; set; }

        public DateTime EndTime { get; set; }

        public double Amount { get; set; }

        public Guid СurrencyId { get; set; }

        public Guid TypeEarningsId { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datum> Data { get; set; }

        public virtual TypeEarning TypeEarning { get; set; }

        public virtual Сurrencies Сurrencies { get; set; }
    }
}
