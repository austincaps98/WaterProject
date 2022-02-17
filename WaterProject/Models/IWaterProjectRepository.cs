using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WaterProject.Models
{
    public interface IWaterProjectRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
