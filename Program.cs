String score = "1";


switch (score)
{
    case "2:2":
        Console.WriteLine("You achieved a Second Class Lower Divison honours degree");
        break;


    case "2:1":
        Console.WriteLine("You achieved a Second Class Upper Divison honours degree");
        break;


    case "1":
        Console.WriteLine("You achieved a First Class honours degree");
        break;

    default:
        Console.WriteLine("No known achievement");
        break;
}

    