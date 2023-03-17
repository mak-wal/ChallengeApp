//------Rozwiązanie nr1-----
Console.WriteLine("ile jakic cyfr w liczbie:");
long number = 453212129999999999;
string NumberInString = number.ToString();
char[] letters = NumberInString.ToArray();

int[] ile = new int[10];

Console.WriteLine(NumberInString);

for (int i = 0; i < letters.Length; i++)
{
    if (letters[i] == 0)
        ile[0] = ile[0] + 1;
    else if (letters[i] == '1')
        ile[1] = ile[1] + 1;
    else if (letters[i] == '2')
        ile[2] = ile[2] + 1;
    else if (letters[i] == '3')
        ile[3] = ile[3] + 1;
    else if (letters[i] == '4')
        ile[4] = ile[4] + 1;
    else if (letters[i] == '5')
        ile[5] = ile[5] + 1;
    else if (letters[i] == '6')
        ile[6] = ile[6] + 1;
    else if (letters[i] == '7')
        ile[7] = ile[7] + 1;
    else if (letters[i] == '8')
        ile[8] = ile[8] + 1;
    else if (letters[i] == '9')
        ile[9] = ile[9] + 1;
}

int numeracja = 0;
foreach (int tyle in ile)
{
    Console.Write(numeracja);
    Console.Write(". ");

    Console.WriteLine(tyle);
    numeracja++;
}




