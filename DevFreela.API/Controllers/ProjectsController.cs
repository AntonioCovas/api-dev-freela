﻿using DevFreela.API.Models;
using DevFreela.Application.DTOs.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var projects = _projectService.Get(query);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = _projectService.GetById(id);
            if(project == null) return NotFound();
            return Ok(project);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectInputModel inputModel)
        {
            if(inputModel.Title?.Length > 50) return BadRequest();
            var id = _projectService.Post(inputModel);
            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPost("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectInputModel inputModel)
        {
            if (inputModel.Description?.Length > 200)
            {
                return BadRequest();
            }
            _projectService.Put(inputModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _projectService.Delete(id);
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentInputModel inputModel)
        {
            _projectService.PostComment(inputModel);
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            _projectService.Start(id);
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            _projectService.Finish(id);
            return NoContent();
        }
    }
}
