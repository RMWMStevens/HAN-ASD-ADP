using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HAN_ASD_ADP.Datasets;

public class DatasetGrafen : IDataset
{
    [JsonPropertyName("lijnlijst")]
    public List<List<int>> Lijnlijst { get; set; }

    [JsonPropertyName("verbindingslijst")]
    public List<List<int>> Verbindingslijst { get; set; }

    [JsonPropertyName("verbindingsmatrix")]
    public List<List<int>> Verbindingsmatrix { get; set; }

    [JsonPropertyName("lijnlijst_gewogen")]
    public List<List<int>> LijnlijstGewogen { get; set; }

    [JsonPropertyName("verbindingslijst_gewogen")]
    public List<List<List<int>>> VerbindingslijstGewogen { get; set; }

    [JsonPropertyName("verbindingsmatrix_gewogen")]
    public List<List<int>> VerbindingsmatrixGewogen { get; set; }
}