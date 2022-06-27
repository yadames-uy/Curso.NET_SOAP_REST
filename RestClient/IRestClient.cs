using Refit;

namespace RestClient
{
    public interface IRestClient
    {
        [Get("/api/characters")]
        Task<List<Hero>> GetHeroes();
    }
}