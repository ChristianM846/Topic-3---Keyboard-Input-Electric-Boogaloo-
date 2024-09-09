namespace Topic_3___Keyboard_Input__Electric_Boogaloo_
{
    //Christian Moyes
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int currentYear = DateTime.Now.Year;
            int int1, int2, int3;
            double distance1, distance2, distance3;
            double leg1, leg2;
            double hypotenuse;

            //Part 1

            Console.WriteLine("Part 1");
            Console.WriteLine();
            Console.WriteLine("Hello user, what is your name?");
            name = Console.ReadLine().Trim();

            while (name == "")
            {
                Console.WriteLine("I'm sorry, I need a name to call you by. Try again.");
                name = Console.ReadLine().Trim();
            }

            Console.WriteLine($"Hello {name}, tell me your age, and I will tell you the year you were born");
            Console.WriteLine("How old are you? Please enter your age:");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out age) || age <= 0 || age > 150)
            {
                Console.WriteLine("That is not a valid response, inputted age must be a whole number between 1-150. Please try again:");
            }

            Console.WriteLine($"Okay {name}, if you are {age} year(s) old, the current year is {currentYear}, than you would have been born in {currentYear - age}, give or take a year given what month you were born.");
            Console.WriteLine();

            // Part 2

            Console.WriteLine("Part 2");
            Console.WriteLine();
            Console.WriteLine($"Okay {name}, now you're going to give me three integers, and I'll tell you their sum");










        }
    }
}
