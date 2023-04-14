namespace ChallangeApp
{
    public class Employee
    {
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        private List<double> Grades = new List<double>();

        public void AddGrade(double grade)//METODA (pusta - void) nie zwracająca niczego a wywołująca polecenia
        {
            //int valueInInt = (int)grade;//RZUTOWANIE double na int, obcina wszystko co jest po przecinku, nie zaookrągla! 
                                            //aby zaokrąglić:- w górę Math.Ceiling - w dół Math.Floor
            if (grade >= 0 && grade <= 100) //WALIDACJA czy mieści się w zakresie
                this.Grades.Add(grade);
            else Console.WriteLine("wartość spoza zakresu oceny(<0,100>");
        }

        public void AddGrade(string grade)
        {
            //double value = double.Parse(grade); //konwersja na inny typ zmiennej// w tym przypadku istnieje zagrożenie że string nie jest double. 
                                                    //Należałoby go zwalidować mółgby to być np string: "Basia", a nie np: "2.5"
            //this.AddGrade(value);                 //wywołuję metodę nie kopiując linijek niepotrzebnie

            if (double.TryParse(grade, out double result))//WALIDACJA//sprawdzi czy jest parsowalna zwróci odp.typu bool dodatkowo zachowa nam -
                                                          //wynik parsowania jako zmienna out (tu ,,result"), przekazany parametr można nadpisać dzięki temu ,,out"
                this.Grades.Add(result);
            else Console.WriteLine("podany string nie jest liczbą");
        }
        public Statistics GetStatistics()//metoda która zwraca obiekt(tu dokładnie referencję)
                                         //tutaj zwraca wypełniony obiekt ze statystykami - model statistic
        {
            var statistics = new Statistics();
            statistics.Max = Grades[0];
            statistics.Min = Grades[0];

            foreach (var Grade in this.Grades)
            {
                if (Grade > statistics.Max)
                    statistics.Max = Grade;
                if (Grade < statistics.Min)
                    statistics.Min = Grade;
            }
            statistics.Average = Grades.Sum() / Grades.Count();
            return statistics;
        }

    }
}
