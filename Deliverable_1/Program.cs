using System;
Console.WriteLine("Enter an integer number bewtween 1 and 100:");
int input = int.Parse(Console.ReadLine());

Console.Write("Specify the series bye: Even or Odd");
string series = Console.ReadLine();

if (series == "Odd")
{
	Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + "are:");
	for (int i = 0; i < input; i = i + 2)
	{
		Console.WriteLine(i);
	}
}

if (series == "Even")
{
	Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + "are:");
	for (int i = 0; i < input; i = i + 2)
	{
		Console.WriteLine(i);
	}
}
