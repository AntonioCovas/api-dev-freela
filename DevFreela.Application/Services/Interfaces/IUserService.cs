using DevFreela.Application.DTOs.InputModels;
using DevFreela.Application.DTOs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetById(int id);
        int Post(CreateUserInputModel inputModel);
        void Login(int id, UpdateLoginInputModel inputModel);
    }
}
