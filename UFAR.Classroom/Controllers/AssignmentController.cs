using Microsoft.AspNetCore.Mvc;
using UFAR.Classroom.Entities;
using UFAR.Classroom.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UFAR.Classroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        // GET: api/Assignment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
        {
            var assignments = await _assignmentService.GetAssignmentsAsync();
            return Ok(assignments);
        }

        // GET: api/Assignment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
            var assignment = await _assignmentService.GetAssignmentByIdAsync(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return Ok(assignment);
        }

        // POST: api/Assignment
        [HttpPost]
        public async Task<ActionResult<Assignment>> PostAssignment(Assignment assignment)
        {
            var createdAssignment = await _assignmentService.CreateAssignmentAsync(assignment);
            return CreatedAtAction("GetAssignment", new { id = createdAssignment.Id }, createdAssignment);
        }

        // PUT: api/Assignment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssignment(int id, Assignment assignment)
        {
            var success = await _assignmentService.UpdateAssignmentAsync(id, assignment);

            if (!success)
            {
                return BadRequest();
            }

            return NoContent();
        }

        // DELETE: api/Assignment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            var success = await _assignmentService.DeleteAssignmentAsync(id);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
