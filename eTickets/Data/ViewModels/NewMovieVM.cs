using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [DisplayName("Movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [DisplayName("Movie description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [DisplayName("Price in $")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Movie poster URL is required")]
        [DisplayName("Movie poster URL")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [DisplayName("Start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [DisplayName("End date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Movie category is required")]
        [DisplayName("Select a category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Required(ErrorMessage = "Movie actor(s) is required")]
        [DisplayName("Select actor(s)")]
        public List<int> ActorIds { get; set; }

        [Required(ErrorMessage = "Movie cinema is required")]
        [DisplayName("Select a cinema")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Movie producer is required")]
        [DisplayName("Select a producer")]
        public int ProducerId{ get; set; }
    }
}
