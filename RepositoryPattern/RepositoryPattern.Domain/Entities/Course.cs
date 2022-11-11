using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Domain.Entities
{
    [Table("Courses")]
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public string CourseType { get; set; }  
        public string CourseAdress { get; set; }    
        public string TrainerName { get; set; } 
        public  string TrainerEmail  { get; set; }   
    }
}
