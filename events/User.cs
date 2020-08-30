using System;
using System.Collections.Generic;
using System.Text;
using EventsAndExceptions;

namespace events
{
	/// <summary>
	/// Тип, отслеживающий событие.
	/// </summary>
	class User
	{

		public string Name { get; set; }
		/// <summary>
		/// Передаем в конструторе объект типа, события которого отслеживаем.
		/// Назначаем метод обратного вызова SpeechCreated.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="speech"></param>
		public User(string name, Speech speech)
		{
			Name = name;
			speech.SpeechCreated += Speech_SpeechCreated;
		}
		/// <summary>
		/// Метод реализующий ивент-делегат.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Speech_SpeechCreated(object sender, EventArgs e)
		{
			if (e is SpeechEventArgs)
			{
				SpeechEventArgs spechSpeechEventArgs = e as SpeechEventArgs;
				SpeechCreatedReaction(spechSpeechEventArgs);
			}
		}

		private void SpeechCreatedReaction(SpeechEventArgs spechSpeechEventArgs)
		{
			Console.WriteLine($"Creator is {spechSpeechEventArgs.Creator}, theme is {spechSpeechEventArgs.CreatedTheme}");
		}
	}
}
