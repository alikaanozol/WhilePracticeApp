Console.WriteLine("-----< Alıştırma 1 >-----");
int i = 1;
while (i<11)
{
    Console.WriteLine($"{i}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("-----< Alıştırma 2 >-----");
int b = 1;
while (b<21)
{
    Console.Write(b+",");
    b++;
}
Console.WriteLine(" ");

Console.WriteLine("-----< Alıştırma 3 >-----");
int c = 2;
while (c < 21)
{
    Console.Write(c + ",");
    c += 2;
}
Console.WriteLine(" ");
Console.WriteLine("-----< Alıştırma 4 >-----");
int d = 50;
int total = 0;
while (d < 151)
{
    total=total+d;
    d++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı" + " " + total);


Console.WriteLine("-----< Alıştırma 5 >-----");

int x = 1;
int sumSingle=0;
int sumDouble = 0;
while (x<121)
{
    if (x % 2 == 0)
    {
        sumDouble += x;
        x++;
    }
    else
    {
        sumSingle += x;
        x++;
    }
}

Console.WriteLine($"1 ile 120 arasındaki Tek sayıların toplamı {sumSingle}");
Console.WriteLine($"1 ile 120 arasındaki Çift sayıların toplamı {sumDouble}");
