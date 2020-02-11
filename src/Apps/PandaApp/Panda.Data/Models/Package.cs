namespace Panda.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Package
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public PackageStatus Status { get; set; }

        public DateTime EstimatedDeliveryTime { get; set; }

        [Required]
        public Guid RecipientId { get; set; }
        public virtual User Recipient { get; set; }
    }
}
