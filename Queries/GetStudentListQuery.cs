
using CQRS.Models;
using MediatR;

namespace CQRS.Queries
{
    public class GetStudentListQuery:IRequest<List<StudentDetails>> // IRequest is used to get the data from the database
    {
        
    }
}