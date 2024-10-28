/* zadanie 1 */
using System.Security.Cryptography;

Console.WriteLine("Zmienne i typy danych");
byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)80;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";
// tutaj wpisz rozwiązanie

Console.WriteLine(byteVariable);
Console.WriteLine(longVariable);
Console.WriteLine(integralVariable);
Console.WriteLine(charVariable1);
Console.WriteLine(charVariable2);
Console.WriteLine(doubleVariable);
Console.WriteLine(floatVariable);
Console.WriteLine(stringVariable);

/* koniec zadania 1 */

/* zadanie 2 */
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
long longValue = num;
Console.WriteLine(bigNum);
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
int integerValue = (int)bigNum;
Console.WriteLine(bigNum);
Console.WriteLine(integerValue);
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
int intFromString = int.Parse(stringNum);
Console.WriteLine(intFromString);
// zbadaj zachowanie programu 

/* koniec zadania 2 */

/* zadanie 3 */
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
int c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
int d = a - b;
// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
int e = a * b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
int f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
int g = a % b;
// wypisz na ekran c,d,e,f,g
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);

// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
Console.WriteLine(price * price);
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
Console.WriteLine(doubleVal * doubleVal);
// zastanów się skąd się bieże różnica

// wypisz na ekran wynik pola koła o promieniu równym radius
Console.WriteLine(Math.PI * radius * radius);
// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.
int hours = (int)time / 60;
Console.WriteLine(hours);
int minutes = (int)time;
Console.WriteLine(minutes);
int seconds = (int)time * 60;
Console.WriteLine(seconds);

/* koniec zadania 3 */


/* zadanie 4 */
int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement++;

// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;

// Sprawdzenie wyników
Console.WriteLine("toIncrement: " + toIncrement);
Console.WriteLine("toDivide: " + toDivide);

//Math.Sqrt(9);            // pierwiastek kwadratowy
//Math.Pow(3, 2);           // potęgowanie
//Math.Abs(-10);           // moduł
//Math.Sin(1.57);          // sinus kąta w radianach
//Math.Round(1.5);         // zaokrąglenie do najbliższej wartości całkowitej
//Math.Round(2.5);         // wynik taki jak dla funkcji wyżej   
//Math.Truncate(1.95);     // część całkowita liczby zmiennoprzecinkowej
//Math.Ceiling(1.95);      // najmniejsza liczba całkowita większa lub równa argumentowi
//Math.Floor(1.95);        // największa liczba całkowita mniejsza lub równa argumentowi 
//Math.Clamp(4, 0, 10);   // ograniczenie pierwszego argumentu do zakresu
//Math.Max(2, 6);          // zwraca większy argument
//Math.Min(2, 6);          // zwraca mniejszy argument
//Math.Sign(-2);           // zwraca liczbę określającą znak argumentu: - 1, 0 lub 1

/* koniec zadania 4 */

/* zadanie 5 */
double pi = Math.PI;

double tau = Math.Tau;

double degree = 45;
double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
sinValue = Math.Sin(degree * (Math.PI / 180));

Console.WriteLine("SinValue 45 : " + sinValue);
/* koniec zadania 5 */

// 6 zadanie Data i czas
int Year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
DateTime date = new DateTime (Year, month, day, hour, minute, 0);
Console.WriteLine("Nieaktualna data: " + date);
// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
date = date.AddMonths(3).AddHours(-1);
Console.WriteLine("Nowa data: " + date);
// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
Console.WriteLine("Dzien tygodnia: " + date.DayOfWeek);

/* koniec zadania 6 */

//zadanko 7
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
// stwórz nową zmienną typu string jako złączenie powyższych.
firstPart += " " + secondPart + " " + thirdPart;
Console.WriteLine(firstPart);
// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
Console.WriteLine(firstPart.ToUpper());
// oraz liczbę przedstawiającą długość tego ciągu znaków
int lenght = firstPart.Length + " ".Length + secondPart.Length + " ".Length + thirdPart.Length;
Console.WriteLine("Dlugosc: " + lenght);
//koniec!!!

/* zadanie 8 */
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
bool isTriangle = (lengthA < lengthB + lengthC);
// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
bool isRightTriangle = ( lengthA * lengthA == lengthB * lengthB + lengthC + lengthC);
Console.WriteLine("Trojkat: " + isRightTriangle);
/* koniec zadania 8 */

/* zadanie 9 */
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
if (conditionalString.Length > 10) 
{
    Console.WriteLine("Yaaay: " + conditionalString);
}
/* koniec zadania 9 */

/* zadanie 10 */
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if (temperature > 20)
{
    Console.WriteLine("Oi oi oi ale cieplo");
}
else if (temperature < 20)
{
    Console.WriteLine("Nuh uh, its cold");
}
else if (temperature == 20)
{
    Console.WriteLine("Not so bad");
}

//alternatywa rozw - 11 zad
//string result = temperature > 20 ? "Oi oi oi ale cieplo" : (temperature < 20 ? "Nuh uh, its cold" : "Not so bad");
//Console.WriteLine(result);

/* koniec zadania 10 - 11 */


/* zadanie 12 */
int code = 15;
int quantity = 11;
decimal productPrice = 8m;
decimal sellPrice;
//produkty o kodach poniżej 10 sprzedawane są po cenie określonej w productPrice,
if (10 > 0)
{
    sellPrice = productPrice;
}
//produkty o kodach od 10 do 15 sprzedawane są po cenie o 5% mniejszej od productPrice.
else if (code >= 10 && code <= 15)
{
    sellPrice = productPrice * 0.95m;
}
//produkty o kodach powyżej 16 sprzedawane są po cenie zależnej od quantity:
//dla quantity do 10 cena jest o 5% wyższa od price,
else
{
    if (quantity < 10)
    {
        sellPrice = productPrice * 105m;
    }
    //dla quantity od 11 do 20 jest równa price,
    else if (quantity >= 11 && quantity <= 20) 
    {
        sellPrice = productPrice;
    }
    //dla quantity powyżej 20, ale mniejszej od 100, jest niższa o 1% dla każdej pełnej wielokrotności 10 np.
    //dla quantity = 20, 21, ..29 to 2%,
    //dla quantity = 30, 31, 32, 39 to 3% itd.
    else if(quantity >= 20 && quantity <= 100)
    {
        int discPercent = (quantity / 10) - 2;
        sellPrice = productPrice * (1 - (discPercent * 0.01m)) ;
    }
    //dla quantity powyżej 100 cena jest niższa o 10%.
    else
    {
        sellPrice = productPrice * 0.90m;
    }

}

Console.WriteLine($"Price: " + sellPrice);
/* koniec zadania 12 */

/* zadanie 13 */
char hexNum = 'E';
int decimalNum;

switch (hexNum)
{
    case '0':
        decimalNum = 0;
        break;
    case '1':
        decimalNum = 1;
        break;
    case '2':
        decimalNum = 2;
        break;
    case '3':
        decimalNum = 3;
        break;
    case '4':
        decimalNum = 4;
        break;
    case '5':
        decimalNum = 5;
        break;
    case '6':
        decimalNum = 6;
        break;
    case '7':
        decimalNum = 7;
        break;
    case '8':
        decimalNum = 8;
        break;
    case '9':
        decimalNum = 9;
        break;
    case 'A':
    case 'a':
        decimalNum = 10;
        break;
    case 'B':
    case 'b':
        decimalNum = 11;
        break;
    case 'C':
        decimalNum = 12;
        break;
    case 'D':
    case 'd':
        decimalNum = 13;
        break;
    case 'E':
    case 'e':
        decimalNum = 14;
        break;
    case 'F':
    case 'f':
        decimalNum = 15;
        break;
    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        return;
}
Console.WriteLine($"Decimal number: " + decimalNum);
//* koniec zadania 