using TheWaterProject.Models;

namespace TheWaterProject.Migrations
{
    public interface IWaterRepository
    {
        public IQueryable<Project> Projects { get; }
    }
}
