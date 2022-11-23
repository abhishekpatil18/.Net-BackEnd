using EF_Assignment.Data;
using EF_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly  DataContext Context;
        public ProjectController(DataContext context)
        {
            Context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Projects>>> GetAllProject()
        {
            return Ok(await Context.Projects.ToListAsync());
        }

        [HttpGet("id")]
        public async Task<ActionResult<List<Projects>>> GetOneProject(int id)
        {
            var project = await Context.Projects.FindAsync(id);
            return Ok(project);
        }

        [HttpPost]
        public async Task<ActionResult<List<Projects>>> CreateProject(Projects proj)
        {
            Context.Projects.Add(proj);
            await Context.SaveChangesAsync();
            return Ok(await Context.Projects.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Projects>>> UpdateProject(Projects proj)
        {
            var project = await Context.Projects.FindAsync(proj.Id);
            project.Name=proj.Name;
            project.Duration=proj.Duration;

            await Context.SaveChangesAsync();
            return Ok(await Context.Projects.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Projects>>> DeleteProject(int id)
        {
            var project = await Context.Projects.FindAsync(id);
                Context.Projects.Remove(project);
            await Context.SaveChangesAsync();
            return Ok(await Context.Projects.ToListAsync());
        }

    }
}
