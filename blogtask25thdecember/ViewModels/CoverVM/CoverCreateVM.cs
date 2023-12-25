using blogtask25thdecember.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogtask25thdecember.Models.Cover

{
	public class CoverCreateVM
    {

		public int Id { get; set; }
		[Required]
		[NotMapped]
		public IFormFile? Image { get; set; }

	}
}
