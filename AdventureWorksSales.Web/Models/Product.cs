namespace AdventureWorksSales.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Column(Order = 0)]
        public int ProductID { get; set; }

      
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

       
        [Column(Order = 2)]
        [StringLength(25)]
        public string ProductNumber { get; set; }

      
        [Column(Order = 3)]
        public bool MakeFlag { get; set; }

       
        [Column(Order = 4)]
        public bool FinishedGoodsFlag { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

       
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SafetyStockLevel { get; set; }

       
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ReorderPoint { get; set; }

       
        [Column(Order = 7, TypeName = "money")]
        public decimal StandardCost { get; set; }

     
        [Column(Order = 8, TypeName = "money")]
        public decimal ListPrice { get; set; }

        [StringLength(5)]
        public string Size { get; set; }

        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        public decimal? Weight { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DaysToManufacture { get; set; }

        [StringLength(2)]
        public string ProductLine { get; set; }

        [StringLength(2)]
        public string Class { get; set; }

        [StringLength(2)]
        public string Style { get; set; }

        public int? ProductSubcategoryID { get; set; }

        public int? ProductModelID { get; set; }

        [Column(Order = 10)]
        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        [Column(Order = 11)]
        public Guid rowguid { get; set; }
     
        [Column(Order = 12)]
        public DateTime ModifiedDate { get; set; }
    }
}
