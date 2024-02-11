using System.ComponentModel.DataAnnotations;

namespace TrainsApi.DTOs.Requests
{
    public class UserRegisterRequestDTO
    {
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
