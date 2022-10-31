int Numb = 5;
int Say = 0;

for (int i = 1; i < Numb; i++)
{
    if(Numb%i == 0)
    {
        Say++;
    }
}
if (Numb == 1)
{
    Console.WriteLine("1ne sadedir ne murekkeb");
}
else if (Say > 2)
{
    Console.WriteLine("Murekkeb");
}
else
{
    Console.WriteLine("Sade");
}