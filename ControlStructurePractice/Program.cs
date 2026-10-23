// Exercise 1
for (int i = 1; i <= 6; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}

// Exercise 2
int Limit = 7; // could have limit be 8 and remove the + 1 from the j loop.
for (int i = 1; i <= Limit; i++)
{
    for (int j = 0; j < Limit - i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Exercise 3
for (int i = 1; i <= 5; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("\\");
    }
    for (int j = 0; j < (5 - i) * 2; j++)
    {
        Console.Write(".");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("/");
    }
    Console.WriteLine();
}

