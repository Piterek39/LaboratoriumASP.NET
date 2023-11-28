using Data;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3.Controllers
{
    [Route("api/organizations")]
    [ApiController]
    public class OrganizationApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        public  OrganizationApiController(AppDbContext context)
        {
            _context = context;
        }
        [Route("filter")]
       // [HttpGet]
        public IActionResult GetFilteredOrganizations(string q)
        {
            var result = _context.Organizations
                .Where(o => o.Title.ToUpper().StartsWith(q.ToUpper()))
                .Select(o =>
                new
                {
                    Id = o.Id,
                    Title = o.Title

                }
                )
                .ToList();
            return Ok(result);
        }
        [Route("{id}")]
        public IActionResult GetOrganizationById(int id)
        {
            var entity = _context.Organizations.Find(id);
            if (entity == null)
            {
                return NotFound();
            }
            else
                return Ok(entity);
        }
    }
}
