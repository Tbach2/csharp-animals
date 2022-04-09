using System.Collections;

namespace csharp_animals
{
    class Program
    {
        private static FileOutput outFile = new FileOutput("animals.txt");
        private static FileInput inFile = new FileInput("animals.txt");
        static void Main(string[] args)
        {

            ArrayList zoo = new ArrayList();

            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach (ITalkable thing in zoo)
            {
                printOut(thing);
            }
            outFile.fileClose();
            inFile.fileRead();
            inFile.fileClose();

            FileInput indata = new FileInput("animals.txt");
            string line;
            while ((line = indata.fileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void printOut(ITalkable p)
        {
            Console.WriteLine(p.getName() + " says=" + p.talk());
            outFile.fileWrite(p.getName() + " | " + p.talk());
        }
    }
}
