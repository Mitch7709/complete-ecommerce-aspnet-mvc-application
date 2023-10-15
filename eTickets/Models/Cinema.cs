using eTickets.Data.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Cinema Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string Logo { get; set; }

        [DisplayName("Cinema Name")]
        [Required(ErrorMessage = "Cinema name is required")]
        public string Name { get; set; }

        [DisplayName("Cinema Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}
