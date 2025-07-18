using DevFreela.Application.DTOs.ViewModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    internal class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;   
        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public List<SkillViewModel> Get()
        {
            var skills = _dbContext.Skills;
            var skillsViewModel = skills.Select(x => new SkillViewModel(x.Id, x.Description)).ToList();
            return skillsViewModel;
        }
    }
}
