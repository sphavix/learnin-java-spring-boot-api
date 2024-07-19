

using System.Net.Http.Json;
using TutorialsClient.Models;

namespace TutorialsClient.Services
{
    public class TutorialService : ITutorialsService
    {
        private readonly HttpClient _httpClient;
        public TutorialService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<Tutorial> CreateTutorialAsync(Tutorial tutorial)
        {
            var data = await _httpClient.PostAsJsonAsync("/api/tutorials", tutorial);
            var response = await data.Content.ReadFromJsonAsync<Tutorial>();
            return response!;
        }

        public async Task<Tutorial> DeleteTutorialAsync(int id)
        {
            var data = await _httpClient.DeleteAsync($"api/tutorials/{id}");
            var response = await data.Content.ReadFromJsonAsync<Tutorial>();
            return response!;
        }

        public async Task<Tutorial> GetTutorialAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Tutorial>($"api/tutorials/{id}")!;
        }

        public async Task<List<Tutorial>> GetTutorialsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Tutorial>>("api/tutorials")!;
        }

        public async Task<Tutorial> UpdateTutorialAsync(Tutorial tutorial)
        {
            var data = await _httpClient.PutAsJsonAsync("/api/tutorials", tutorial);
            var response = await data.Content.ReadFromJsonAsync<Tutorial>();
            return response!;
        }
    }
}