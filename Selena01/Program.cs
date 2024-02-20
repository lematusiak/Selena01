// Moduł 5, zadanie domowe

int number = 4594;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int count0 = 0;
int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
int count7 = 0;
int count8 = 0;
int count9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        count0++;
    }
    else if (letter == '1')
    {
        count1++;
    }
    else if (letter == '2')
    {
        count2++;
    }
    else if (letter == '3')
    {
        count3++;
    }
    else if (letter == '4')
    {
        count4++;
    }
    else if (letter == '5')
    {
        count5++;
    }
    else if (letter == '6')
    {
        count6++;
    }
    else if (letter == '7')
    {
        count7++;
    }
    else if (letter == '8')
    {
        count8++;
    }
    else if (letter == '9')
    {
        count9++;
    }
}

Console.WriteLine("0 wynik dla tej liczby: " + count0);
Console.WriteLine("1 wynik dla tej liczby: " + count1);
Console.WriteLine("2 wynik dla tej liczby: " + count2);
Console.WriteLine("3 wynik dla tej liczby: " + count3);
Console.WriteLine("4 wynik dla tej liczby: " + count4);
Console.WriteLine("5 wynik dla tej liczby: " + count5);
Console.WriteLine("6 wynik dla tej liczby: " + count6);
Console.WriteLine("7 wynik dla tej liczby: " + count7);
Console.WriteLine("8 wynik dla tej liczby: " + count8);
Console.WriteLine("9 wynik dla tej liczby: " + count9);

Console.ReadKey();

// Zwróci kolejno dla 4 dwa razy, dla 5 raz, dla 9 raz
