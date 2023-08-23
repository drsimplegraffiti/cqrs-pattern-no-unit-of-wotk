using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Models;
using MediatR;

namespace CQRS.Commands
{
    public class CreateStudentCommand: IRequest<StudentDetails>
    {
         public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }

        public CreateStudentCommand(
            string studentName,
            string studentEmail,
            string studentAddress,
            int studentAge) // we need the constructor to pass the data
        {
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentAddress = studentAddress;
            StudentAge = studentAge;
    }
}
}