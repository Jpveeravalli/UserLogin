using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public class RegisterPostModel : IValidatableObject
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var svd = new List<ValidationResult>();
            return svd;
        }
    }
}
