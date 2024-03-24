namespace WebApplication2;

public class NameMockData
{
    private static readonly string[] firstNames = { "John", "Mary", "Robert", "Jennifer", "David", "Linda", "William", "Patricia", "Richard", "Barbara", "Joseph", "Elizabeth", "Thomas", "Susan", "Charles", "Jessica", "Matthew", "Sarah", "Anthony", "Karen", "James", "Elizabeth", "Michael", "Anne", "William", "Emma", "Alexander", "Grace", "Christopher", "Sophia", "Joseph", "Olivia", "Daniel", "Emily", "Samuel", "Ava", "Benjamin", "Isabella", "Jacob", "Mia" };
    private static readonly string[] surnames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson" };

    private static Random random = new(DateTime.Now.GetHashCode());

    public static string GenerateRandomName()
    {
        string firstName = firstNames[random.Next(firstNames.Length)];
        string surname = surnames[random.Next(surnames.Length)];
        return $"{firstName} {surname}";
    }
}