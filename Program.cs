using System;
var roll = new Random();
int score;

int dice1 = roll.Next(1, 7);

int dice2 = roll.Next(1, 7);

int dice3 = roll.Next(1, 7);

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

if (score > 14)
{
    Console.WriteLine("You won the game!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}







