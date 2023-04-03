using ChallengeApp;
Employee employee = new Employee("Justyna", "Skowrońska");
employee.AddGrade(5);
employee.AddGrade("2");
employee.AddGrade("duplo");
employee.AddGrade("221");
employee.AddGrade(10);
var statistics = employee.GetStatistics();

Console.WriteLine("wartość minimalna: "+statistics.Min);
Console.WriteLine($"wartość maksymalna: { statistics.Max}");
Console.WriteLine($"średnia: { statistics.Average:N2}");//Symbol $ informuje o interpolacji stringa w przypadku
                                                   //gdy nasz string zawiera watości dynamiczne pozwala na wyświetlanie plus edycja
                                                   //:N2 informujemy że chcemy zaokręglenia do 2 miejsc po przecinku
 


