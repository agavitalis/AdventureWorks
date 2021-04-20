namespace AdventureWorksSales.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesOrder")]
    public partial class SalesOrder
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesOrderID { get; set; }

        [Column(Order = 1)]
        public int SalesOrderDetailID { get; set; }

        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OrderQty { get; set; }

        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecialOfferID { get; set; }

        [Column(Order = 5, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(Order = 6, TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }

        [Column(Order = 7, TypeName = "numeric")]
        public decimal LineTotal { get; set; }

        [Column(Order = 8)]
        public Guid rowguid { get; set; }

        [Column(Order = 9)]
        public DateTime ModifiedDate { get; set; }
       
    }
}
