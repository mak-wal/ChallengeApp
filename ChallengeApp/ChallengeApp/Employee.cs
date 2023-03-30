namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { private set; get; }
        public string Surname { private set; get; }

        private List<double> Grades = new List<double>();

        public Statistics GetStatistics() //metoda która zwraca obiekt(tu dokładnie referencję)
                                          //tutaj zwraca wypełniony obiekt ze statystykami - model statistic
        {
            var statistics = new Statistics();

            statistics.Max = Grades[0];
            statistics.Min = Grades[0];

            foreach(var grades in this.Grades)
            {
                statistics.Max = Math.Max(statistics.Max, grades);
                statistics.Min = Math.Min(statistics.Min, grades);
            }
            statistics.Average = this.Grades.Sum() / this.Grades.Count();

            return statistics;
        }
        public void AddGrade(double grade) //metoda (pusta - void) nie zwracająca niczego a wywołująca polecenia
            {
            this.Grades.Add(grade);
            }
       
        

    }
}
