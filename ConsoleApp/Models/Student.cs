using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        //Foreign key for Standard
        public int SchoolRefId { get; set; }

        [ForeignKey("SchoolRefId")]
        public School School { get; set; }
    }
}
