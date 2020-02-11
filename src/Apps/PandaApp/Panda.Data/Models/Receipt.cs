namespace Panda.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Receipt
    {
        [Key]
        public Guid Id { get; set; }

        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; }

        [Required]
        public Guid RecipientId { get; set; }
        public User Recipient { get; set; }

        [Required]
        public Guid PackageId { get; set; }
        public Package Package { get; set; }
    }
}
 