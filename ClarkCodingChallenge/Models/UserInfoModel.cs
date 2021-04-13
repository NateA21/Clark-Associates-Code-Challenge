using System.ComponentModel.DataAnnotations;

namespace ClarkCodingChallenge.Models
{
    public class UserInfoModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$")]
        public string Email { get; set; }
    }
}