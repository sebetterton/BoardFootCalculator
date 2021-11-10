using System;


namespace BoardFootCalculator
{
    class Program
    {

        static void Main(string[] args)
        {

            for  (Dimensions.Id = 0; i ++; i < 18)
            {
                Console.WriteLine("The dimensions of a " + Dimensions.size + "is " + Dimensions.width + " inches wide by  " + Dimensions.length + " inches long by  " + Dimensions.thickness + " inches thick.");
            }

            foreach ((Wood.type, Wood.cost)in WoodRepository)
            {
                Console.WriteLine(type + " costs " + cost + " per board foot.");
            }
        }
    }
}
