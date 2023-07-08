namespace HULK;

public static class Interpreter
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Welcome HULK! Type \"help\" for more information.");
		
		while(true)
		{
			Console.Write("> ");
			string line = Console.ReadLine()!;

			if(line == "exit")
			{
				Environment.Exit(0);
			}

			Console.Write(
				Lexer.Split(line));
		}
	}
}