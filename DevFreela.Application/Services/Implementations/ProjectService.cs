using DevFreela.Application.DTOs.InputModels;
using DevFreela.Application.DTOs.ViewModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;

        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Post(CreateProjectInputModel projectInputModel)
        {
            var project = new Project(projectInputModel.Title, projectInputModel.Description, projectInputModel.IdClient,
                                      projectInputModel.IdFreelancer, projectInputModel.TotalCost);

            _dbContext.Projects.Add(project);
            return project.Id;
        }

        public void PostComment(CreateCommentInputModel commentInputModel)
        {
            var projectComment = new ProjectComment(commentInputModel.Content, commentInputModel.IdProject, commentInputModel.IdUser);
            _dbContext.ProjectComments.Add(projectComment);
        }

        public void Delete(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            if (project != null) project.Cancel();
        }


        public List<ProjectViewModel> Get(string query)
        {
            var projects = _dbContext.Projects.Select(x => new ProjectViewModel(x.Id, x.Title, x.CreatedAt)).ToList();
            return projects;
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            if (project == null) return null;

            var projectDetailsViewModel = new ProjectDetailsViewModel(project.Id, project.Title, project.Description, project.TotalCost,
                                                                      project.StartedAt, project.FinishedAt);
            return projectDetailsViewModel;
        }

        public void Start(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            project?.Start();
        }

        public void Finish(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            project?.Finish();
        }

        public void Put(UpdateProjectInputModel projectInputModel)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == projectInputModel.Id);
            project?.Update(projectInputModel.Title, projectInputModel.Description, projectInputModel.TotalCost);
        }
    }
}
