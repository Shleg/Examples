Console.Clear();

int count = 0;
int xA = 20, yA = 1, xB = 1, yB = 20, xC = 40, yC = 20;

Console.SetCursorPosition(xA, yA);
Console.WriteLine("*");

Console.SetCursorPosition(xB, yB);
Console.WriteLine("*");

Console.SetCursorPosition(xC, yC);
Console.WriteLine("*");

int x = xA, y = yA;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xA) / 2;
        y = (y + yA) / 2;
    }
    if (what == 1)
    {
        x = (x + xB) / 2;
        y = (y + yB) / 2;
    }
    if (what == 2)
    {
        x = (x + xC) / 2;
        y = (y + yC) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}