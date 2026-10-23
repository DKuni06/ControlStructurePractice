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

// Exercise 4 A
Console.WriteLine("Please enter a whole number. (Part A)");
int userNumA = Convert.ToInt32(Console.ReadLine());
if (userNumA < 10)
{
    Console.WriteLine("This number is too small");
}
else if (userNumA >= 10)
{
    Console.WriteLine("This number is big enough");
}

// Exercise 4 B
Console.WriteLine("Please enter a whole number. Enter 0 to exit.");
int userNumB = Convert.ToInt32(Console.ReadLine());
int totalSum = 0;
int amountOfNum = 0;
while (userNumB != 0)
{
    totalSum += userNumB;
    amountOfNum += 1;
    Console.WriteLine("Enter again or enter 0 to exit.");
    userNumB = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The total sum of all inputted numbers is: " + totalSum);
if (amountOfNum > 0)
{
    double avgNum = (double)totalSum / amountOfNum;
    Console.WriteLine("The average of all numbers is: " + avgNum);
}
else
{
    Console.WriteLine("There is no average number.");
}

// Exercise 5
Console.WriteLine("Pick one as your favorite: ");
Console.WriteLine("A. Water ");
Console.WriteLine("B. Soda ");
Console.WriteLine("C. Tea ");
Console.WriteLine("D. Coffee ");
Console.WriteLine("E. Energy drinks ");
Console.WriteLine("F. Juice ");
Console.WriteLine("G. Lemonade ");
char userChoice = char.ToUpper(Convert.ToChar(Console.ReadLine()));
char[] choices = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
while (!choices.Contains(userChoice))
{
    Console.WriteLine("Please pick a choice: ");
    Console.WriteLine("A. Water ");
    Console.WriteLine("B. Soda ");
    Console.WriteLine("C. Tea ");
    Console.WriteLine("D. Coffee ");
    Console.WriteLine("E. Energy drinks ");
    Console.WriteLine("F. Juice ");
    Console.WriteLine("G. Lemonade ");
    userChoice = char.ToUpper(Convert.ToChar(Console.ReadLine()));
}
switch (userChoice)
{
    case 'A':
        Console.WriteLine("You like water!");
        break;
    case 'B':
        Console.WriteLine("You like soda!");
        break;
    case 'C':
        Console.WriteLine("You like tea!");
        break;
    case 'D':
        Console.WriteLine("You like coffee!");
        break;
    case 'E':
        Console.WriteLine("You like energy drinks!");
        break;
    case 'F':
        Console.WriteLine("You like juice!");
        break;
    case 'G':
        Console.WriteLine("You like lemonade!");
        break;
}