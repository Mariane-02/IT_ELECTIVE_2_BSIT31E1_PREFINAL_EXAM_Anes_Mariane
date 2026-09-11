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
                },
                new Question
                {
                    Number = 6,
                    Topic = "Conceptual Data Architecture",
                    Text = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Program.cs only"},
                        {"B", "appsettings.json"},
                        {"C", "Index.cshtml"},
                        {"D", "Student.cs"}
                    },
                    MyAnswer = "B",
                    Explanation = "appsettings.json is the standard configuration file for connection strings, keeping them out of the code itself."
                },
                new Question
                {
                    Number = 7,
                    Topic = "Conceptual Data Architecture",
                    Text = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "One-to-One"},
                        {"B", "One-to-Many"},
                        {"C", "Many-to-Many"},
                        {"D", "Many-to-One only"}
                    },
                    MyAnswer = "B",
                    Explanation = "One Section relates to many Students, while each Student relates to only one Section - a classic One-to-Many relationship."
                },
                new Question
                {
                    Number = 8,
                    Topic = "Conceptual Data Architecture",
                    Text = "In the following example, what is SectionId?",
                    CodeSnippet = "public int SectionId { get; set; }\npublic Section Section { get; set; }",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Primary key of Student"},
                        {"B", "Foreign key referencing Section"},
                        {"C", "Navigation property"},
                        {"D", "Database connection string"}
                    },
                    MyAnswer = "B",
                    Explanation = "SectionId stores the Id of the related Section row, making it a foreign key. The Section property below it is the navigation property."
                },
                new Question
                {
                    Number = 9,
                    Topic = "Razor Syntax and Dynamic Rendering",
                    Text = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "It stores the database password"},
                        {"B", "It represents a relationship to another entity"},
                        {"C", "It creates a new database"},
                        {"D", "It validates the student's name"}
                    },
                    MyAnswer = "B",
                    Explanation = "A navigation property lets you traverse from one entity to its related entity (or collection) directly in code, e.g. student.Section.Name."
                },
                new Question
                {
                    Number = 10,
                    Topic = "Razor Syntax and Dynamic Rendering",
                    Text = "What does .Include() generally allow EF Core to do?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Delete the Section table"},
                        {"B", "Load related Section data together with Students"},
                        {"C", "Create a new Student"},
                        {"D", "Validate Student input"}
                    },
                    MyAnswer = "B",
                    Explanation = "Include() performs eager loading, pulling in related entities (like Section) in the same query instead of leaving them null."
                },
                new Question
                {
                    Number = 11,
                    Topic = "Data Normalization & Structural Integrity",
                    Text = "Why might a ViewModel be used when displaying Student and Section information?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "To replace the database"},
                        {"B", "To combine or shape the data specifically needed by the view"},
                        {"C", "To automatically create database tables"},
                        {"D", "To prevent controllers from using LINQ"}
                    },
                    MyAnswer = "B",
                    Explanation = "A ViewModel tailors and combines exactly the fields a view needs, rather than exposing the full entity model directly."
                },
                new Question
                {
                    Number = 12,
                    Topic = "Data Normalization & Structural Integrity",
                    Text = "Consider this query. What is the main benefit of Include(s => s.Section)?",
                    CodeSnippet = "var students = _context.Students.Include(s => s.Section).ToList();",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "It loads the related Section navigation property"},
                        {"B", "It creates a Section object manually"},
                        {"C", "It removes the foreign key"},
                        {"D", "It prevents the query from accessing the database"}
                    },
                    MyAnswer = "A",
                    Explanation = "Same idea as question 10 - Include(s => s.Section) eagerly loads each Student's related Section so it isn't null."
                },
                new Question
                {
                    Number = 13,
                    Topic = "Data Validation and ModelState",
                    Text = "Which type of validation occurs in the browser before a request is sent to the server?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Database-level validation"},
                        {"B", "Client-side validation"},
                        {"C", "Server-side validation"},
                        {"D", "EF Core migration validation"}
                    },
                    MyAnswer = "B",
                    Explanation = "Client-side validation runs in the browser (usually via JavaScript/jQuery unobtrusive validation) before the form is even submitted."
                },
                new Question
                {
                    Number = 14,
                    Topic = "Data Validation and ModelState",
                    Text = "Why is server-side validation still necessary if client-side validation exists?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Client-side validation can be bypassed"},
                        {"B", "Client-side validation automatically modifies the database"},
                        {"C", "Server-side validation only works with SQLite"},
                        {"D", "Client-side validation cannot display messages"}
                    },
                    MyAnswer = "A",
                    Explanation = "A user can disable JavaScript or send requests directly (e.g. via an API tool), skipping client-side checks entirely, so the server must validate too."
                },
                new Question
                {
                    Number = 15,
                    Topic = "Data Validation and ModelState",
                    Text = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Student Number should always be nullable"},
                        {"B", "Student Number should be unique"},
                        {"C", "Student Number should always be the same"},
                        {"D", "Student Number should contain only spaces"}
                    },
                    MyAnswer = "B",
                    Explanation = "The requirement directly describes a uniqueness constraint on the Student Number field."
                },
                new Question
                {
                    Number = 16,
                    Topic = "Introduction to SQL / CRUD",
                    Text = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "It protects data integrity even if application-level validation is bypassed"},
                        {"B", "It makes Razor Views render faster"},
                        {"C", "It removes the need for a Controller"},
                        {"D", "It automatically creates a ViewModel"}
                    },
                    MyAnswer = "A",
                    Explanation = "A database-level constraint is the last line of defense - it enforces uniqueness no matter how the data was inserted, even if app code has a bug."
                },
                new Question
                {
                    Number = 17,
                    Topic = "Introduction to SQL / CRUD",
                    Text = "What is the purpose of a try...catch block in a controller?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "To create navigation properties"},
                        {"B", "To catch and handle exceptions that may occur during execution"},
                        {"C", "To generate database tables"},
                        {"D", "To perform client-side validation"}
                    },
                    MyAnswer = "B",
                    Explanation = "try...catch lets the controller gracefully handle runtime errors instead of letting the whole application crash."
                },
                new Question
                {
                    Number = 18,
                    Topic = "Introduction to SQL / CRUD",
                    Text = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "UseDatabase()"},
                        {"B", "UseExceptionHandler()"},
                        {"C", "UseValidationHandler()"},
                        {"D", "UseMvcDatabase()"}
                    },
                    MyAnswer = "B",
                    Explanation = "UseExceptionHandler() is the built-in ASP.NET Core middleware that catches unhandled exceptions app-wide and routes them to an error page."
                },
                new Question
                {
                    Number = 19,
                    Topic = "Introduction to SQL / CRUD",
                    Text = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Display the student's information anyway"},
                        {"B", "Display a Not Found (404) response/page"},
                        {"C", "Delete Student 999"},
                        {"D", "Create Student 999 automatically"}
                    },
                    MyAnswer = "B",
                    Explanation = "When a requested resource doesn't exist, the correct HTTP semantics are to return a 404 Not Found response."
                },
                new Question
                {
                    Number = 20,
                    Topic = "Introduction to SQL / CRUD",
                    Text = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                    Choices = new Dictionary<string, string>
                    {
                        {"A", "Data integrity"},
                        {"B", "HTML formatting"},
                        {"C", "CSS inheritance"},
                        {"D", "Razor syntax"}
                    },
                    MyAnswer = "A",
                    Explanation = "Assigning a duplicate record risks inconsistent or redundant data - a data integrity concern, not a presentation issue."
                }
            };
        }
    }
}
