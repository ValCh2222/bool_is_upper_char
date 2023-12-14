using System.Text.RegularExpressions;

internal class Program
{
	public static void Main(string[] args)
	{

		if (args.Length < 1)
		{
			Console.WriteLine($"\nargs < 1;");
			return;
		}
		
		var readChar = args[0];

		if (Regex.IsMatch(readChar, "[^A-Za-z]+"))
		{
			Console.WriteLine($"\nСимвол не является буквой из латинского алфавита");
			return;
		}

		char symbol;
		try
		{
			symbol = char.Parse(readChar);
		}
		catch (Exception e)
		{
			Console.WriteLine($"\nВведенные данные не являются символом");
			return;
		}
		
		var isUpperCase = CheckUpperCase(symbol);

		Console.WriteLine("\nРезультат:");
		if (isUpperCase)
			Console.WriteLine("Символ является заглавной буквой латинского алфавита.");
		else
			Console.WriteLine("Символ не является заглавной буквой латинского алфавита.");
	}
	
	static bool CheckUpperCase(char symbol)
	{
		return symbol >= 'A' && symbol <= 'Z';
	}
}