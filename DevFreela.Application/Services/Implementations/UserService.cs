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
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Id == id);
            var userViewModel = new UserViewModel(user.Id, user.FullName);
            return userViewModel;
        }

        public void Login(int id, UpdateLoginInputModel updateLoginInputModel)
        {
            throw new NotImplementedException();
        }

        public int Post(CreateUserInputModel createUserInputModel)
        {
            var user = new User(createUserInputModel.FullName, createUserInputModel.Email, createUserInputModel.BirthDate);
            _dbContext.Users.Add(user);
            return user.Id;
        }
    }
}
