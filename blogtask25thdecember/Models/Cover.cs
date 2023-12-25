using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogtask25thdecember
{
    public class Cover
    {
        public int Id { get; set; }
        [Required]
		[NotMapped]

		public IFormFile Image { get; set; }
        

    }
}
