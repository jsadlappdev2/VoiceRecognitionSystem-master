using System;

using Xamarin.Forms;

namespace VoiceRecognitionSystem
{
	public interface ISpeechToText
	{
		void Start ();
		void Stop ();
		event EventHandler<EventArgsVoiceRecognition> textChanged;
	}
}

