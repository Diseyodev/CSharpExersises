namespace Exercises.Easy
{
    public class OneForMe
    {
        public static string Speak(string name = "you")
        {
            if (string.IsNullOrWhiteSpace(name))
                name = "you";

            return $"One for {name}, one for me!";
        }
    }
}