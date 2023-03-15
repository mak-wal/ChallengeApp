int n = 3;

int[] grades = new int[n];
for (int i = 0; i < grades.Length; i++)
//gdy używam tablicy mogę tylko użyć length z uwagi na zapis []
{
    grades[i] = i + 10;
    Console.WriteLine(grades[i]);
}
List<string> tydzien = new List<string>();

tydzien.Add("poniedziałek");
tydzien.Add("wtorek");
tydzien.Add("środa");

Console.WriteLine("metoda z for");
Console.WriteLine("");
//gdy używam listy mogę użyć Count (z uwagi na użycie .Add)
//za pomocą .Add dodaje na końcu listy kolejną wartość
for (int i = 0; i < tydzien.Count; i++)
{
    Console.WriteLine(tydzien[i]);
}
Console.WriteLine("metoda z for each");
Console.WriteLine("");

foreach (string dzien in tydzien)
{
    Console.WriteLine(dzien);
}

        //COŚ nie działa

//List<string> innytydzien = new List<string>();
//innytydzien[0] = "czwartek";
//innytydzien[1] = "piątek";
//innytydzien[2] = "sobota";


//for (int i = 0; i < innytydzien.Count; i++)
//{
//    Console.WriteLine(innytydzien[i]);
//}