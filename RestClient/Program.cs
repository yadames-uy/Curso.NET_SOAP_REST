//https://62951bd863b5d108c199feb4.mockapi.io/api/characters

using Newtonsoft.Json;
using Refit;
using RestClient;

async Task<List<Hero>> HttpClientOption()
{
    var url = "https://62951bd863b5d108c199feb4.mockapi.io/api/characters";

    var http = new HttpClient();

    var respose = await http.GetStringAsync(url);

    return JsonConvert.DeserializeObject<List<Hero>>(respose);
}

async Task<List<Hero>> RefitOption()
{
    var refitClient = RestService.For<IRestClient>("https://62951bd863b5d108c199feb4.mockapi.io");
    return await refitClient.GetHeroes();
}

var heroes = await RefitOption();

foreach (var hero in heroes)
{
    Console.WriteLine("Id: {0} | Nombre: {1}", hero.Id, hero.Name);
}
Console.ReadLine();