using DevFreela.Application.DTOs.InputModels;
using DevFreela.Application.DTOs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> Get(string query);
        ProjectDetailsViewModel GetById(int id);
        int Post(CreateProjectInputModel inputModel);
        void Put(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void PostComment(CreateCommentInputModel inputModel);
        void Start(int id);
        void Finish(int id);
    }
}
