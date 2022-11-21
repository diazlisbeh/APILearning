using Newtonsoft.Json;

namespace API.Models;

public abstract class Resources{
    [JsonProperty(Order = -2)]
    public string Href { get; set; }
}