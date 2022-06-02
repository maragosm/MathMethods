using System;

namespace Math_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math Input
            Console.WriteLine("Pick a number, any number!");
            int basenum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now pick another..");
            int newnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now, enter an operand ( + , - , * , / )");
            string operand = Console.ReadLine();

            //Math Output and Method Calling
            switch (operand)
            {
                case "*":
                    Console.WriteLine($"{basenum} times {newnum} is {multmath(basenum, newnum)}");
                    break;

                case "/":
                    Console.WriteLine($"{basenum} divided by {newnum} is {divmath(basenum, newnum)}");
                    break;

                case "+":
                    Console.WriteLine($"{basenum} plus {newnum} is {addmath(basenum, newnum)}");
                    break;

                case "-":
                    Console.WriteLine($"{basenum} minus {newnum} is {submath(basenum, newnum)}");
                    break;
            }

            //Interactive Story Intro
            Console.WriteLine();
            Console.WriteLine("Great! Now, are you intersted in a story? (Yes/No)");
            string story = Console.ReadLine();

            //Interactive Story Input
            if (story.ToLower() == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Hello! Welcome to the C# interactive story.");
                Console.WriteLine("To begin, please enter your favorite place below.");
                var place = Console.ReadLine();
                Console.WriteLine("Now, enter your favorite animal.");
                var animal = Console.ReadLine();
                Console.WriteLine("Great! Lastly, enter your favorite snack.");
                var snack = Console.ReadLine();
                Console.WriteLine();

                //Interactive Story
                Console.WriteLine("Ladies and Gentlemen, let the story begin!");
                Console.WriteLine("A giant named Bill once lived on a hill.");
                Console.WriteLine($"He loved his giant pet {animal} Jill.");
                Console.WriteLine($"They played, ate {snack}, never getting their fill.");
                Console.WriteLine($"They visited {place} all just for the thrill.");
                Console.WriteLine("Till' one day they shrunk, both giants no more!");
                Console.WriteLine($"No longer a {animal}, Jill now was a boar.");
                Console.WriteLine("Astonished, Bill wondered, is that sound a snore?");
                Console.WriteLine("He looked over and there layed his wife, Lenore.");
                Console.WriteLine("Darn! I was sleeping, oh what a chore...");
            }
            else
            { 
                Console.WriteLine("Alrighty then, keep your secrets.");
            }


        }

        //Math Methods
        public static int multmath(int basenum, int newnum)
        {
            int multnum = basenum * newnum;
            return multnum;
        }

        public static int divmath(int basenum, int newnum)
        {
            int divnum = basenum / newnum;
            return divnum;
        }

        public static int addmath(int basenum, int newnum)
        {
            int addnum = basenum * newnum;
            return addnum;
        }

        public static int submath(int basenum, int newnum)
        {
            int subnum = basenum * newnum;
            return subnum;
        }
    }
}
