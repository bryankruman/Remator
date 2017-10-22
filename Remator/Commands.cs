using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Remator
{
	public class Commands
	{
		public static Commands list = new Commands();

		[Command("it works")]
		public void ITWorks(SpeechRecognizedEventArgs args)
		{
			Console.WriteLine(args.Result.Semantics["trigger"].Value.ToString());
			Console.WriteLine("It works!");
		}

		[Command("shutdown")]
		public void Shutdown(SpeechRecognizedEventArgs args)
		{
			var synth = new SpeechSynthesizer();
			synth.SetOutputToDefaultAudioDevice();
			synth.Speak("Goodbye.");
			Remator.ActiveForm.Close();
		}

		[Command("what's the weather like")]
		[Command("what temperature is it outside")]
		[Command("what's the temperature outside")]
		[Command("what's the outside temperature")]
		public void GetWeather(SpeechRecognizedEventArgs args)
		{
			Console.WriteLine(args.Result.Text);
			Remator.synth_SynthesizeSpeech("It's currently 65 degrees outside");
		}

		[Command("what's the current time")]
		[Command("tell me the time")]
		[Command("what time is it")]
		[Command("what's the time")]
		public void GetTime(SpeechRecognizedEventArgs args)
		{
			Remator.synth_SynthesizeSpeech(DateTime.Now.ToString("hh:mm tt"));
			Console.WriteLine(DateTime.Now.ToString("hh:mm tt"));
		}

		[Command("what's the current date")]
		[Command("what's the date")]
		[Command("tell me the date")]
		[Command("tell me the day")]
		[Command("what day is it")]
		public void GetDate(SpeechRecognizedEventArgs args)
		{
			Remator.synth_SynthesizeSpeech(DateTime.Now.ToString("dddd, MMMM d"));
		}

		/*[Command("mator")]
		[Command("")]
		public void Mator()
		{
			Remator.synth_SynthesizeSpeech("I didn't catch that, try again?");
			//Console.WriteLine("mator!!!!!");
		}*/
	}

	[System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = true)]
	public class CommandAttribute : System.Attribute
	{
		public string CommandValue { get; set; }

		public CommandAttribute(string textValue)
		{
			CommandValue = textValue;
		}
	}
}
