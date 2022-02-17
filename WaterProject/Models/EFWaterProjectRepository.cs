using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WaterProject.Models
{
    public class EFWaterProjectRepository : IWaterProjectRepository
    {
        private WaterProjectContext context { get; set; }

        public EFWaterProjectRepository (WaterProjectContext temp)
        {
            context = temp;
        }

        public IQueryable<Project> Projects => context.Projects;
    }
}
