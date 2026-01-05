using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmConnection.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        public int Age { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public StudentDetails StudentDetails { get; set; }
        public List<SubjectStudent> SubjectStudent { get; set; } 
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Age: {Age}, GroupId: {GroupId}";
        }
    }
}
