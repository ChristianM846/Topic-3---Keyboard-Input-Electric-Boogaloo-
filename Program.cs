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
            double averageDistance;
            double leg1, leg2;
            double hypotenuse;

            //Part 1 - Greetings

            Console.WriteLine("Part 1");
            Console.WriteLine();
            Console.WriteLine("Hello user, what is your name?");
            name = Console.ReadLine().Trim();

            while (name == "")
            {
                Console.WriteLine("I'm sorry, I need a name to call you by. Try again.");
                name = Console.ReadLine().Trim();
            }

            Console.WriteLine($"Hello {name}, tell me your age, and I will tell you the year you were born.");
            Console.WriteLine("How old are you? Please enter your age:");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out age) || age <= 0 || age > 150)
            {
                Console.WriteLine("That is not a valid response, inputted age must be a whole number between 1-150. Please try again:");
            }

            Console.WriteLine($"Okay {name}, if you are {age} year(s) old, and the current year is {currentYear}, than you would have been born in {currentYear - age}, give or take a year given what month you were born.");
            Console.WriteLine();

            // Part 2 - Adder

            Console.WriteLine("Part 2");
            Console.WriteLine();
            Console.WriteLine($"Okay {name}, now you're going to give me three whole numbers, and I'll tell you their sum");
            Console.WriteLine("Give me the first number:");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out int1))
            {
                Console.WriteLine("That is not a whole number, try again");
            }

            Console.WriteLine($"Okay, the first number is {int1}, now give me the second:");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out int2))
            {
                Console.WriteLine("That is not a whole number, try again");
            }

            Console.WriteLine($"Okay, the second number is {int2}, now for the third:");

            if (Int32.TryParse(Console.ReadLine().Trim(), out int3))
            {
                Console.WriteLine($"Okay, the third number is {int3}, now to find their sum!");
            }
            else
            {
                int3 = 69;
                Console.WriteLine($"Normally I'd make you try again until you inputted a whole number, but instead I'm just gonna make the third number 69. Have fun!");
            }

            Console.WriteLine($"So, {int1} + {int2} + {int3} = {int1 + int2 + int3}. Cool!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.WriteLine();

            // Part 3 - Distance

            Console.WriteLine("Part 3");
            Console.WriteLine();
            Console.WriteLine("Now let's do something else! Give me three distances in km (can have decimals) and I'll tell you the average.");
            Console.WriteLine("So, what's the first distance? (Don't include 'km' in your response)");

            while (!Double.TryParse(Console.ReadLine().Trim(), out distance1) || distance1 <= 0)
            {
                Console.WriteLine("That is not a valid response, try again");
            }

            Console.WriteLine($"Okay, the first distance is {distance1} km. Now for the second.");

            while (!Double.TryParse(Console.ReadLine().Trim(), out distance2) || distance2 <= 0)
            {
                Console.WriteLine("That is not a valid response, try again");
            }

            Console.WriteLine($"Okay, the second distance is {distance2} km. Now for the third.");

            while (!Double.TryParse(Console.ReadLine().Trim(), out distance3) || distance3 <= 0)
            {
                Console.WriteLine("That is not a valid response, try again");
            }

            averageDistance = (distance1 + distance2 + distance3)/3;

            Console.WriteLine($"Okay, the third distance is {distance3} km. Now let's find the average. Press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine($"So if the three distances are {distance1} km, {distance2} km, {distance3}km...");
            Console.WriteLine($"The average would be... {Math.Round(averageDistance, 2)} km!");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine();

            //Part 4 - Hypotenuse

            Console.WriteLine("Part 4");
            Console.WriteLine();
            Console.WriteLine($"Finally {name}, I want you to give me the lengths of the two legs of a triange (in cm), and I'll give you the hypotenuse ");
            Console.WriteLine("So, what's the length of the first leg? (Don't include 'cm' in your respone)");

            while (!Double.TryParse(Console.ReadLine().Trim(), out leg1) || leg1 <= 0)
            {
                Console.WriteLine("Theat is not a valid response, try again.");
            }

            Console.WriteLine($"Okay, the first leg is {leg1} cm long. And how long is the second?");

            while (!Double.TryParse(Console.ReadLine().Trim(), out leg2) || leg2 <= 0)
            {
                Console.WriteLine("Theat is not a valid response, try again.");
            }

            hypotenuse = Math.Round(Math.Sqrt((leg1 * leg1) + (leg2 * leg2)), 2);

            Console.WriteLine($"Okay, the second leg is {leg2} cm long. Now let's find the hypotenuse.");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine($"If leg 1 is {leg1} cm, and leg 2 is {leg2} cm, than the hypotenuse is {hypotenuse} cm long.");
            Console.WriteLine("Press ENTER to close program");
            Console.ReadLine();
            Console.WriteLine($"Goodbye {name}!");





        }
    }
}
