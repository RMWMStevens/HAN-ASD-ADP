using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Datasets;

public static class DatasetCache<T>
    where T : IDataset
{
    private static readonly object lockObject = new();
    private static Task<T> datasetTask;

    public static async Task<T> GetAsync()
    {
        if (datasetTask == null)
        {
            lock (lockObject)
            {
                datasetTask = FetchAsync();
            }
        }

        return await datasetTask;
    }

    private static async Task<T> FetchAsync()
    {
        using var httpClient = new HttpClient();
        var baseUrl = "https://han-aim.gitlab.io/dt-sd-asd/materials/ADP/bron/";
        var jsonSuffix = ToSnakeCase(typeof(T).Name) + ".json";
        var response = await httpClient.GetAsync(baseUrl + jsonSuffix);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>(new JsonSerializerOptions
        {
            Converters = { new PlainObjectConverter() }
        });
    }

    private static string ToSnakeCase(string pascalCaseString)
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