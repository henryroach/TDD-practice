

try
{
	if (args.Length != 1)
	{
		Console.WriteLine("No number to convert");
		return;
	}

	var number = args[0];

	Console.WriteLine($"{number} in roman is: {Roman.ToRoman(number)}");
}
catch (Exception e)
{
	Console.WriteLine("That is not a number");
}

