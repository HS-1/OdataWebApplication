using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace Service
{
    public interface IStudentLogic
    {
        Task<Student> GetStudentAsync(Guid id);
    }
}
