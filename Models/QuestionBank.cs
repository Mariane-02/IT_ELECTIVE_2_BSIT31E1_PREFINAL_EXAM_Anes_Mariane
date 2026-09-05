namespace ITELEC2.Models
{
    public static class QuestionBank
    {
        public static List<Question> GetAll()
        {
            return new List<Question>
            {
                new Question
                {
                    Number = 1,
                    Topic = "Relational Data Modeling",
                    Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "It makes C# code shorter"},
                        {"B", "It prevents the application from restarting"},
                        {"C", "It allows data to persist after the application stops"},
                        {"D", "It removes the need for MVC"}
                    },
                    MyAnswer = "C",
                    Explanation = "In-memory collections are wiped out once the app stops running. A database stores data on disk, so it survives restarts and crashes."
                },
                new Question
                {
                    Number = 2,
                    Topic = "Relational Data Modeling",
                    Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Code-First"},
                        {"B", "Database-First"},
                        {"C", "Model-First"},
                        {"D", "Controller-First"}
                    },
                    MyAnswer = "B",
                    Explanation = "Database-First scaffolds C# model classes from a database that already exists, the reverse of Code-First."
                }
            };
        }
    }
}
