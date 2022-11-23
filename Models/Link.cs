using System.ComponentModel;
using Newtonsoft.Json;

namespace API.Models
{
    public class Link
    {
        public static Link To(string routeName, object routeValue = null){
            return new Link{
                RouteName = routeName,
                RouteValue = routeValue,
                Method = "GET",
                relations = null
            };
        }


        [JsonProperty(Order =-4)]
        public string Href { get; set; }
        [JsonProperty(Order =-3, PropertyName ="rel",NullValueHandling =NullValueHandling.Ignore)]
        public string[] relations{ get; set; }
        [JsonProperty(Order =-2,NullValueHandling =NullValueHandling.Ignore)]
        [DefaultValue("GET")]
        public string Method{ get; set; }
        [JsonIgnore]
        public string RouteName { get; set; }
        [JsonIgnore]
        public object RouteValue { get; set; }
    }
}