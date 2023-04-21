namespace DeserializeNestedJson.Models
{
    public class Model
    {
        public IDictionary<string, string>? Text1 { get; set; }
        public IDictionary<string, int>? Text2 { get; set; }
        public IList<string>? Text3 { get; set; }
        public IList<int>? Numbers { get; set; }
    }
}
