using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Models;

namespace CQRS.Repositories
{
    public interface IStudentRepository
    {
         public Task<List<StudentDetails>> GetStudentListAsync();
        public Task<StudentDetails?> GetStudentByIdAsync(int Id);
        public Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails);
        public Task<int> UpdateStudentAsync(StudentDetails studentDetails);
        public Task<int> DeleteStudentAsync(int Id);
    }
}