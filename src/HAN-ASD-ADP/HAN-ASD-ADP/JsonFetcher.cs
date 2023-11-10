using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HAN_ASD_ADP;

public class JsonFetcher
{
    private const string BaseUrl = "https://han-aim.gitlab.io/dt-sd-asd/materials/ADP/bron/";
    private readonly HttpClient httpClient;

    public JsonFetcher(HttpClient httpClient)
        => this.httpClient = httpClient;

    public async Task<T> FetchJsonAsync<T>()
    {
        var jsonSuffix = ToSnakeCase(typeof(T).Name) + ".json";
        var response = await httpClient.GetAsync(BaseUrl + jsonSuffix);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>();
    }

    public static string ToSnakeCase(string pascalCaseString)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(char.ToLowerInvariant(pascalCaseString[0]));

        for (int i = 1; i < pascalCaseString.Length; i++)
        {
            if (char.IsUpper(pascalCaseString[i]))
            {
                stringBuilder.Append('_');
            }
            stringBuilder.Append(char.ToLowerInvariant(pascalCaseString[i]));
        }

        return stringBuilder.ToString();
    }
}