using System.ComponentModel.DataAnnotations;

namespace ValidationExample.Models;

public class UserViewModel
{
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(50, ErrorMessage = "First Name can't be longer than 50 characters")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }
}

