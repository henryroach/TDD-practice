
public class Roman
{
	public static string ToRoman(string number)
	{
		if (!int.TryParse(number, out var num))
			throw new ArgumentException("Not a number");

		if (num < 1)
			throw new ArgumentException("Too small");

		return IntToRoman(num);
	}

	public static int ToDecimal(string roman)
	{
		return 0;
	}

	private static readonly string[] RomanLetters = {
		"M",
		"CM",
		"D",
		"CD",
		"C",
		"XC",
		"L",
		"XL",
		"X",
		"IX",
		"V",
		"IV",
		"I"
	};

	private static readonly int[] Numbers =
	{
		1000,
		900,
		500,
		400,
		100,
		90,
		50,
		40,
		10,
		9,
		5,
		4,
		1
	};

	private static string IntToRoman(int num) {
		var romanResult = string.Empty;
		var i = 0;
		while (num != 0) {
			if (num >= Numbers[i]) {
				num -= Numbers[i];
				romanResult += RomanLetters[i];
			} else {
				i++;
			}
		}
		return romanResult;
	}

	private static int RomanToInt(string roman) {
	}
}