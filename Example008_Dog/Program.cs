int count = 0;
int meetPoint = 10;
int friendFlag = 2;
double time = 0;

Console.Write("Введите скорость первого друга: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите дистанцию: ");
double distance = Convert.ToInt32(Console.ReadLine());

while (distance > meetPoint)
{
    if (friendFlag == 1)
    {
        time = distance / (dogSpeed + firstFriendSpeed);
        friendFlag = 2;
    }
    else
    {
        time = distance / (dogSpeed - secondFriendSpeed);
        friendFlag = 1;
    }
    distance = distance - time * (firstFriendSpeed - secondFriendSpeed);
    count++;
}

Console.WriteLine("Собака пробежит " + count + " раз");