using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Globalization;

Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.WriteLine("Enter the length");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the width");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the height");
double height = double.Parse(Console.ReadLine());

double area = width * length;
Console.WriteLine($"The area of the room is {area}");

double permitter = 2 * (length + width);
Console.WriteLine($"The permitter of the room is {permitter}");

double volume = length * width * height;
Console.WriteLine($"The volume of the room is {volume}");

double sarea = 2 * (length * width + length * height + width * height);
Console.WriteLine($"The surface area of the room is {sarea}");

if (area <= 250)
{
    Console.WriteLine("The room is small");
}
else if (area > 250 && area <  650)
{
    Console.WriteLine("The room is medium sized");
}
else
{
    Console.WriteLine("The room is large");
}
