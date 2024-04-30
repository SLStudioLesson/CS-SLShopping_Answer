using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SLShopping.Models
{
    [Keyless]
    public class UserRole
    {
        //public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RoleId { get; set; }
        //public List<User> Users { get; set; } = [];
        //public List<Role> Roles { get; set; } = [];
    }
}
