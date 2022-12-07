Console.WriteLine("Введите пятизначное число:");
string numStr = Console.ReadLine() ??"";

bool isNum = int.TryParse(numStr, out int num);

if (!isNum) 
{
    Console.WriteLine("Вы ввели не число");
    return;
}

if (Math.Abs(num).ToString().Length != 5)
{
    Console.WriteLine("Число не пятизначное");
    return;
}

Boolean CheсkPalindrom (string str)
{
    int i1 = 0;
    int i2 = str.Length - 1;

    while (i1< i2)
    {
        if (str[i1] == str[i2])
        {
            i1 ++ ;
            i2 -- ;
        }
        else
            return false;                
    }
    return true;
}

if (CheсkPalindrom(Math.Abs(num).ToString()))
    Console.WriteLine($"Число {numStr} палиндром");
else
    Console.WriteLine($"Число {numStr} не является палиндромом");
