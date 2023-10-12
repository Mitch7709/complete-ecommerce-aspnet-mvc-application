using eTickets.Data.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Profile Picture is required")]
        [DisplayName("Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [DisplayName("Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [DisplayName("Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }


    }
}
