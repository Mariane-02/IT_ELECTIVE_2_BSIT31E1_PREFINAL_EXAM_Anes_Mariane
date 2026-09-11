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
                },
                new Question
                {
                    Number = 3,
                    Topic = "Relational Data Modeling",
                    Text = "What is the primary purpose of Entity Framework Core?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "To create HTML pages automatically"},
                        {"B", "To replace the MVC Controller"},
                        {"C", "To map objects in code to relational database data"},
                        {"D", "To replace the C# compiler"}
                    },
                    MyAnswer = "C",
                    Explanation = "EF Core is an Object-Relational Mapper (ORM) - it maps C# classes and objects to tables and rows in a relational database."
                },
                new Question
                {
                    Number = 4,
                    Topic = "Relational Data Modeling",
                    Text = "Which EF Core component is primarily responsible for communicating with the database?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "DbContext"},
                        {"B", "DbSetView"},
                        {"C", "ControllerContext"},
                        {"D", "RazorContext"}
                    },
                    MyAnswer = "A",
                    Explanation = "DbContext manages the connection and session with the database and exposes DbSet<T> properties for querying and saving data."
                },
                new Question
                {
                    Number = 5,
                    Topic = "Model Binding and Controller Actions",
                    Text = "What does the following command primarily do?",
                    CodeSnippet = "dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Deletes the database"},
                        {"B", "Creates a new MVC project"},
                        {"C", "Generates EF Core models and a DbContext from an existing database"},
                        {"D", "Starts the MVC application"}
                    },
                    MyAnswer = "C",
                    Explanation = "The 'dotnet ef dbcontext scaffold' command reverse-engineers an existing database into entity classes and a DbContext, placed in the Models folder."
                }
            };
        }
    }
}
