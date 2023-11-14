using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HAN_ASD_ADP.Datasets;

public class DatasetHashing : IDataset
{
    [JsonPropertyName("hashtabelsleutelswaardes")]
    public HashtabelSleutelsWaardes HashtabelSleutelsWaardes { get; set; }
}

public class HashtabelSleutelsWaardes
{
    [JsonPropertyName("a")]
    public IReadOnlyCollection<int> A { get; set; }

    [JsonPropertyName("b")]
    public IReadOnlyCollection<int> B { get; set; }

    [JsonPropertyName("c")]
    public IReadOnlyCollection<int> C { get; set; }

    [JsonPropertyName("d")]
    public IReadOnlyCollection<int> D { get; set; }

    [JsonPropertyName("e")]
    public IReadOnlyCollection<int> E { get; set; }

    [JsonPropertyName("f")]
    public IReadOnlyCollection<int> F { get; set; }

    [JsonPropertyName("g")]
    public IReadOnlyCollection<int> G { get; set; }

    [JsonPropertyName("h")]
    public IReadOnlyCollection<int> H { get; set; }

    [JsonPropertyName("i")]
    public IReadOnlyCollection<int> I { get; set; }

    [JsonPropertyName("j")]
    public IReadOnlyCollection<int> J { get; set; }

    [JsonPropertyName("k")]
    public IReadOnlyCollection<int> K { get; set; }

    [JsonPropertyName("l")]
    public IReadOnlyCollection<int> L { get; set; }

    [JsonPropertyName("m")]
    public IReadOnlyCollection<int> M { get; set; }

    [JsonPropertyName("n")]
    public IReadOnlyCollection<int> N { get; set; }

    [JsonPropertyName("o")]
    public IReadOnlyCollection<int> O { get; set; }

    [JsonPropertyName("p")]
    public IReadOnlyCollection<int> P { get; set; }

    [JsonPropertyName("q")]
    public IReadOnlyCollection<int> Q { get; set; }

    [JsonPropertyName("r")]
    public IReadOnlyCollection<int> R { get; set; }

    [JsonPropertyName("s")]
    public IReadOnlyCollection<int> S { get; set; }

    [JsonPropertyName("t")]
    public IReadOnlyCollection<int> T { get; set; }

    [JsonPropertyName("u")]
    public IReadOnlyCollection<int> U { get; set; }

    [JsonPropertyName("v")]
    public IReadOnlyCollection<int> V { get; set; }

    [JsonPropertyName("w")]
    public IReadOnlyCollection<int> W { get; set; }

    [JsonPropertyName("x")]
    public IReadOnlyCollection<int> X { get; set; }

    [JsonPropertyName("y")]
    public IReadOnlyCollection<int> Y { get; set; }

    [JsonPropertyName("z")]
    public IReadOnlyCollection<int> Z { get; set; }

    [JsonPropertyName("z0")]
    public IReadOnlyCollection<int> Z0 { get; set; }
}