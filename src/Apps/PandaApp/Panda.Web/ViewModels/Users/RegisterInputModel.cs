namespace Panda.Web.ViewModels.Users
{
    using SIS.MvcFramework.Attributes.Validation;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class RegisterInputModel
    {
        [RequiredSis]
        [StringLengthSis(5,10,"Username should be between 5 and 10 characters!")]
        public string Username { get; set; }

        [RequiredSis]
        [StringLengthSis(5, 10, "Username should be between 5 and 10 characters!")]
        public string Email { get; set; }

        [RequiredSis]
        public string Password { get; set; }

        [RequiredSis]
        public string ConfirmPassword { get; set; }
    }
}
