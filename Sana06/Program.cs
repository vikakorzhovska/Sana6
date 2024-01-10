using Library;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
try
{
    People[] peoples = new People[5];
    peoples[0] = new People("Viktoria", "Korzhovska", new DateTime(2005, 12, 29));
    peoples[1] = new Applicant("Viktoria", "Korzhovska", new DateTime(2005, 12, 29), 169, 11, "School 2");
    peoples[2] = new Student("Viktoria", "Korzhovska", new DateTime(2005, 12, 29), 1, "IPZ - 23 - 4", "FIKT", "ZTU");
    peoples[3] = new Teacher("Viktoria", "Korzhovska", new DateTime(2005, 12, 29), "Teacher", "Computer Technology", "ZTU");
    peoples[4] = new LibraryUser("Viktoria", "Korzhovska", new DateTime(2005, 12, 29), 238327, new DateTime(2023, 12, 25), 2300);
    for (int i = 0; i < peoples.Length; i++)
    {
        Console.WriteLine(peoples[i].ShowInfo());
    }
}
catch(ZNOException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Використано бал ЗНО: {ex.ZNO}");
}
catch (PointsException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Використано бал: {ex.Points}"); 
}
catch (CourseException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Введений курс: {ex.Course}");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}
