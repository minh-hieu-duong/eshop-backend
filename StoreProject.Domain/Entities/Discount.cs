﻿using StoreProject.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreProject.Domain.Entities
{
    public class Discount : BaseDomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountValue { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public int MinOrderValue { get; set; }
        public string DiscountCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxUses { get; set; }
        public int UsesCount { get; set; }
        public ICollection<UserDiscount> UserDiscounts { get; set; }
    }
}
