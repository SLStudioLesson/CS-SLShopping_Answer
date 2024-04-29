using System.ComponentModel.DataAnnotations;

namespace SlShopping.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        //public List<UserRole> UserRoles { get; set; } = [];
    }
}
