using System;
using Xamarin.Forms;

namespace VoiceRecognitionSystem
{
	public class VoiceButton : Button
	{
		public Action<string> OnTextChanged { get; set; }
	}

}
