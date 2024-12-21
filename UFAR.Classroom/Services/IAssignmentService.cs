using UFAR.Classroom.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UFAR.Classroom.Services
{
    public interface IAssignmentService
    {
        Task<IEnumerable<Assignment>> GetAssignmentsAsync();
        Task<Assignment> GetAssignmentByIdAsync(int id);
        Task<Assignment> CreateAssignmentAsync(Assignment assignment);
        Task<bool> UpdateAssignmentAsync(int id, Assignment assignment);
        Task<bool> DeleteAssignmentAsync(int id);
    }
}
