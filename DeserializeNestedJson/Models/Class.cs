namespace DeserializeNestedJson.Models
{

    public class SomeModel
    {
        public Dictionary<string, string> Text1 { get; set; }
        public Dictionary<string, string> Text2 { get; set; }
        public List<string> Text3 { get; set; }
        public int[] Numbers { get; set; }
    }

    //public class NestedModelA
    //{
    //    public string A { get; set; }
    //    public string B { get; set; }
    //    public string C { get; set; }
    //}

    //public class NestedModel2
    //{
    //    public int D { get; set; }
    //    public int E { get; set; }
    //    public int F { get; set; }
    //}



    public class Model
    {
        public IDictionary<string, string>? Text1 { get; set; }
        public IDictionary<string, int>? Text2 { get; set; }
        public IList<string>? Text3 { get; set; }
        public IList<int>? Numbers { get; set; }
    }


    public class Rootobject
    {
        public Text1 Text1 { get; set; }
        public Text2 Text2 { get; set; }
        public string[] Text3 { get; set; }
        public int[] Numbers { get; set; }
    }

    public class Text1
    {
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
    }

    public class Text2
    {
        public int d { get; set; }
        public int e { get; set; }
        public int f { get; set; }
    }



}
