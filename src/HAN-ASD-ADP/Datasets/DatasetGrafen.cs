using System.Text.Json.Serialization;

namespace HAN_ASD_ADP.Datasets;

public class DatasetGrafen : IDataset
{
    [JsonPropertyName("lijnlijst")]
    public int[][] Lijnlijst { get; set; }

    [JsonPropertyName("verbindingslijst")]
    public int[][] Verbindingslijst { get; set; }

    [JsonPropertyName("verbindingsmatrix")]
    public int[][] Verbindingsmatrix { get; set; }

    [JsonPropertyName("lijnlijst_gewogen")]
    public int[][] LijnlijstGewogen { get; set; }

    [JsonPropertyName("verbindingslijst_gewogen")]
    public int[][][] VerbindingslijstGewogen { get; set; }

    [JsonPropertyName("verbindingsmatrix_gewogen")]
    public int[][] VerbindingsmatrixGewogen { get; set; }
}