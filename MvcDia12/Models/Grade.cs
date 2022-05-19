using System.ComponentModel.DataAnnotations;

namespace MvcDia12.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        public string GradeName { get; set; }
        public string Section { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
