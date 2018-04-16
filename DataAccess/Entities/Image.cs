namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Image
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column("Image", Order = 1, TypeName = "image")]
        public byte[] Image1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DateCreated { get; set; }
    }
}
