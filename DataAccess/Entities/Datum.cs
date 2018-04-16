namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Datum
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid CompanyId { get; set; }

        public Guid InfoId { get; set; }

        public Guid RecoveryId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual Company Company { get; set; }

        public virtual Info Info { get; set; }

        public virtual Recovery Recovery { get; set; }

        public virtual User User { get; set; }
    }
}
