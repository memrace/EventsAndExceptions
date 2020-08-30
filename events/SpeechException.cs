using System;
using System.Collections.Generic;
using System.Text;

namespace events
{
	class SpeechException: Exception
	{
		public SpeechException(string message) : base(message){}
	}
}
