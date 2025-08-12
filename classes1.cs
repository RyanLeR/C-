namespace MyNameSpace
{
    
    public class MyCar
    {
        public string? Colour { get; set; }
        public int Year { get; set; }

        public void Intro()
        {
            Console.WriteLine($"This is a {Colour} car of the year {Year}");
        }
    }

}