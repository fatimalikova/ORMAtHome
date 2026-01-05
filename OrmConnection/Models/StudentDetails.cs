using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmConnection.Models
{
    public class StudentDetails
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
