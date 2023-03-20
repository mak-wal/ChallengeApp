using Zadanie_domowe_dzień__6;

Employee employee1 = new Employee("Marzenka", "Gandi", 22, 0);
Employee employee2 = new Employee("Staszek", "Fistaszek", 41, 0);
Employee employee3 = new Employee("Fausti", "Gutierez", 19, 0);

employee1.AddPoints(14);
employee1.AddPoints(3);

employee2.AddPoints(9);
employee2.AddPoints(8);

employee3.AddPoints(3);
employee3.AddPoints(5);

List<Employee> list = new List<Employee>()
    {
        employee1, employee2, employee3
    };

int HighestPoints = 0;
List<string> HighestImię = new List<string>();
List<string> HighestNazwisko = new List<string>();
List<int> HighestWiek = new List<int>();

foreach (Employee employee in list)
{
    if (employee.Result >= HighestPoints)
    {
        HighestPoints = employee.Result;
    }
}
foreach (Employee employee in list)
{
    if (employee.Result >= HighestPoints)
    {
        HighestPoints = employee.Result;
        HighestImię.Add(employee.imię);
        HighestNazwisko.Add(employee.nazwisko);
        HighestWiek.Add(employee.wiek);
    }
}
Console.Write("najwyższa uzyskana ilość punktów: ");
Console.WriteLine(HighestPoints);
int i = 1;
foreach (string H_imie in HighestImię)
{
    Console.Write(i++);
    Console.Write(". ");
    Console.WriteLine(H_imie);
  
}
i = 1;
foreach (string H_nazwisko in HighestNazwisko)
{
    Console.Write(i++);
    Console.Write(". ");
    Console.WriteLine(H_nazwisko);
}
i = 1;
foreach (int H_wiek in HighestWiek)
{
    Console.Write(i++);
    Console.Write(". ");
    Console.WriteLine(H_wiek);
}
