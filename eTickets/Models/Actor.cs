using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {

        [Key]
        public int ID { get; set; }

        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]

        public string FullName { get; set; }
      
        [Display(Name = "Biography")]

        public string Bio { get; set; }

        //RelationShips

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
