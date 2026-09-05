namespace ITELEC2.Models
{
    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; } = string.Empty;
        public string CodeSnippet { get; set; } = string.Empty;
        public Dictionary<string, string> Choices { get; set; } = new();
        public string MyAnswer { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
    }
}
