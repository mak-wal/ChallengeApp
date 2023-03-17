//int n = 3;

//int[] grades = new int[n];
//for (int i = 0; i < grades.Length; i++)
////gdy używam tablicy mogę tylko użyć length z uwagi na zapis []
//{
//    grades[i] = i + 10;
//    Console.WriteLine(grades[i]);
//}
//List<string> tydzien = new List<string>();

//tydzien.Add("poniedziałek");
//tydzien.Add("wtorek");
//tydzien.Add("środa");

//Console.WriteLine("metoda z for");
//Console.WriteLine("");
////gdy używam listy mogę użyć Count (z uwagi na użycie .Add)
////za pomocą .Add dodaje na końcu listy kolejną wartość
//for (int i = 0; i < tydzien.Count; i++)
//{
//    Console.WriteLine(tydzien[i]);
//}
//Console.WriteLine("metoda z for each");
//Console.WriteLine("");

//foreach (string dzien in tydzien)
//{
//    Console.WriteLine(dzien);
//}

//COŚ nie działa

//List<string> innytydzien = new List<string>();
//innytydzien[0] = "czwartek";
//innytydzien[1] = "piątek";
//innytydzien[2] = "sobota";


//for (int i = 0; i < innytydzien.Count; i++)
//{
//    Console.WriteLine(innytydzien[i]);
//}

using ChallengeApp;

User user1 = new User("Adam", "568waf");
User user2 = new User("Marysia", "asd245");
User user3 = new User("Zuzia", "a8f333");
User user4 = new User("Damian", "gsd8w2");

string imie = user1.Login;

user2.AddScore(3);
user2.AddScore(6);

int result = user2.Result; //odwołanie się do obiektu (user2)
Console.WriteLine(result);
string GameName = User.nazwa_gry;//odwołonie się do zmiennej statycznej (User)

