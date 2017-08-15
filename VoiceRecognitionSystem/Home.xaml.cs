using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VoiceRecognitionSystem
{
	public partial class Home : ContentPage
	{

		public delegate ContentPage GetEditorInstance (string InitialEditorText);
		static public GetEditorInstance EditorFactory;
		static ISpeechToText speechRecognitionInstnace;
		public Home ()
		{
			InitializeComponent ();
#if __ANDROID__
			androidLayout.IsVisible = true;
			voiceButton.OnTextChanged += (s) => {
				textLabelDroid.Text = s;
			};
#endif
#if __IOS__
			iOSLayout.IsVisible = true;
			this.Content = iOSLayout;
			speechRecognitionInstnace = DependencyService.Get<ISpeechToText> ();
			speechRecognitionInstnace.textChanged += OnTextChange;
#endif

		}

		public void OnStart (Object sender, EventArgs args)
		{
			speechRecognitionInstnace.Start ();
			nameButtonStart.IsEnabled = false;
			nameButtonStop.IsEnabled = true;
		}
		public void OnStop (Object sender, EventArgs args)
		{
			speechRecognitionInstnace.Stop ();
			nameButtonStart.IsEnabled = true;
			nameButtonStop.IsEnabled = false;

		}
		public void OnTextChange (object sender, EventArgsVoiceRecognition e)
		{
			textLabeliOS.Text = e.Text;
			if (e.IsFinal) {
				nameButtonStart.IsEnabled = true;
			}
		}
	}
}
