using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the classroom in inches. ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the classroom in inches. ");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        double perimeter = length + length + width + width;
        Console.WriteLine("\n" + "The area of your classroom is: " + area + " Sq inches" + "\n" + "\n" + "The perimeter of your classroom is: " + perimeter + " inches" + "\n");
        if (area < 250)
        {
            Console.WriteLine("Your classroom size is small.");
        }
        else if (area > 250 && area < 650)
        {
            Console.WriteLine("Your classroom size is medium.");
        }
        else { Console.WriteLine("Your classroom is large."); }
        Console.Write("\n" + "\n" + "Enter the height of the classroom in inches if you would like the volume and surface area calculated too: ");
        double height = double.Parse(Console.ReadLine());
        double volume = length * width * height;
        double surfacearea = 2 * length * width + 2 * length * height + 2 * width * height;
        Console.WriteLine("\n" + "\n" + "The volume of your classroom is: " + volume + " inches" + "\n" + "\n" + "The surface area of your classroom is: " + surfacearea + " Sq inches" + "\n" + "\n");

    }
}