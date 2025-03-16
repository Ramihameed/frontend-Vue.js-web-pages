using System.Text.Json.Serialization;

public class cars
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("price")]
    public int price { get; set; }
}
