namespace Zadanie_domowe_dzień__6
{
    public class Employee
    {
        public Employee(string name, string SurName, int age, int points)
        {
            this.imię = name;
            this.nazwisko = SurName;
            this.wiek = age;
            this.punkty = points;
        }
        public string imię { private set; get; }
        public string nazwisko { private set; get; }
        public int wiek { private set; get; }
        public int punkty { private set; get; }

        List<int> Points = new List<int>();
        public int Result
        {
            get
            { return this.Points.Sum(); }
        }
        public void AddPoints(int points)
        {
            Points.Add(points);
        }
    }
}
