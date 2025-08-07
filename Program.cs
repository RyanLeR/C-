Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string msg = "";

// Your code goes here


if (daysUntilExpiration < 6)
{
    if (daysUntilExpiration < 2)
    {
        discountPercentage = 20;
    }
    else
    {
        discountPercentage = 10;
    }
}

if (daysUntilExpiration < 11)
{
    if (daysUntilExpiration < 6)
    {
        if (daysUntilExpiration < 2)
        {
            if (daysUntilExpiration < 1)
            {
                msg = "Your subscription has expired";
            }
            else
            {
                msg = $"Your subscription expires within a day! \n Renew now and save {discountPercentage}!";
            }
        }
        else
        {
            msg = $"Your subscription expires in {daysUntilExpiration} days! \n Renew now and save {discountPercentage}%!";
        }
    }
    else
    {
        msg = $"Your subscription expires soon. Renew now!";
    }
}
else
{
    msg = "";
}

Console.WriteLine(daysUntilExpiration);
Console.WriteLine(msg);