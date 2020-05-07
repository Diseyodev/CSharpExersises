namespace Exercises.Easy
{
    public class HelloWorld
    {
        public static string Greet(string name = "World")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "World";
            }

            return $"Hello {name}!";
        }
    }
}