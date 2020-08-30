using events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndExceptions
{
	class Speech
	{
		/// <summary>
		/// Создает делегат ивента.
		/// </summary>
		public event EventHandler SpeechCreated;
		public string Theme { get; set; }
		public string Creator { get; set; }
		
		public Speech(string creator, string theme)
		{
			Theme = theme;
			Creator = creator;
		}
		/// <summary>
		/// Метод ответственный за уведомление зарегистрированных объектов о событии.
		/// </summary>
		/// <param name="e"></param>
		public void OnSpeechCreate(SpeechEventArgs e)
		{
			SpeechCreated?.Invoke(this, e);
		}



	}

	/// <summary>
	/// Определяет объект для хранения всей необходимой информации, передаваемой получателем уведомления события.
	/// </summary>
	class SpeechEventArgs : EventArgs //
	{
		public SpeechEventArgs(Speech speech)
		{
			CreatedTheme = speech.Theme;
			Creator = speech.Creator;
		}

		public String CreatedTheme { get; }
		public String Creator { get; }

	}

	
}
