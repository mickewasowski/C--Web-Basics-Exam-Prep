﻿namespace Panda.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Receipt
    {
        public Receipt()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }

        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; }

        [Required]
        public string RecipientId { get; set; }
        public User Recipient { get; set; }

        [Required]
        public string PackageId { get; set; }
        public Package Package { get; set; }
    }
}
 