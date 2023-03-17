
namespace ChallengeApp//(przestrzeń nazw) w której będą się nawzajem widzieć rózne klasy które mają ten sam namespace
{
    public class User//klasa wszystkie trzymać jako osobne pliki!!
    {
        ///*private*/ string login, password;//musiałem usunąć z powodu dodania linijki z setget
        /*Domyślnie jest zawsze prywatne i nie można się odosić bo 
         zablokowane chyba że napiszę public-MODYFIKATOR DOSTĘPU*/
        public static string nazwa_gry = "El Dorado";//zmienna statyczna do której już NIE odnoszę poprzez OBIEKT(tu user1)
                                                     //tylko odwołując się do typu obiektu(tu User(class)) // tak samo moge stworzyc np. (static) metodę statyczną
        public User(string login, string password)//KONSTRUKTOR automatycznie wywoływany
                                                  //w momencie gdy dany obiekt jest tworzony tu np. User
        {
            this.Login = login;
            this.Password = password;
            nazwa_gry = "Mamma Mia"//zmienną statyczną wywołuję już bez this.
    }
        public string Login { get; private set; } //PROPERTY tak zwane POLE//ustalam jako prywatne zmienianie loginuihasła
        public string Password { get; private set; }// za to odczytywanie jest dozwolone 

        private List<int> Score = new List<int>();

        public int Result //do wywoływaia sumy punktów
        {
            get
            {
                return this.Score.Sum();
            }
        }

        public void AddScore(int points)//metoda //dodaje nam do tablicy po kolei elementy
        {
            this.Score.Add(points);
        }
    }
}
