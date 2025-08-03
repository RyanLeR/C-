using System;
var roll = new Random();
int score = 0;

//int dice1 = roll.Next(1, 7);
int dice1 = 5;
//int dice2 = roll.Next(1, 7);
int dice2 = 5;
//int dice3 = roll.Next(1, 7);
int dice3 = 4;
score = dice1 + dice2 + dice3;


if ((dice1 == dice2) && (dice1 == dice3))
{
    score += 6;
}
else if ((dice1 == dice2) || (dice1 == dice3) || (dice2 == dice3))
{
    score += 2;
}
else
{
    score = score;
}


Console.WriteLine(dice1);
Console.WriteLine(dice2);
Console.WriteLine(dice3);
Console.WriteLine($"score {score}");

if (score > 6)
{
    if (score == 7)
    {
        Console.WriteLine("You win a trip for two!");  
    } else if (score > 9) {
        if (score == 10)
        {
            Console.WriteLine("You won a new laptop!");
        }
        else if (score > 15)
        {
            Console.WriteLine("You won a new car!");
        }
    }
}
else
{
    Console.WriteLine("You won a kitten!");
};







