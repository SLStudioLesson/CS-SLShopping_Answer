using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace SLShopping.Models;

public class User : IdentityUser<int>
{
    /*
     * 以下プロパティはIdentityUserが持っているので省略
     * Id
     * Email
     * PasswordHash
     * PhoneNumber
     * UserName
     */
    //public List<UserRole> UserRoles { get; set; } = null!;
}
