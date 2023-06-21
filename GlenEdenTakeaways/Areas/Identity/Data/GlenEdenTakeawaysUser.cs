using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GlenEdenTakeaways.Areas.Identity.Data;

// Add profile data for application users by adding properties to the GlenEdenTakeawaysUser class
public class GlenEdenTakeawaysUser : IdentityUser
{
    [Required]
    [StringLength(255, ErrorMessage = "The first ame field should have a maximum of 255 characters")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(255, ErrorMessage = "The first ame field should have a maximum of 255 characters")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
}

