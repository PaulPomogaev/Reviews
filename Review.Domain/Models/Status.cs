
using System.Text.Json.Serialization;

namespace Review.Domain.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        None = 0,
        Actual = 1,
        Deleted = 2
    }
}
