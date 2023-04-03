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
            if (grade >= 0 && grade <= 100) // Walidacja sprawdzenie warunku czy warunek jest spełniony
                this.Grades.Add(grade);
            else Console.WriteLine("Błąd dodania wartości. Ocena musi zawierać sie w przedziale <0,100>");
            int GradeInInt = Math.Ceiling(int)grade;

        }
        public void AddGrade(string grade) // nasza metoda będzie bardziej uniwersalna jeśli pozwolimy na dodawanie również
                                           // stringów przez zdublowanie metody AddGrade
        //      wersja bez sprawdzania czy string jest liczbą:
        //{
        //    var value = double.Parse(grade);//parsowanie i konwersja na inny typ
        //    this.AddGrade(value); // nieefektywne było by kopiowanie tego samego z AddGrade dlatego odwołujemy się już do stworzonego
        //}
        {
            //trzeba sprawdzić czy danego stringa da się sparsować bo np string może być liczbą, bądź czego nie chcemy, literą
            if (double.TryParse(grade, out double result)) //zwraca true/false+sparsowanego stringa przechowa w result zmienna out
            {
                this.AddGrade(result);
            }
            else
                Console.WriteLine("Tego STRINGA nie da się zamienić na DOUBLE");
                    }
        int gradeInInt = (int)grade;//rzutowanie double do inta kończy się odcięciem wszystkiego co przecinku

    }
}
