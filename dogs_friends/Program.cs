int first_friend_speed = 2;
int second_friend_speed = 1;
int dogspeed = 5;
int distance = 10000;
int time = 0;
int friend = 2;

int count = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (dogspeed + first_friend_speed);
        friend = 2;

    }
    else
    {
        time = distance / (dogspeed - second_friend_speed);
        friend = 1;

    }
    distance = distance - (first_friend_speed - second_friend_speed) * time;
    count++;
}
Console.Write(count);