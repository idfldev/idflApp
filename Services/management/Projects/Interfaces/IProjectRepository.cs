using idflApp.Core.Dtos;

namespace idflApp.Services.management.Projects.Interfaces
{
    public interface IProjectRepository
    {
        public IEnumerable<FindProjectDto> Find();
        public GetProjectDetailDto GetDetailById(Guid id);
    }
}