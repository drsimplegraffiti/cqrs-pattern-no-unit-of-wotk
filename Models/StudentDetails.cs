using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Models
{
    public class StudentDetails
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; }=string.Empty;
        public string StudentAddress { get; set; }=string.Empty;
        public int StudentAge { get; set; }
    }
}