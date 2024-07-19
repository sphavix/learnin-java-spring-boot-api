using TutorialsClient.Models;

namespace TutorialsClient.Services
{
    public interface ITutorialsService
    {
        Task<List<Tutorial>> GetTutorialsAsync();
        Task<Tutorial> GetTutorialAsync(int id);
        Task<Tutorial> CreateTutorialAsync(Tutorial tutorial);
        Task<Tutorial> UpdateTutorialAsync(Tutorial tutorial);
        Task<Tutorial> DeleteTutorialAsync(int id);
    }
}