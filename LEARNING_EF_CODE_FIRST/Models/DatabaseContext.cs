namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{

        // Static Constructors(C# Programming Guide)
        // A static constructor does not take access modifiers or have parameters.
        // A static constructor is called automatically to initialize the class before the
        // first instance is created or any static members are referenced.
        // A static constructor cannot be called directly.
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
        static DatabaseContext()
		{
		}

		public DatabaseContext() : base()
		{
		}

		public System.Data.Entity.DbSet<Person> People { get; set; }
	}
}
