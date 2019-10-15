using Bling.Challenge8;
using System;

namespace Bling
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Original array");
            ArrayHelper.PrintArray(array);
            Console.WriteLine();

            Console.WriteLine("Challenge 1");
            Challenge1.RotateArray(array, 4, Challenge1.Direction.Left);
            ArrayHelper.PrintArray(array);
            Console.WriteLine();

            Console.WriteLine("Challenge 2");
            Challenge2.ReorderArray(array);
            ArrayHelper.PrintArray(array);
            Console.WriteLine();

            Console.WriteLine("Challenge 3");
            int days = Challenge3.DaysBetween("10/07/1989", "10/10/2019");
            Console.WriteLine($"Number of days: {days}");
            Console.WriteLine();

            Console.WriteLine("Challenge 4");
            string triangles = Challenge4.GetTriangles(10, 10, 10, 11, 12, 20);
            Console.WriteLine($"{triangles}");

            string text =
@"To be, or not to be, that is the question:
            Whether 'tis nobler in the mind to suffer
            The slings and arrows of outrageous fortune,
            Or to take arms against a sea of troubles
            And by opposing end them. To die—to sleep,
            No more; and by a sleep to say we end
            The heart-ache and the thousand natural shocks
            That flesh is heir to: 'tis a consummation
            Devoutly to be wish'd. To die, to sleep;
            To sleep, perchance to dream—ay, there's the rub:
            For in that sleep of death what dreams may come,
            When we have shuffled off this mortal coil,
            Must give us pause—there's the respect
            That makes calamity of so long life.
            For who would bear the whips and scorns of time,
            Th'oppressor's wrong, the proud man's contumely,
            The pangs of dispriz'd love, the law's delay,
            The insolence of office, and the spurns
            That patient merit of th'unworthy takes,
            When he himself might his quietus make
            With a bare bodkin? Who would fardels bear,
            To grunt and sweat under a weary life,
            But that the dread of something after death,
            The undiscovere'd country, from whose bourn
            No traveller returns, puzzles the will,
            And makes us rather bear those ills we have
            Than fly to others that we know not of?
            Thus conscience does make cowards of us all,
            And thus the native hue of resolution
            Is sicklied o'er with the pale cast of thought,
            And enterprises of great pitch and moment
            With this regard their currents turn awry
            And lose the name of action.";

            bool wordFound = Challenge5.Substring(text, "puzzles");
            Console.WriteLine("Challenge 5");
            Console.WriteLine($"Word Found: {wordFound}");
            Console.WriteLine();

            Rectangle r1 = new Rectangle(new Point(0, 0), new Point(4, 0), new Point(0, 4), new Point(4, 4));
            Rectangle r2 = new Rectangle(new Point(2, 2), new Point(5, 2), new Point(2, 8), new Point(5, 8));

            int area = Challenge6.GetOverlappedAreaOfRectangles(r1, r2);
            Console.WriteLine("Challenge 6");
            Console.WriteLine($"Overlapped Area: {area}");
            Console.WriteLine();

            Edge[] edges = new Edge[]
            {
                new Edge('A', 'B', 7),
                new Edge('A', 'D', 5),
                new Edge('B', 'C', 8),
                new Edge('B', 'D', 9),
                new Edge('B', 'E', 7),
                new Edge('C', 'E', 5),
                new Edge('D', 'E', 15),
                new Edge('D', 'F', 6),
                new Edge('E', 'F', 8),
                new Edge('E', 'G', 9),
                new Edge('F', 'G', 11),
            };

            string paths = Challenge7.FindAllPathsInGraph(edges, 'A', 'E');
            Console.WriteLine("Challenge 7");
            Console.WriteLine(paths);
            
            IComponent<string> aggregate = new ConcreteComponent<string>();

            aggregate.AddElement("Iron Man");
            aggregate.AddElement("Captain America");
            aggregate.AddElement("Thor");
            aggregate.AddElement("Hulk");
            
            Console.WriteLine("Challenge 8");
            foreach (string element in aggregate.GetElements())
                Console.WriteLine(element);
            Console.WriteLine();

            Console.WriteLine("Challenge 9");
            Console.WriteLine("See the .sql file");

            Console.ReadLine();
        }
    }
}