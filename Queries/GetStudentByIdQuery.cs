
using CQRS.Models;
using MediatR;

namespace CQRS.Queries
{
    public class GetStudentByIdQuery:IRequest<StudentDetails> // IRequest is used to get the data from the database
    {
        public int Id { get; set; } // we need to pass the Id to get the student details
    }
}