string[] myArr = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string ord in myArr)
{
    if (ord.StartsWith("B"))
    {
        Console.WriteLine(ord);
    };
}