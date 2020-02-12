namespace Panda.Services
{
    using SIS.MvcFramework.Attributes.Validation;
    public class LoginInputModel
    {
        [RequiredSis]
        [StringLengthSis(5,20,"Invalid username!")]
        public string Username { get; set; }

        [RequiredSis]
        public string Password { get; set; }
    }
}
