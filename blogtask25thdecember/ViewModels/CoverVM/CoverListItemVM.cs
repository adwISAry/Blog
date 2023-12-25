using blogtask25thdecember.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogtask25thdecember.Models.Cover

{
    public class CoverListItemVM
    {
        public int Id { get; set; }
        [NotMapped]
		[Required]
         public IFormFile? Image { get; set; }
        





    }
}
