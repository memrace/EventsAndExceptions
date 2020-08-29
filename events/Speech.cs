using events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndExceptions
{
	class Speech
	{
		private readonly User _creator;


		public event EventHandler SpeechCreated; // Создаем событие-делегат.
		public string Theme { get; set; }
		public string Creator => _creator.Name;
		
		public Speech(User creator, string theme)
		{
			Theme = theme;
			_creator = creator;
		}

		public void OnSpeechCreate(SpeechEventArgs e) // Функция-обработчик делегата.
		{
			EventHandler speechCreated = SpeechCreated;
			if (speechCreated != null)
			{
				speechCreated(this, e);
			}
		}



	}


	class SpeechEventArgs : EventArgs //
	{
		private readonly string _createdTheme;
		private readonly string _creator;

		public SpeechEventArgs(Speech speech)
		{
			_createdTheme = speech.Theme;
			_creator = speech.Creator;
		}

		public String CreatedTheme => _createdTheme;
		public String Creator => _creator;

	}

	
}
