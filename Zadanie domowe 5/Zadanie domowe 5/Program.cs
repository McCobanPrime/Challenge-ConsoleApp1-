int liczba = 30045;
string liczbaNalitery = liczba.ToString();
char[] tablicaliczby = liczbaNalitery.ToArray();
int b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, i = 0, j = 0, k = 0;
for (int a = 0; a < tablicaliczby.Length; a++)
{
    if (tablicaliczby[a] == '0')
    {
        k++;
    }
    if (tablicaliczby[a] == '1')
    {
        b++;
    }
    if (tablicaliczby[a] == '2')
    {
        c++;
    }
    if (tablicaliczby[a] == '3')
    {
        d++;
    }
    if (tablicaliczby[a] == '4')
    {
        e++;
    }
    if (tablicaliczby[a] == '5')
    {
        f++;
    }
    if (tablicaliczby[a] == '6')
    {
        g++;
    }
    if (tablicaliczby[a] == '7')
    {
        h++;
    }
    if (tablicaliczby[a] == '8')
    {
        i++;
    }
    if (tablicaliczby[a] == '9')
    {
        j++;
    }
    
}
Console.WriteLine("0=" + k);
Console.WriteLine("1=" + b);
Console.WriteLine("2=" + c);
Console.WriteLine("3=" + d);
Console.WriteLine("4=" + e);
Console.WriteLine("5=" + f);
Console.WriteLine("6=" + g);
Console.WriteLine("7=" + h);
Console.WriteLine("8=" + i);
Console.WriteLine("9=" + j);