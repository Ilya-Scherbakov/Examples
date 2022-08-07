// Сколько раз собака пробежит от одного друга к другому

int first_friend_Speed = new Random().Next(1, 5);
int second_friend_Speed = new Random().Next(1, 5);
int dog_Speed = new Random().Next(10, 15);
double distans = 10000;
int friend = 2;
int count = 0;

Console.Write("Скорость первого друга ");
Console.WriteLine(first_friend_Speed);
Console.Write("Скорость второго друга ");
Console.WriteLine(second_friend_Speed);
Console.Write("Скорость собаки ");
Console.WriteLine(dog_Speed);
Console.Write("На каком удалении находятся друзья ");
Console.WriteLine(distans);

while (distans > 10)
{
    double time;
    if (friend == 1)
    {
        time = distans / (first_friend_Speed + dog_Speed);
        friend = 2;
    }
    else
    {
        time = distans / (second_friend_Speed + dog_Speed);
        friend = 1;
    }
    distans = distans - (first_friend_Speed + second_friend_Speed) * time;
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.WriteLine(count);