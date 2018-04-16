namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recovery")]
    public partial class Recovery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recovery()
        {
            Data = new HashSet<Datum>();
        }

        public Guid Id { get; set; }

        public double Value { get; set; }

        public Guid СurrencyId { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datum> Data { get; set; }

        public virtual Сurrencies Сurrencies { get; set; }
    }
}
