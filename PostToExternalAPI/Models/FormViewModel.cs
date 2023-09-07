using System.ComponentModel.DataAnnotations;

namespace InternalAuth.Models
{
    public class FormViewModel
    {
        [Required]
        public string Parameters { get; set; }
    }
}
