using System;
using events;

namespace EventsAndExceptions
{
	class Program
	{
		private static Speech speech = new Speech("Alex", "ThemeEvent");
		static void Main(string[] args)
		{
			
			User user = new User("Alex", speech);

			CreateTheme();
			
		}

		public static void CreateTheme()
		{
			SpeechEventArgs speechEventArgs = new SpeechEventArgs(speech);
			speech.OnSpeechCreate(speechEventArgs);
		}
	}
}
