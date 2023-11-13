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
    public List<int> A { get; set; }

    [JsonPropertyName("b")]
    public List<int> B { get; set; }

    [JsonPropertyName("c")]
    public List<int> C { get; set; }

    [JsonPropertyName("d")]
    public List<int> D { get; set; }

    [JsonPropertyName("e")]
    public List<int> E { get; set; }

    [JsonPropertyName("f")]
    public List<int> F { get; set; }

    [JsonPropertyName("g")]
    public List<int> G { get; set; }

    [JsonPropertyName("h")]
    public List<int> H { get; set; }

    [JsonPropertyName("i")]
    public List<int> I { get; set; }

    [JsonPropertyName("j")]
    public List<int> J { get; set; }

    [JsonPropertyName("k")]
    public List<int> K { get; set; }

    [JsonPropertyName("l")]
    public List<int> L { get; set; }

    [JsonPropertyName("m")]
    public List<int> M { get; set; }

    [JsonPropertyName("n")]
    public List<int> N { get; set; }

    [JsonPropertyName("o")]
    public List<int> O { get; set; }

    [JsonPropertyName("p")]
    public List<int> P { get; set; }

    [JsonPropertyName("q")]
    public List<int> Q { get; set; }

    [JsonPropertyName("r")]
    public List<int> R { get; set; }

    [JsonPropertyName("s")]
    public List<int> S { get; set; }

    [JsonPropertyName("t")]
    public List<int> T { get; set; }

    [JsonPropertyName("u")]
    public List<int> U { get; set; }

    [JsonPropertyName("v")]
    public List<int> V { get; set; }

    [JsonPropertyName("w")]
    public List<int> W { get; set; }

    [JsonPropertyName("x")]
    public List<int> X { get; set; }

    [JsonPropertyName("y")]
    public List<int> Y { get; set; }

    [JsonPropertyName("z")]
    public List<int> Z { get; set; }

    [JsonPropertyName("z0")]
    public List<int> Z0 { get; set; }
}