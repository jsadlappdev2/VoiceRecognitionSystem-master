using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VoiceRecognitionSystem
{
	public partial class EditorPage : ContentPage, IEditor
	{
		public Editor(string InitialText)
		{
			InitializeComponent();
			editor.Text = InitialText;
		}
		public static Editor GetEditorPage(string InitialText)
		{
			return new Editor(InitialText);

		}

		protected Label Instructions
		{
			get { return instructions; }
		}

		protected Editor EditControl
		{
			get
			{
				return editor;
			}
		}
		protected Button StartButton
		{
			get
			{ return startButton; }
		}

		protected Button StopButton
		{
			get { return stopButton; }
		}

		protected Button CancelButton
		{
			get { return cancelButton; }
		}
	}
}
