using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecurityProject.API.Data;




namespace SecurityProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly project_securityContext _context;
        public RolesController(project_securityContext context)
        {
            _context = context;
        }

        // GET api/Roles
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _context.Roles.ToListAsync();
            return Ok(roles);
        }

        // GET api/roles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(int id)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(x => x.RoleId ==id);

            return Ok(role);



        }

        // POST api/roles
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/roles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/roles/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
