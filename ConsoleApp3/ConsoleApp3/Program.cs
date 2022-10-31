int Num = 19203312;
int say = 0;

for(int i = 0; i < Num; i++)
{
    Num /= 10;
    if (Num > 0)
    {
        say++;
    }
}Console.WriteLine(say +1);