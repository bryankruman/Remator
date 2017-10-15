using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Remator
{
	public partial class Remator : Form
	{
		private static Dictionary<string, MethodInfo> commandDictionary = new Dictionary<string, MethodInfo>();

		public static Dictionary<string, MethodInfo> GetCommands()
		{
			if (commandDictionary.Count == 0)
			{
				var methods = typeof(Commands).GetMethods(
					BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance
				);

				var speechAttributeMethods = methods.Where(
					y => y.GetCustomAttributes().OfType<CommandAttribute>().Any()
				);

				foreach (var speechAttributeMethod in speechAttributeMethods)
				{
					foreach (var attribute in speechAttributeMethod.GetCustomAttributes(true))
					{
						commandDictionary.Add(
							((CommandAttribute)attribute).CommandValue, speechAttributeMethod
						);
					}
				}
			}

			return commandDictionary;
		}

		public static MethodInfo GetMethod(string Command)
		{
			return GetCommands()[Command];
		}

		public Remator()
		{
			InitializeComponent();
		}

		static SpeechRecognitionEngine engine;
		//static SpeechSynthesizer synth ;
		private void Remator_Load(object sender, EventArgs e)
		{
			engine = new SpeechRecognitionEngine();
			engine.SetInputToDefaultAudioDevice();
			engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);

			Choices choices = new Choices(GetCommands().Keys.ToArray());
			Grammar grammar = new Grammar(new GrammarBuilder(choices));
			engine.LoadGrammar(grammar);

			engine.RecognizeAsync(RecognizeMode.Multiple);
		}

		static void engine_SpeechRecognized(object ob, SpeechRecognizedEventArgs args)
		{
			GetMethod(args.Result.Text).Invoke(Commands.list, null);
		}

		public static void synth_SynthesizeSpeech(string speechText)
		{
			var synth = new SpeechSynthesizer();
			//synthesizer.SelectVoice()
			synth.SetOutputToDefaultAudioDevice();
			synth.SpeakAsync(speechText);
			//synth.Dispose();
			//synth = null;
		}
	}

	public class Commands
	{
		public static Commands list = new Commands();

		[Command("mator what's the weather like")]
		[Command("mator what temperature is it outside")]
		[Command("mator what's the temperature outside")]
		[Command("mator what's the outside temperature")]
		public void GetWeather()
		{
			Remator.synth_SynthesizeSpeech("It's currently 45 degrees outside");
		}

		[Command("mator what time is it")]
		[Command("mator what's the time")]
		public void GetTime()
		{
			Remator.synth_SynthesizeSpeech(DateTime.Now.ToLocalTime().ToShortTimeString());
			Console.WriteLine(DateTime.Now.ToLocalTime().ToShortTimeString());
		}

		/*[Command("mator")]
		[Command("mater")]
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
