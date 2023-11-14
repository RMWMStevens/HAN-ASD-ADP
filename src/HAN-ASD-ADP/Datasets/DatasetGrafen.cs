using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HAN_ASD_ADP.Datasets;

public class DatasetGrafen : IDataset
{
    [JsonPropertyName("lijnlijst")]
    public IReadOnlyCollection<IReadOnlyCollection<int>> Lijnlijst { get; set; }

    [JsonPropertyName("verbindingslijst")]
    public IReadOnlyCollection<IReadOnlyCollection<int>> Verbindingslijst { get; set; }

    [JsonPropertyName("verbindingsmatrix")]
    public IReadOnlyCollection<IReadOnlyCollection<int>> Verbindingsmatrix { get; set; }

    [JsonPropertyName("lijnlijst_gewogen")]
    public IReadOnlyCollection<IReadOnlyCollection<int>> LijnlijstGewogen { get; set; }

    [JsonPropertyName("verbindingslijst_gewogen")]
    public IReadOnlyCollection<IReadOnlyCollection<IReadOnlyCollection<int>>> VerbindingslijstGewogen { get; set; }

    [JsonPropertyName("verbindingsmatrix_gewogen")]
    public IReadOnlyCollection<IReadOnlyCollection<int>> VerbindingsmatrixGewogen { get; set; }
}