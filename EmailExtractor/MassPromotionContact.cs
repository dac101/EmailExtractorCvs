namespace EmailExtractor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MassPromotionContact")]
    public partial class MassPromotionContact
    {
        public int MassPromotionContactId { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [StringLength(200)]
        public string phoneNumber { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(200)]
        public string country { get; set; }

        [StringLength(200)]
        public string state { get; set; }
    }
}
