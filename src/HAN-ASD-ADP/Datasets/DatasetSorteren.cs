using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HAN_ASD_ADP.Datasets;

public class DatasetSorteren : IDataset
{
    [JsonPropertyName("lijst_aflopend_2")]
    public IReadOnlyCollection<int> LijstAflopend2 { get; set; }

    [JsonPropertyName("lijst_oplopend_2")]
    public IReadOnlyCollection<int> LijstOplopend2 { get; set; }

    [JsonPropertyName("lijst_float_8001")]
    public IReadOnlyCollection<float> LijstFloat8001 { get; set; }

    [JsonPropertyName("lijst_gesorteerd_aflopend_3")]
    public IReadOnlyCollection<int> LijstGesorteerdAflopend3 { get; set; }

    [JsonPropertyName("lijst_gesorteerd_oplopend_3")]
    public IReadOnlyCollection<int> LijstGesorteerdOplopend3 { get; set; }

    [JsonPropertyName("lijst_herhaald_1000")]
    public IReadOnlyCollection<int> LijstHerhaald1000 { get; set; }

    [JsonPropertyName("lijst_leeg_0")]
    public IReadOnlyCollection<int> LijstLeeg0 { get; set; }

    [JsonPropertyName("lijst_null_1")]
    public IReadOnlyCollection<int?> LijstNull1 { get; set; }

    [JsonPropertyName("lijst_null_3")]
    public IReadOnlyCollection<int?> LijstNull3 { get; set; }

    [JsonPropertyName("lijst_onsorteerbaar_3")]
    public IReadOnlyCollection<object> LijstOnsorteerbaar3 { get; set; }

    [JsonPropertyName("lijst_oplopend_10000")]
    public IReadOnlyCollection<int> LijstOplopend10000 { get; set; }

    [JsonPropertyName("lijst_willekeurig_10000")]
    public IReadOnlyCollection<int> LijstWillekeurig10000 { get; set; }

    [JsonPropertyName("lijst_willekeurig_3")]
    public IReadOnlyCollection<int> LijstWillekeurig3 { get; set; }
}