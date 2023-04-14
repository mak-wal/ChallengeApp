using ChallangeApp;

Employee employee = new Employee("Marcin", "Pyć");
employee.AddGrade("2");
employee.AddGrade("GOG");
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine("Wartość minimalna: " +statistics.Min);
Console.WriteLine($"Wartość maksymalna: {statistics.Max}");
Console.WriteLine($"Wartość średnia: {statistics.Average:N2}");// Symbol $ informuje o interpolacji stringa w przypadku
                                                   //gdy nasz string zawiera watości dynamiczne pozwala na wyświetlanie plus edycja
                                                   //:N2 informujemy że chcemy zaokręglenia do 2 miejsc po przecinku


