namespace HULK;

public static class Lexer
{
	public static string Split(string line)
	{
		if(!line.EndsWith(";"))
		{
			Console.WriteLine("! SYNTAX ERROR: Missing line semi-colon.");
			return "";
		}

		return line + "\n";
	}
}