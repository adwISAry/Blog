
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace blogtask25thdecember.Areas.Admin.ViewModels
{
    public class AdminCoverListItemVM
    {
        
        public int Id { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        

    }
}
