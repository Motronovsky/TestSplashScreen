using System.Diagnostics;

static class Program
{
	static void Main()
	{
		Console.WriteLine("Program started.");
		ShowSplashScreen();
		Console.WriteLine("Program works.");
		Console.WriteLine("Some work result.");
		Console.WriteLine("Close program.");
		Console.ReadKey();
	}

	static void ShowSplashScreen()
	{
		string pathToProgram = Path.Combine(Directory.GetCurrentDirectory(), "SplashScreen", "SplashScreen.exe");

		using (var process = Process.Start(new ProcessStartInfo
		{
			FileName = pathToProgram,
			UseShellExecute = true
		}))
		{
			Console.WriteLine("Starting splash screen.");
			process?.WaitForExit();
			Console.WriteLine("Splash screen is closed.");
		}
	}
}